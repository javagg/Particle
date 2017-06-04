using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Windows.Media;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface
{
	internal sealed class TextAnalyzer
	{
		[SecurityCritical]
		internal unsafe TextAnalyzer(IDWriteTextAnalyzer* textAnalyzer)
        {
        }

        [SecurityCritical]
		internal unsafe static IList<Span> Itemize(ushort* text, uint length, CultureInfo culture, Factory factory, [MarshalAs(UnmanagedType.U1)] bool isRightToLeftParagraph, CultureInfo numberCulture, [MarshalAs(UnmanagedType.U1)] bool ignoreUserOverride, uint numberSubstitutionMethod, IClassification classificationUtility, CreateTextAnalysisSink pfnCreateTextAnalysisSink, GetScriptAnalysisList pfnGetScriptAnalysisList, GetNumberSubstitutionList pfnGetNumberSubstitutionList, CreateTextAnalysisSource pfnCreateTextAnalysisSource)
		{
		    throw new NotImplementedException();

        }

        [SecurityCritical]
		internal unsafe static void AnalyzeExtendedCharactersAndDigits(ushort* text, uint length, TextItemizer textItemizer, byte* pCharAttribute, CultureInfo numberCulture, IClassification classificationUtility)
		{
		}

		[SecurityCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		internal unsafe void GetGlyphsAndTheirPlacements(ushort* textString, uint textLength, Font font, ushort blankGlyphIndex, [MarshalAs(UnmanagedType.U1)] bool isSideways, [MarshalAs(UnmanagedType.U1)] bool isRightToLeft, CultureInfo cultureInfo, DWriteFontFeature[][] features, uint[] featureRangeLengths, double fontEmSize, double scalingFactor, float pixelsPerDip, TextFormattingMode textFormattingMode, ItemProps itemProps, out ushort[] clusterMap, out ushort[] glyphIndices, out int[] glyphAdvances, out GlyphOffset[] glyphOffsets)
		{
		    throw new NotImplementedException();

        }

        [SecurityCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		internal unsafe void GetGlyphs(ushort* textString, uint textLength, Font font, ushort blankGlyphIndex, [MarshalAs(UnmanagedType.U1)] bool isSideways, [MarshalAs(UnmanagedType.U1)] bool isRightToLeft, CultureInfo cultureInfo, DWriteFontFeature[][] features, uint[] featureRangeLengths, uint maxGlyphCount, TextFormattingMode textFormattingMode, ItemProps itemProps, ushort* clusterMap, ushort* textProps, ushort* glyphIndices, uint* glyphProps, int* pfCanGlyphAlone, out uint actualGlyphCount)
		{
		    throw new NotImplementedException();

        }

        [SecurityCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		internal unsafe void GetGlyphPlacements(ushort* textString, ushort* clusterMap, ushort* textProps, uint textLength, ushort* glyphIndices, uint* glyphProps, uint glyphCount, Font font, double fontEmSize, double scalingFactor, [MarshalAs(UnmanagedType.U1)] bool isSideways, [MarshalAs(UnmanagedType.U1)] bool isRightToLeft, CultureInfo cultureInfo, DWriteFontFeature[][] features, uint[] featureRangeLengths, TextFormattingMode textFormattingMode, ItemProps itemProps, float pixelsPerDip, int* glyphAdvances, out GlyphOffset[] glyphOffsets)
		{
		    throw new NotImplementedException();
		}

		internal static char CharHyphen = '-';
	}
}
