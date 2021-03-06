#include "TextAnalyzer.h"
#include "Factory.h"
#include "DWriteTypeConverter.h"
#include "ItemizerHelper.h"

namespace MS { namespace Internal { namespace Text { namespace TextInterface
{
    TextAnalyzer::TextAnalyzer(
               IDWriteTextAnalyzer* textAnalyzer
              )
    {
        _textAnalyzer = gcnew NativeIUnknownWrapper<IDWriteTextAnalyzer>(textAnalyzer);
    }

    /// <SecurityNote>
    /// Critical    - Calls critical AnalyzeExtendedAndItemize overload
    /// </SecurityNote>
    [SecurityCritical]
    IList<Span^>^ TextAnalyzer::Itemize(
        __in_ecount(length) const WCHAR* text,
        UINT32                           length,
        CultureInfo^                     culture,
        Factory^                         factory,
        bool                             isRightToLeftParagraph,
        CultureInfo^                     numberCulture,
        bool                             ignoreUserOverride,
        UINT32                           numberSubstitutionMethod,
        IClassification^                 classificationUtility,
        CreateTextAnalysisSink^          pfnCreateTextAnalysisSink,
        GetScriptAnalysisList^           pfnGetScriptAnalysisList,
        GetNumberSubstitutionList^       pfnGetNumberSubstitutionList,
        CreateTextAnalysisSource^        pfnCreateTextAnalysisSource
        )
    {
        // If a text has zero length then we do not need to itemize.
        if (length > 0)
        {
            IDWriteTextAnalyzer* pTextAnalyzer = NULL;
            IDWriteTextAnalysisSink* pTextAnalysisSink = NULL;
            IDWriteTextAnalysisSource* pTextAnalysisSource = NULL;

            // We obtain an AddRef factory so as not to worry about having to call GC::KeepAlive(factory)
            // which puts unnecessary maintenance cost on this code.
            IDWriteFactory* pDWriteFactory = factory->DWriteFactoryAddRef;
            HRESULT hr = S_OK;
            try
            {
                hr = pDWriteFactory->CreateTextAnalyzer(&pTextAnalyzer);
                ConvertHresultToException(hr, "List<Span^>^ TextAnalyzer::Itemize");
                
                pin_ptr<const WCHAR> pNumberSubstitutionLocaleNamePinned;

                // We need this variable since we cannot assign NULL to a pin_ptr<const WCHAR>.
                WCHAR const* pNumberSubstitutionLocaleName = NULL;
                if (numberCulture != nullptr)
                {
                    pNumberSubstitutionLocaleNamePinned = Native::Util::GetPtrToStringChars(numberCulture->IetfLanguageTag);
                    pNumberSubstitutionLocaleName = pNumberSubstitutionLocaleNamePinned;
                }

                pin_ptr<const WCHAR> pCultureName = Native::Util::GetPtrToStringChars(culture->IetfLanguageTag);
                
                // NOTE: the text parameter is NOT copied inside TextAnalysisSource to improve perf.
                // This is ok as long as we use the TextAnalysisSource in the same scope as we hold ref to text.
                // If we are ever to change this pattern then this should be revisited in TextAnalysisSource in
                // PresentationNative.
                hr = static_cast<HRESULT>(pfnCreateTextAnalysisSource(text,
                                                                      length,
                                                                      pCultureName,
                                                                      (void*)(pDWriteFactory),
                                                                      isRightToLeftParagraph,
                                                                      pNumberSubstitutionLocaleName,
                                                                      ignoreUserOverride,
                                                                      numberSubstitutionMethod,
                                                                      (void**)&pTextAnalysisSource));
                ConvertHresultToException(hr, "List<Span^>^ TextAnalyzer::Itemize");

            
                pTextAnalysisSink = (IDWriteTextAnalysisSink*)pfnCreateTextAnalysisSink();

                // Analyze the script ranges.
                hr = pTextAnalyzer->AnalyzeScript(pTextAnalysisSource,
                                                 0,
                                                 length,
                                                 pTextAnalysisSink);
                ConvertHresultToException(hr, "List<Span^>^ TextAnalyzer::Itemize");

                // Analyze the number substitution ranges.
                hr = pTextAnalyzer->AnalyzeNumberSubstitution(pTextAnalysisSource,
                                                            0,
                                                            length,
                                                            pTextAnalysisSink);
                ConvertHresultToException(hr, "List<Span^>^ TextAnalyzer::Itemize");

                DWriteTextAnalysisNode<DWRITE_SCRIPT_ANALYSIS>*     dwriteScriptAnalysisNode     = (DWriteTextAnalysisNode<DWRITE_SCRIPT_ANALYSIS>*)pfnGetScriptAnalysisList((void*)pTextAnalysisSink);
                DWriteTextAnalysisNode<IDWriteNumberSubstitution*>* dwriteNumberSubstitutionNode = (DWriteTextAnalysisNode<IDWriteNumberSubstitution*>*)pfnGetNumberSubstitutionList((void*)pTextAnalysisSink);
                
                TextItemizer^ textItemizer = gcnew TextItemizer(dwriteScriptAnalysisNode, dwriteNumberSubstitutionNode);
            
                return AnalyzeExtendedAndItemize(textItemizer, text, length, numberCulture, classificationUtility);
            }
            finally
            {
                ReleaseItemizationNativeResources(&pDWriteFactory,
                                                  &pTextAnalyzer,
                                                  &pTextAnalysisSource,
                                                  &pTextAnalysisSink);
            }
        }
        else
        {
            return nullptr;
        }

    }

    /// <SecurityNote>
    /// Critical    - Asserts unmanaged code permission to new and delete native buffer.
    ///             - This method calls into security critical TextItemizer->Itemize() but
    ///               the pointer passed to Itemize() is constructed internally so the call 
    ///               to TextItemizer->Itemize() is safe.
    /// </SecurityNote>
    [SecurityCritical]
    [SecurityPermission(SecurityAction::Assert, UnmanagedCode=true)]
    IList<Span^>^ TextAnalyzer::AnalyzeExtendedAndItemize(
        TextItemizer^ textItemizer, 
        __in_ecount(length) const WCHAR *text, 
        UINT32 length, 
        CultureInfo^ numberCulture, 
        IClassification^ classification
        )
    {
        MS::Internal::Invariant::Assert(length >= 0);

        CharAttributeType* pCharAttribute = new CharAttributeType[length];
        try
        {
            // Analyze the extended character ranges.
            TextAnalyzer::AnalyzeExtendedCharactersAndDigits(text, length, textItemizer, pCharAttribute, numberCulture, classification);
            return textItemizer->Itemize(numberCulture, pCharAttribute, length);
        }
        finally
        {
            delete[] pCharAttribute;
        }
    }

    /// <SecurityNote>
    /// Critical    - Receives pointers, arrays and their bounds as input.
    /// </SecurityNote>
    [SecurityCritical]
    void TextAnalyzer::AnalyzeExtendedCharactersAndDigits(
        __in_ecount(length) const WCHAR* text,
        UINT32                           length,
        TextItemizer^                    textItemizer,
        __out_ecount(length) CharAttributeType* pCharAttribute,
        CultureInfo^                     numberCulture,
        IClassification^                 classificationUtility
        )
    {
        // Text will never be of zero length. This is enforced by Itemize().
        bool isCombining;
        bool needsCaretInfo;
        bool isIndic;
        bool isDigit;
        bool isLatin;
        bool isStrong;
        bool isExtended;

        classificationUtility->GetCharAttribute(
            text[0],
            isCombining,
            needsCaretInfo,
            isIndic,
            isDigit,
            isLatin,
            isStrong
            );

        isExtended = ItemizerHelper::IsExtendedCharacter(text[0]);

        UINT32 isDigitRangeStart = 0;
        UINT32 isDigitRangeEnd = 0;
        bool   previousIsDigitValue = (numberCulture == nullptr) ? false : isDigit;
        bool   currentIsDigitValue;

        // pCharAttribute is assumed to have the same length as text. This is enforced by Itemize().
        pCharAttribute[0] = (CharAttributeType)
                            (((isCombining)    ? CharAttribute::IsCombining    : CharAttribute::None)
                           | ((needsCaretInfo) ? CharAttribute::NeedsCaretInfo : CharAttribute::None)
                           | ((isLatin)        ? CharAttribute::IsLatin        : CharAttribute::None)
                           | ((isIndic)        ? CharAttribute::IsIndic        : CharAttribute::None)
                           | ((isStrong)       ? CharAttribute::IsStrong       : CharAttribute::None)
                           | ((isExtended)     ? CharAttribute::IsExtended     : CharAttribute::None));

        for (UINT32 i = 1; i < length; ++i)
        {
            classificationUtility->GetCharAttribute(
            text[i],
            isCombining,
            needsCaretInfo,
            isIndic,
            isDigit,
            isLatin,
            isStrong
            );

            isExtended = ItemizerHelper::IsExtendedCharacter(text[i]);
            

            pCharAttribute[i] = (CharAttributeType)
                                (((isCombining)    ? CharAttribute::IsCombining    : CharAttribute::None)
                               | ((needsCaretInfo) ? CharAttribute::NeedsCaretInfo : CharAttribute::None)
                               | ((isLatin)        ? CharAttribute::IsLatin        : CharAttribute::None)
                               | ((isIndic)        ? CharAttribute::IsIndic        : CharAttribute::None)
                               | ((isStrong)       ? CharAttribute::IsStrong       : CharAttribute::None)
                               | ((isExtended)     ? CharAttribute::IsExtended     : CharAttribute::None));


            currentIsDigitValue = (numberCulture == nullptr) ? false : isDigit;
            if (previousIsDigitValue != currentIsDigitValue)
            {

                isDigitRangeEnd = i;
                textItemizer->SetIsDigit(isDigitRangeStart, isDigitRangeEnd - isDigitRangeStart, previousIsDigitValue);

                isDigitRangeStart = i;
                previousIsDigitValue = currentIsDigitValue;
            }
        }


        isDigitRangeEnd = i;
        textItemizer->SetIsDigit(isDigitRangeStart, isDigitRangeEnd - isDigitRangeStart, previousIsDigitValue);
    }

    /// <SecurityNote>
    /// Critical    - Receives pointers, arrays and their bounds as input.
    /// </SecurityNote>
    [SecurityCritical]
    void TextAnalyzer::GetBlankGlyphsForControlCharacters(
        __in_ecount(textLength)     const WCHAR*     pTextString,
        UINT32                                       textLength,
        FontFace^                                    fontFace,
        UINT16                                       blankGlyphIndex,
        UINT32                                       maxGlyphCount,
        __out_ecount(textLength)    UINT16*          clusterMap,
        __out_ecount(maxGlyphCount) UINT16*          glyphIndices,
        __out_ecount(textLength)    int*             pfCanGlyphAlone,
        [System::Runtime::InteropServices::Out] UINT32% actualGlyphCount
        )
    {
        actualGlyphCount = textLength;
        // There is not enough buffer allocated. Signal to the caller the correct buffer size.
        if (maxGlyphCount < textLength)
        {
            return;
        }

        if (textLength > UINT16_MAX)
        {
            ConvertHresultToException(E_INVALIDARG, "void TextAnalyzer::GetBlankGlyphsForControlCharacters");
        }

        UINT16 textLengthShort = (UINT16)textLength;

        UINT32 softHyphen = (UINT32)CharHyphen;
        UINT16 hyphenGlyphIndex = 0;
        for (UINT16 i = 0; i < textLengthShort; ++i)
        {
            // LS will sometimes replace soft hyphens (which are invisible) with hyphens (which are visible).
            // So if we are in this code then LS actually did this replacement and we need to display the hyphen (x002D)
            if (pTextString[i] == CharHyphen)
            {
                if (hyphenGlyphIndex == 0)
                {
                    HRESULT hr = fontFace->DWriteFontFaceNoAddRef->GetGlyphIndices(&softHyphen,
                                                1,
                                                &hyphenGlyphIndex
                                                );
                    System::GC::KeepAlive(fontFace);
                    ConvertHresultToException(hr, "void TextAnalyzer::GetBlankGlyphsForControlCharacters");
                }
                glyphIndices[i] = hyphenGlyphIndex;
            }
            else
            {
                glyphIndices[i] = blankGlyphIndex;
            }
            clusterMap     [i] = i;
            pfCanGlyphAlone[i] = 1;
        }
    }

// Dev11:#158013: Warning 4714 (__forceinline function not inlined)
// is expected here because TextAnalyzer::GetGlyphs is marked with [SecurityCritical]
// and tries to inline HRESULT_FROM_WIN32.
// Starting with changeset 172903 (see also Dev11 bugs 4172, 134965, 134979),
// inlining is prevented when the caller or the callee
// are marked with any security attribute (critical, safecritical, treatassafecritical).
// This is over conservative and misses inlining opportunities occasionaly,
// but currently there is no way of determining accurately the transparency level of a function
// in the native compiler since there are no public APIs provided by CLR at the moment.
// Replicating CLR transparency rules on the native side is not ideal either.
// The solution chosen is to allow inlining only when there is clear evidence
// for the caller and the callee to be transparent.
#pragma warning (push)
#pragma warning (disable : 4714)

    /// <SecurityNote>
    /// Critical - Asserts unmanaged code permission 
    ///                 To new and delete native buffers.
    ///                 To perform unsafe reinterpret_casts
    /// </SecurityNote>
    [SecurityCritical]
    [SecurityPermission(SecurityAction::Assert, UnmanagedCode=true)]
    void TextAnalyzer::GetGlyphs(
        __in_ecount(textLength) const WCHAR*         textString,
        UINT32                                       textLength,
        Font^                                        font,
        UINT16                                       blankGlyphIndex,
        bool                                         isSideways,
        bool                                         isRightToLeft,
        CultureInfo^                                 cultureInfo,
        array<array<DWriteFontFeature>^>^            features,
        array<UINT32>^                               featureRangeLengths,
        UINT32                                       maxGlyphCount,
        TextFormattingMode                           textFormattingMode,
        ItemProps^                                   itemProps,
        __out_ecount(textLength) UINT16*             clusterMap,
        __out_ecount(textLength) UINT16*             textProps,
        __out_ecount(maxGlyphCount) UINT16*          glyphIndices,
        __out_ecount(maxGlyphCount) UINT32*          glyphProps,
        __out_ecount(textLength) int*                pfCanGlyphAlone,
        [System::Runtime::InteropServices::Out] UINT32% actualGlyphCount
        )
    {
        // Shaping should not have taken place if ScriptAnalysis is NULL!
        Invariant::Assert(itemProps->ScriptAnalysis != NULL);

        // These are control characters and WPF will not display control characters.
        if (GetScriptShapes(itemProps) != DWRITE_SCRIPT_SHAPES_DEFAULT)
        {
            FontFace^ fontFace = font->GetFontFace();
            try
            {
                GetBlankGlyphsForControlCharacters(
                    textString,
                    textLength,
                    fontFace,
                    blankGlyphIndex,
                    maxGlyphCount,
                    clusterMap,
                    glyphIndices,
                    pfCanGlyphAlone,
                    actualGlyphCount
                    );
            }
            finally
            {
                fontFace->Release();
            }
        }
        else
        {
            String^ localeName = cultureInfo->IetfLanguageTag;
            pin_ptr<const WCHAR> pLocaleName = Native::Util::GetPtrToStringChars(localeName);
            pin_ptr<UINT32> pFeatureRangeLengthsPinned;
            UINT32* pFeatureRangeLengths = NULL;

            UINT32 featureRanges = 0;
            array<GCHandle>^ dwriteFontFeaturesGCHandles = nullptr;
            DWRITE_TYPOGRAPHIC_FEATURES** dwriteTypographicFeatures = NULL;


            if (features != nullptr)
            {
                pFeatureRangeLengthsPinned = &featureRangeLengths[0];
                pFeatureRangeLengths = reinterpret_cast<UINT32*> (pFeatureRangeLengthsPinned);
                featureRanges = (UINT32)featureRangeLengths->Length;
                dwriteFontFeaturesGCHandles = gcnew array<GCHandle>(featureRanges);
                dwriteTypographicFeatures = new DWRITE_TYPOGRAPHIC_FEATURES*[featureRanges];
            }

            FontFace^ fontFace = font->GetFontFace();
            try
            {
                if (features != nullptr)
                {
                    for (UINT32 i = 0; i < featureRanges; ++i)
                    {
                        dwriteFontFeaturesGCHandles[i] = GCHandle::Alloc(features[i], GCHandleType::Pinned);
                        dwriteTypographicFeatures[i] = new DWRITE_TYPOGRAPHIC_FEATURES();
                        dwriteTypographicFeatures[i]->features = reinterpret_cast<DWRITE_FONT_FEATURE*>(dwriteFontFeaturesGCHandles[i].AddrOfPinnedObject().ToPointer());
                        dwriteTypographicFeatures[i]->featureCount = features[i]->Length;
                    }
                }


                UINT32 glyphCount = 0;

                HRESULT hr = _textAnalyzer->Value->GetGlyphs(
                    textString,
                    /*checked*/((UINT32)textLength),
                    fontFace->DWriteFontFaceNoAddRef,
                    isSideways ? TRUE : FALSE,
                    isRightToLeft ? TRUE : FALSE,
                    (DWRITE_SCRIPT_ANALYSIS*)(itemProps->ScriptAnalysis),
                    pLocaleName,
                    (IDWriteNumberSubstitution*)(itemProps->NumberSubstitutionNoAddRef),
                    (DWRITE_TYPOGRAPHIC_FEATURES const**)dwriteTypographicFeatures,
                    pFeatureRangeLengths,
                    featureRanges,
                    /*checked*/((UINT32)maxGlyphCount),
                    clusterMap,
                    (DWRITE_SHAPING_TEXT_PROPERTIES*)textProps, //The size of DWRITE_SHAPING_TEXT_PROPERTIES is 16 bits which is the same size that LS passes to WPF 
                                                                //Thus we can safely cast textProps to DWRITE_SHAPING_TEXT_PROPERTIES*
                    glyphIndices,
                    (DWRITE_SHAPING_GLYPH_PROPERTIES*)glyphProps, //The size of DWRITE_SHAPING_GLYPH_PROPERTIES is 16 bits. LS passes a pointer to UINT32 so this cast is safe since 
                                                                  //We will not write into memory outside the boundary. But this is cast will result in an unused space. We are taking this
                                                                  //Approach for now to avoid modifying LS code.
                    &glyphCount
                    );

                if (E_INVALIDARG == hr)
                {
                    // If pLocaleName is unsupported (e.g. "prs-af"), DWrite returns E_INVALIDARG.
                    // Try again with the default mapping.
                    hr = _textAnalyzer->Value->GetGlyphs(
                        textString,
                        textLength,
                        fontFace->DWriteFontFaceNoAddRef,
                        isSideways ? TRUE : FALSE,
                        isRightToLeft ? TRUE : FALSE,
                        (DWRITE_SCRIPT_ANALYSIS*)(itemProps->ScriptAnalysis),
                        NULL /* default locale mapping */,
                        (IDWriteNumberSubstitution*)(itemProps->NumberSubstitutionNoAddRef),
                        (DWRITE_TYPOGRAPHIC_FEATURES const**)dwriteTypographicFeatures,
                        pFeatureRangeLengths,
                        featureRanges,
                        /*checked*/((UINT32)maxGlyphCount),
                        clusterMap,
                        (DWRITE_SHAPING_TEXT_PROPERTIES*)textProps, //The size of DWRITE_SHAPING_TEXT_PROPERTIES is 16 bits which is the same size that LS passes to WPF 
                                                                    //Thus we can safely cast textProps to DWRITE_SHAPING_TEXT_PROPERTIES*
                        glyphIndices,
                        (DWRITE_SHAPING_GLYPH_PROPERTIES*)glyphProps, //The size of DWRITE_SHAPING_GLYPH_PROPERTIES is 16 bits. LS passes a pointer to UINT32 so this cast is safe since 
                                                                      //We will not write into memory outside the boundary. But this is cast will result in an unused space. We are taking this
                                                                      //Approach for now to avoid modifying LS code.
                        &glyphCount
                        );
                }

                System::GC::KeepAlive(fontFace);
                System::GC::KeepAlive(itemProps);
                System::GC::KeepAlive(_textAnalyzer);

                if (features != nullptr)
                {
                    for (UINT32 i = 0; i < featureRanges; ++i)
                    {
                        dwriteFontFeaturesGCHandles[i].Free();
                        delete dwriteTypographicFeatures[i];
                    }
                }

                if (hr == HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER))
                {
                    // Actual glyph count is not returned by DWrite unless the call tp GetGlyphs succeeds.
                    // It must be re-estimated in case the first estimate was not adequate.
                    // Assurance from DWrite is that 3 * textLength is a sufficient buffer size.
                    // We use this value, but as a fail-safe, add one more check to see if that value is less
                    // than the original estimate passed in. If it is, multiply buffer size by 2. 
                    actualGlyphCount = 3 * textLength;
                    if (actualGlyphCount <= maxGlyphCount)
                    {
                        // Multiplying by 3 is still less than current max, use max * 2.
                        // NOTE: This code is a fail-safe - DWrite's assurance is that 3x is an adequate buffer size.
                        actualGlyphCount = maxGlyphCount * 2;
                    }
                }
                else
                {
                    ConvertHresultToException(hr, "void TextAnalyzer::GetGlyphs");
                    if (pfCanGlyphAlone != NULL)
                    {
                        for (UINT32 i = 0; i < textLength; ++i)
                        {
                            pfCanGlyphAlone[i] = (((DWRITE_SHAPING_TEXT_PROPERTIES*)textProps)[i].isShapedAlone > 0) ? 1 : 0;;                        
                        }
                    }

                    actualGlyphCount = glyphCount;
                }                
            }
            finally
            {
                fontFace->Release();
                if (dwriteTypographicFeatures != NULL)
                {
                    delete[] dwriteTypographicFeatures;
                }
            }
        }
    }

#pragma warning (pop)

    /// <SecurityNote>
    /// Critical    - Receives pointers, arrays and their bounds as input.
    /// </SecurityNote>
    [SecurityCritical]
    void TextAnalyzer::GetGlyphPlacementsForControlCharacters(
        __in_ecount(textLength) const WCHAR* pTextString,
        UINT32 textLength,
        Font^ font,
        TextFormattingMode textFormattingMode,
        double fontEmSize,
        double scalingFactor,
        bool isSideways,
        float pixelsPerDip,
        UINT32 glyphCount,
        __in_ecount(glyphCount) UINT16 const* pGlyphIndices,
        __out_ecount(glyphCount) int* glyphAdvances,
        [System::Runtime::InteropServices::Out] array<GlyphOffset>^% glyphOffsets
        )
    {
        if (glyphCount != textLength)
        {
            ConvertHresultToException(E_INVALIDARG, "void TextAnalyzer::GetGlyphPlacementsForControlCharacters");
        }

        glyphOffsets = gcnew array<GlyphOffset>(textLength);
        FontFace^ fontFace = font->GetFontFace();

        try
        {
            int hyphenAdvanceWidth = -1;
            for (UINT32 i = 0; i < textLength; ++i)
            {
                // LS will sometimes replace soft hyphens (which are invisible) with hyphens (which are visible).
                // So if we are in this code then LS actually did this replacement and we need to display the hyphen (x002D)
                if (pTextString[i] == CharHyphen)
                {
                    if (hyphenAdvanceWidth == -1)
                    {
                        DWRITE_GLYPH_METRICS glyphMetrics;
                        HRESULT hr = S_OK;

                        if (textFormattingMode == TextFormattingMode::Ideal)
                        {
                            hr = fontFace->DWriteFontFaceNoAddRef->GetDesignGlyphMetrics(
                                                                                        pGlyphIndices + i,
                                                                                        1,
                                                                                        &glyphMetrics
                                                                                         );
                        }
                        else
                        {
                            hr = fontFace->DWriteFontFaceNoAddRef->GetGdiCompatibleGlyphMetrics(
                                                                                               (float)fontEmSize,
                                                                                               pixelsPerDip, //FLOAT pixelsPerDip,
                                                                                               NULL, // optional transform
                                                                                               textFormattingMode != TextFormattingMode::Display, //BOOL useGdiNatural,
                                                                                               pGlyphIndices + i, //__in_ecount(glyphCount) UINT16 const* glyphIndices,
                                                                                               1, //UINT32 glyphCount,
                                                                                               &glyphMetrics, //__out_ecount(glyphCount) DWRITE_GLYPH_METRICS* glyphMetrics
                                                                                               isSideways
                                                                                               );
                        }
                        System::GC::KeepAlive(fontFace);
                        ConvertHresultToException(hr, "void TextAnalyzer::GetGlyphPlacementsForControlCharacters");
                        double approximatedHyphenAW = Math::Round(glyphMetrics.advanceWidth * fontEmSize / font->Metrics->DesignUnitsPerEm * pixelsPerDip) / pixelsPerDip;
                        hyphenAdvanceWidth = (int)Math::Round(approximatedHyphenAW * scalingFactor);
                    }

                    glyphAdvances[i] = hyphenAdvanceWidth;
                }
                else
                {
                    glyphAdvances[i] = 0;
                }
                glyphOffsets[i].du = 0;
                glyphOffsets[i].dv = 0;
            }
        }
        finally
        {
            fontFace->Release();
        }
    }

    /// <SecurityNote>
    /// Critical - Asserts unmanaged code permission 
    ///                 To allocate and delete temporary native buffers
    ///                 To perform unsafe reinterpret_casts
    /// </SecurityNote>
    [SecurityCritical]
    [SecurityPermission(SecurityAction::Assert, UnmanagedCode=true)]
    void TextAnalyzer::GetGlyphPlacements(
        __in_ecount(textLength) const WCHAR*                         textString,
        __in_ecount(textLength) UINT16 const*                        clusterMap,
        __in_ecount(textLength) UINT16*                              textProps,
        UINT32                                                       textLength,
        __in_ecount(glyphCount) UINT16 const*                        glyphIndices,
        __in_ecount(glyphCount) UINT32*                              glyphProps,
        UINT32                                                       glyphCount,
        Font^                                                        font,
        double                                                       fontEmSize,
        double                                                       scalingFactor,
        bool                                                         isSideways,
        bool                                                         isRightToLeft,
        CultureInfo^                                                 cultureInfo,
        array<array<DWriteFontFeature>^>^                            features,
        array<UINT32>^                                               featureRangeLengths,
        TextFormattingMode                                           textFormattingMode,
        ItemProps^                                                   itemProps,
        float                                                        pixelsPerDip,
        __out_ecount(glyphCount) int*                                glyphAdvances,
        [System::Runtime::InteropServices::Out] array<GlyphOffset>^% glyphOffsets
        )
    {
        // Shaping should not have taken place if ScriptAnalysis is NULL!
        Invariant::Assert(itemProps->ScriptAnalysis != NULL);

        // These are control characters and WPF will not display control characters.
        if (GetScriptShapes(itemProps) != DWRITE_SCRIPT_SHAPES_DEFAULT)
        {
            GetGlyphPlacementsForControlCharacters(
                textString,
                textLength,
                font,
                textFormattingMode,
                fontEmSize,
                scalingFactor,
                isSideways,
                pixelsPerDip,
                glyphCount,
                glyphIndices,
                glyphAdvances,
                glyphOffsets
                );
        }
        else
        {
            FLOAT*                       dwriteGlyphAdvances       = new FLOAT                      [glyphCount];
            DWRITE_GLYPH_OFFSET*         dwriteGlyphOffsets        = new DWRITE_GLYPH_OFFSET        [glyphCount];

            array<GCHandle>^ dwriteFontFeaturesGCHandles = nullptr;
            UINT32 featureRanges = 0;
            DWRITE_TYPOGRAPHIC_FEATURES** dwriteTypographicFeatures = NULL;
            pin_ptr<UINT32> pFeatureRangeLengthsPinned;
            UINT32* pFeatureRangeLengths = NULL;

            if (features != nullptr)
            {
                featureRanges = (UINT32)featureRangeLengths->Length;
                dwriteTypographicFeatures = new DWRITE_TYPOGRAPHIC_FEATURES*[featureRanges];
                pFeatureRangeLengthsPinned = &featureRangeLengths[0];
                pFeatureRangeLengths = reinterpret_cast<UINT32*> (pFeatureRangeLengthsPinned);
                dwriteFontFeaturesGCHandles = gcnew array<GCHandle>(featureRanges);
            }

            FontFace^ fontFace = font->GetFontFace();
            try
            {
                String^ localeName = cultureInfo->IetfLanguageTag;
                pin_ptr<const WCHAR> pLocaleName = Native::Util::GetPtrToStringChars(localeName);
                DWRITE_MATRIX transform = Factory::GetIdentityTransform();

                if (features != nullptr)
                {
                    for (UINT32 i = 0; i < featureRanges; ++i)
                    {
                        dwriteFontFeaturesGCHandles[i] = GCHandle::Alloc(features[i], GCHandleType::Pinned);
                        dwriteTypographicFeatures[i] = new DWRITE_TYPOGRAPHIC_FEATURES();
                        dwriteTypographicFeatures[i]->features = reinterpret_cast<DWRITE_FONT_FEATURE*>(dwriteFontFeaturesGCHandles[i].AddrOfPinnedObject().ToPointer());
                        dwriteTypographicFeatures[i]->featureCount = features[i]->Length;
                    }
                }

                FLOAT fontEmSizeFloat = (FLOAT)fontEmSize;
                HRESULT hr = E_FAIL;

                if (textFormattingMode == TextFormattingMode::Ideal)
                {   
                    hr = _textAnalyzer->Value->GetGlyphPlacements(
                        textString,
                        clusterMap,
                        (DWRITE_SHAPING_TEXT_PROPERTIES*)textProps,
                        textLength,
                        glyphIndices,
                        (DWRITE_SHAPING_GLYPH_PROPERTIES*)glyphProps,
                        glyphCount,
                        fontFace->DWriteFontFaceNoAddRef,
                        fontEmSizeFloat,
                        isSideways ? TRUE : FALSE,
                        isRightToLeft ? TRUE : FALSE,
                        (DWRITE_SCRIPT_ANALYSIS*)(itemProps->ScriptAnalysis),
                        pLocaleName,
                        (DWRITE_TYPOGRAPHIC_FEATURES const**)dwriteTypographicFeatures,
                        pFeatureRangeLengths,
                        featureRanges,
                        dwriteGlyphAdvances,
                        dwriteGlyphOffsets
                        );

                    if (E_INVALIDARG == hr)
                    {
                        // If pLocaleName is unsupported (e.g. "prs-af"), DWrite returns E_INVALIDARG.
                        // Try again with the default mapping.
                        hr = _textAnalyzer->Value->GetGlyphPlacements(
                            textString,
                            clusterMap,
                            (DWRITE_SHAPING_TEXT_PROPERTIES*)textProps,
                            textLength,
                            glyphIndices,
                            (DWRITE_SHAPING_GLYPH_PROPERTIES*)glyphProps,
                            glyphCount,
                            fontFace->DWriteFontFaceNoAddRef,
                            fontEmSizeFloat,
                            isSideways ? TRUE : FALSE,
                            isRightToLeft ? TRUE : FALSE,
                            (DWRITE_SCRIPT_ANALYSIS*)(itemProps->ScriptAnalysis),
                            NULL /* default locale mapping */,
                            (DWRITE_TYPOGRAPHIC_FEATURES const**)dwriteTypographicFeatures,
                            pFeatureRangeLengths,
                            featureRanges,
                            dwriteGlyphAdvances,
                            dwriteGlyphOffsets
                            );
                    }
                    
                }
                else
                {
                    assert(textFormattingMode == TextFormattingMode::Display);

                    hr = _textAnalyzer->Value->GetGdiCompatibleGlyphPlacements(
                        textString,
                        clusterMap,
                        (DWRITE_SHAPING_TEXT_PROPERTIES*)textProps,
                        textLength,
                        glyphIndices,
                        (DWRITE_SHAPING_GLYPH_PROPERTIES*)glyphProps,
                        glyphCount,
                        fontFace->DWriteFontFaceNoAddRef,
                        fontEmSizeFloat,
                        pixelsPerDip,
                        &transform,
                        FALSE,  // useGdiNatural
                        isSideways ? TRUE : FALSE,
                        isRightToLeft ? TRUE : FALSE,
                        (DWRITE_SCRIPT_ANALYSIS*)(itemProps->ScriptAnalysis),
                        pLocaleName,
                        (DWRITE_TYPOGRAPHIC_FEATURES const**)dwriteTypographicFeatures,
                        pFeatureRangeLengths,
                        featureRanges,
                        dwriteGlyphAdvances,
                        dwriteGlyphOffsets
                        );

                    if (E_INVALIDARG == hr)
                    {
                        // If pLocaleName is unsupported (e.g. "prs-af"), DWrite returns E_INVALIDARG.
                        // Try again with the default mapping.
                        hr = _textAnalyzer->Value->GetGdiCompatibleGlyphPlacements(
                            textString,
                            clusterMap,
                            (DWRITE_SHAPING_TEXT_PROPERTIES*)textProps,
                            textLength,
                            glyphIndices,
                            (DWRITE_SHAPING_GLYPH_PROPERTIES*)glyphProps,
                            glyphCount,
                            fontFace->DWriteFontFaceNoAddRef,
                            fontEmSizeFloat,
                            pixelsPerDip,
                            &transform,
                            FALSE,  // useGdiNatural
                            isSideways ? TRUE : FALSE,
                            isRightToLeft ? TRUE : FALSE,
                            (DWRITE_SCRIPT_ANALYSIS*)(itemProps->ScriptAnalysis),
                            NULL /* default locale mapping */,
                            (DWRITE_TYPOGRAPHIC_FEATURES const**)dwriteTypographicFeatures,
                            pFeatureRangeLengths,
                            featureRanges,
                            dwriteGlyphAdvances,
                            dwriteGlyphOffsets
                            );
                    }
                }

                System::GC::KeepAlive(fontFace);
                System::GC::KeepAlive(itemProps);
                System::GC::KeepAlive(_textAnalyzer);

                if (features != nullptr)
                {
                    for (UINT32 i = 0; i < featureRanges; ++i)
                    {
                        dwriteFontFeaturesGCHandles[i].Free();
                        delete dwriteTypographicFeatures[i];
                    }
                }

                glyphOffsets = gcnew array<GlyphOffset>(glyphCount);
                if (textFormattingMode == TextFormattingMode::Ideal)
                {
                    for (UINT32 i = 0; i < glyphCount; ++i)
                    {
                        glyphAdvances[i] = (int)Math::Round(dwriteGlyphAdvances[i] * fontEmSize * scalingFactor / fontEmSizeFloat);
                        glyphOffsets[i].du = (int)(dwriteGlyphOffsets[i].advanceOffset * scalingFactor);
                        glyphOffsets[i].dv = (int)(dwriteGlyphOffsets[i].ascenderOffset * scalingFactor);
                    }
                }
                else
                {
                    for (UINT32 i = 0; i < glyphCount; ++i)
                    {
                        glyphAdvances[i] = (int)Math::Round(dwriteGlyphAdvances[i] * scalingFactor);
                        glyphOffsets[i].du = (int)(dwriteGlyphOffsets[i].advanceOffset * scalingFactor);
                        glyphOffsets[i].dv = (int)(dwriteGlyphOffsets[i].ascenderOffset * scalingFactor);
                    }
                }                

                ConvertHresultToException(hr, "void TextAnalyzer::GetGlyphs");
            }
            finally
            {
                fontFace->Release();

                if (dwriteGlyphAdvances != NULL)
                {
                    delete[] dwriteGlyphAdvances;
                }

                if (dwriteGlyphOffsets != NULL)
                {
                    delete[] dwriteGlyphOffsets;
                }

                if (dwriteTypographicFeatures != NULL)
                {
                    delete[] dwriteTypographicFeatures;
                }
            }
        }
    }


    /// <SecurityNote>
    /// Critical - Asserts unmanaged code permission 
    ///            To allocate and delete temporary native buffers
    ///            To perform unsafe reinterpret_casts
    ///            To call Marshal.Copy
    /// </SecurityNote>
    [SecurityCritical]
    [SecurityPermission(SecurityAction::Assert, UnmanagedCode=true)]
    void TextAnalyzer::GetGlyphsAndTheirPlacements(
        __in_ecount(textLength) const WCHAR* textString,
        UINT32 textLength,
        Font^ font,
        UINT16 blankGlyphIndex,
        bool isSideways,
        bool isRightToLeft,
        CultureInfo^ cultureInfo,
        array<array<DWriteFontFeature>^>^ features,
        array<UINT32>^ featureRangeLengths,
        double fontEmSize,
        double scalingFactor,
        float pixelsPerDip,
        TextFormattingMode textFormattingMode,
        ItemProps^     itemProps,
        [System::Runtime::InteropServices::Out] array<unsigned short>^% clusterMap,
        [System::Runtime::InteropServices::Out] array<unsigned short>^% glyphIndices,
        [System::Runtime::InteropServices::Out] array<int>           ^% glyphAdvances,
        [System::Runtime::InteropServices::Out] array<GlyphOffset>   ^% glyphOffsets
        )
    {
        UINT32 maxGlyphCount = 3 * textLength;
        clusterMap = gcnew array<unsigned short>(textLength);
        pin_ptr<unsigned short> pclusterMapPinned = &clusterMap[0];

        DWRITE_SHAPING_TEXT_PROPERTIES*  textProps          = new DWRITE_SHAPING_TEXT_PROPERTIES[textLength];
        DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps         = NULL;
        unsigned short*                  glyphIndicesNative = NULL;

        try
        {
            UINT32 actualGlyphCount = maxGlyphCount + 1;

            // Loop and everytime increase the size of the GlyphIndices buffer.
            while(actualGlyphCount > maxGlyphCount)
            {
                maxGlyphCount = actualGlyphCount;
                if (glyphProps != NULL)
                {
                    delete[] glyphProps;
                    glyphProps = NULL;
                }
                glyphProps   = new DWRITE_SHAPING_GLYPH_PROPERTIES[maxGlyphCount];

                if (glyphIndicesNative != NULL)
                {
                    delete[] glyphIndicesNative;
                    glyphIndicesNative = NULL;
                }
                glyphIndicesNative = new unsigned short[maxGlyphCount];

                GetGlyphs(
                    textString,
                    textLength,
                    font,
                    blankGlyphIndex,
                    isSideways,
                    isRightToLeft,
                    cultureInfo,
                    features,
                    featureRangeLengths,
                    maxGlyphCount,
                    textFormattingMode,
                    itemProps,
                    reinterpret_cast<UINT16*> (pclusterMapPinned),
                    (UINT16*) textProps,
                    reinterpret_cast<UINT16*> (glyphIndicesNative),
                    reinterpret_cast<UINT32*> (glyphProps),
                    NULL,
                    actualGlyphCount
                    );
            }

            glyphIndices = gcnew array<unsigned short>(actualGlyphCount);
            Marshal::Copy(System::IntPtr((void*)glyphIndicesNative), (array<Int16>^)glyphIndices, 0, actualGlyphCount);

            glyphAdvances = gcnew array<int>(actualGlyphCount);
            pin_ptr<int> glyphAdvancesPinned = &glyphAdvances[0]; 
            glyphOffsets = gcnew array<GlyphOffset>(actualGlyphCount);

            GetGlyphPlacements(
                textString,
                reinterpret_cast<UINT16*> (pclusterMapPinned),
                (UINT16*) textProps,
                textLength,
                reinterpret_cast<UINT16*> (glyphIndicesNative),
                reinterpret_cast<UINT32*> (glyphProps),
                actualGlyphCount,
                font,
                fontEmSize,
                scalingFactor,
                isSideways,
                isRightToLeft,
                cultureInfo,
                features,
                featureRangeLengths,
                textFormattingMode,
                itemProps,
                pixelsPerDip,
                reinterpret_cast<int*>(glyphAdvancesPinned),
                glyphOffsets
                );
        }
        finally
        {
            delete[] textProps;
            if (glyphProps != NULL)
            {
                delete[] glyphProps;
            }
            if (glyphIndicesNative != NULL)
            {
                delete[] glyphIndicesNative;
            }
        }
    }

    /// <SecurityNote>
    /// Critical - Calls security critical itemProps->ScriptAnalysis.
    /// Safe     - Does not expose the pointer returned from itemProps->ScriptAnalysis.
    /// </SecurityNote>
    [SecuritySafeCritical]
    __declspec(noinline) DWRITE_SCRIPT_SHAPES TextAnalyzer::GetScriptShapes(ItemProps^ itemProps)
    {
        return ((DWRITE_SCRIPT_ANALYSIS*)(itemProps->ScriptAnalysis))->shapes;
    }

}}}}//MS::Internal::Text::TextInterface
