using System.Resources;
using System.Runtime.InteropServices;

namespace System.Windows
{
    internal static class SR
    {
        internal static string Get(string id) => "";

        internal static string Get(string id, params object[] args) => "";

        internal static ResourceManager ResourceManager => null;
    }
}

namespace System.Windows
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	internal struct SRID
	{
		public const string Default = "Default";

		public const string UnexpectedParameterType = "UnexpectedParameterType";

		public const string CannotConvertStringToType = "CannotConvertStringToType";

		public const string CannotConvertType = "CannotConvertType";

		public const string StringEmpty = "StringEmpty";

		public const string ParameterCannotBeNegative = "ParameterCannotBeNegative";

		public const string Enum_Invalid = "Enum_Invalid";

		public const string Collection_BadType = "Collection_BadType";

		public const string Collection_CopyTo_IndexGreaterThanOrEqualToArrayLength = "Collection_CopyTo_IndexGreaterThanOrEqualToArrayLength";

		public const string Collection_CopyTo_NumberOfElementsExceedsArrayLength = "Collection_CopyTo_NumberOfElementsExceedsArrayLength";

		public const string Collection_CopyTo_ArrayCannotBeMultidimensional = "Collection_CopyTo_ArrayCannotBeMultidimensional";

		public const string CollectionNumberOfElementsMustBeLessOrEqualTo = "CollectionNumberOfElementsMustBeLessOrEqualTo";

		public const string Enumerator_VerifyContext = "Enumerator_VerifyContext";

		public const string Animation_ChildMustBeKeyFrame = "Animation_ChildMustBeKeyFrame";

		public const string Animation_NoTextChildren = "Animation_NoTextChildren";

		public const string Animation_InvalidBaseValue = "Animation_InvalidBaseValue";

		public const string Animation_InvalidTimeKeyTime = "Animation_InvalidTimeKeyTime";

		public const string Animation_InvalidResolvedKeyTimes = "Animation_InvalidResolvedKeyTimes";

		public const string Animation_InvalidAnimationUsingKeyFramesDuration = "Animation_InvalidAnimationUsingKeyFramesDuration";

		public const string Animation_Invalid_DefaultValue = "Animation_Invalid_DefaultValue";

		public const string Freezable_CantBeFrozen = "Freezable_CantBeFrozen";

		public const string CannotModifyReadOnlyContainer = "CannotModifyReadOnlyContainer";

		public const string CannotRetrievePartsOfWriteOnlyContainer = "CannotRetrievePartsOfWriteOnlyContainer";

		public const string TokenizerHelperPrematureStringTermination = "TokenizerHelperPrematureStringTermination";

		public const string TokenizerHelperMissingEndQuote = "TokenizerHelperMissingEndQuote";

		public const string TokenizerHelperExtraDataEncountered = "TokenizerHelperExtraDataEncountered";

		public const string TokenizerHelperEmptyToken = "TokenizerHelperEmptyToken";

		public const string InvalidPermissionType = "InvalidPermissionType";

		public const string InvalidPermissionStateValue = "InvalidPermissionStateValue";

		public const string SecurityExceptionForSettingSandboxExternalToTrue = "SecurityExceptionForSettingSandboxExternalToTrue";

		public const string FileFormatException = "FileFormatException";

		public const string FileFormatExceptionWithFileName = "FileFormatExceptionWithFileName";

		public const string TypeMetadataCannotChangeAfterUse = "TypeMetadataCannotChangeAfterUse";

		public const string Visual_ArgumentOutOfRange = "Visual_ArgumentOutOfRange";

		public const string Argument_InvalidOffLen = "Argument_InvalidOffLen";

		public const string InvalidOperation_IComparerFailed = "InvalidOperation_IComparerFailed";

		public const string Rect_WidthAndHeightCannotBeNegative = "Rect_WidthAndHeightCannotBeNegative";

		public const string UnexpectedCollectionChangeAction = "UnexpectedCollectionChangeAction";

		public const string Collection_NoNull = "Collection_NoNull";

		public const string PropertyIsImmutable = "PropertyIsImmutable";

		public const string PropertyIsInitializeOnly = "PropertyIsInitializeOnly";

		public const string PropertyMustHaveValue = "PropertyMustHaveValue";

		public const string CompatibilityPreferencesSealed = "CompatibilityPreferencesSealed";

		public const string AudioVideo_InvalidDependencyObject = "AudioVideo_InvalidDependencyObject";

		public const string AudioVideo_InvalidMediaState = "AudioVideo_InvalidMediaState";

		public const string AudioVideo_CannotControlMedia = "AudioVideo_CannotControlMedia";

		public const string ChangingTypeNotAllowed = "ChangingTypeNotAllowed";

		public const string ChangingIdNotAllowed = "ChangingIdNotAllowed";

		public const string CanOnlyHaveOneChild = "CanOnlyHaveOneChild";

		public const string DocumentApplicationCannotInitializeUI = "DocumentApplicationCannotInitializeUI";

		public const string DocumentApplicationNotInFullTrust = "DocumentApplicationNotInFullTrust";

		public const string DocumentApplicationRegistryKeyNotFound = "DocumentApplicationRegistryKeyNotFound";

		public const string DocumentApplicationStatusLoaded = "DocumentApplicationStatusLoaded";

		public const string DocumentApplicationUnableToOpenDocument = "DocumentApplicationUnableToOpenDocument";

		public const string DocumentApplicationUnknownFileFormat = "DocumentApplicationUnknownFileFormat";

		public const string DocumentApplicationContextMenuPreviousPageHeader = "DocumentApplicationContextMenuPreviousPageHeader";

		public const string DocumentApplicationContextMenuPreviousPageInputGesture = "DocumentApplicationContextMenuPreviousPageInputGesture";

		public const string DocumentApplicationContextMenuNextPageHeader = "DocumentApplicationContextMenuNextPageHeader";

		public const string DocumentApplicationContextMenuNextPageInputGesture = "DocumentApplicationContextMenuNextPageInputGesture";

		public const string DocumentApplicationContextMenuFirstPageInputGesture = "DocumentApplicationContextMenuFirstPageInputGesture";

		public const string DocumentApplicationContextMenuLastPageInputGesture = "DocumentApplicationContextMenuLastPageInputGesture";

		public const string DocumentPageView_ParentNotDocumentPageHost = "DocumentPageView_ParentNotDocumentPageHost";

		public const string DocumentViewerPageViewsCollectionEmpty = "DocumentViewerPageViewsCollectionEmpty";

		public const string DocumentViewerOneMasterPage = "DocumentViewerOneMasterPage";

		public const string DocumentViewerArgumentMustBeInteger = "DocumentViewerArgumentMustBeInteger";

		public const string DocumentViewerArgumentMustBePercentage = "DocumentViewerArgumentMustBePercentage";

		public const string DocumentViewerCanHaveOnlyOneChild = "DocumentViewerCanHaveOnlyOneChild";

		public const string DocumentViewerChildMustImplementIDocumentPaginatorSource = "DocumentViewerChildMustImplementIDocumentPaginatorSource";

		public const string DocumentViewerStyleMustIncludeContentHost = "DocumentViewerStyleMustIncludeContentHost";

		public const string DocumentViewerOnlySupportsFixedDocumentSequence = "DocumentViewerOnlySupportsFixedDocumentSequence";

		public const string FlowDocumentPageViewerOnlySupportsFlowDocument = "FlowDocumentPageViewerOnlySupportsFlowDocument";

		public const string FlowDocumentScrollViewerCanHaveOnlyOneChild = "FlowDocumentScrollViewerCanHaveOnlyOneChild";

		public const string FlowDocumentScrollViewerDocumentBelongsToAnotherFlowDocumentScrollViewerAlready = "FlowDocumentScrollViewerDocumentBelongsToAnotherFlowDocumentScrollViewerAlready";

		public const string FlowDocumentScrollViewerMarkedAsContentHostMustHaveNoContent = "FlowDocumentScrollViewerMarkedAsContentHostMustHaveNoContent";

		public const string SwitchViewingMode = "SwitchViewingMode";

		public const string FlowDocumentReaderCanHaveOnlyOneChild = "FlowDocumentReaderCanHaveOnlyOneChild";

		public const string FlowDocumentReaderDecoratorMarkedAsContentHostMustHaveNoContent = "FlowDocumentReaderDecoratorMarkedAsContentHostMustHaveNoContent";

		public const string FlowDocumentReaderCannotDisableAllViewingModes = "FlowDocumentReaderCannotDisableAllViewingModes";

		public const string FlowDocumentReaderViewingModeEnabledConflict = "FlowDocumentReaderViewingModeEnabledConflict";

		public const string ZoomPercentageConverterStringFormat = "ZoomPercentageConverterStringFormat";

		public const string DocumentGridVisualTreeContainsNonDocumentGridPage = "DocumentGridVisualTreeContainsNonDocumentGridPage";

		public const string DocumentGridVisualTreeContainsNonBorderAsFirstElement = "DocumentGridVisualTreeContainsNonBorderAsFirstElement";

		public const string DocumentGridVisualTreeOutOfSync = "DocumentGridVisualTreeOutOfSync";

		public const string DocumentGridVisualTreeContainsNonUIElement = "DocumentGridVisualTreeContainsNonUIElement";

		public const string DocumentGridInvalidViewMode = "DocumentGridInvalidViewMode";

		public const string RowCacheRecalcWithNoPageCache = "RowCacheRecalcWithNoPageCache";

		public const string RowCacheCannotModifyNonExistentLayout = "RowCacheCannotModifyNonExistentLayout";

		public const string RowCachePageNotFound = "RowCachePageNotFound";

		public const string Panel_BoundPanel_NoChildren = "Panel_BoundPanel_NoChildren";

		public const string Panel_NoNullVisualParent = "Panel_NoNullVisualParent";

		public const string Panel_NoNullChildren = "Panel_NoNullChildren";

		public const string Panel_ItemsControlNotFound = "Panel_ItemsControlNotFound";

		public const string ItemsControl_ParentNotFrameworkElement = "ItemsControl_ParentNotFrameworkElement";

		public const string Stack_VisualInDifferentSubTree = "Stack_VisualInDifferentSubTree";

		public const string Track_SameButtons = "Track_SameButtons";

		public const string ToolBar_InvalidStyle_ToolBarPanel = "ToolBar_InvalidStyle_ToolBarPanel";

		public const string ToolBar_InvalidStyle_ToolBarOverflowPanel = "ToolBar_InvalidStyle_ToolBarOverflowPanel";

		public const string ScrollViewer_OutOfRange = "ScrollViewer_OutOfRange";

		public const string ScrollViewer_CannotBeNaN = "ScrollViewer_CannotBeNaN";

		public const string ScrollBar_ContextMenu_ScrollHere = "ScrollBar_ContextMenu_ScrollHere";

		public const string ScrollBar_ContextMenu_LeftEdge = "ScrollBar_ContextMenu_LeftEdge";

		public const string ScrollBar_ContextMenu_RightEdge = "ScrollBar_ContextMenu_RightEdge";

		public const string ScrollBar_ContextMenu_Top = "ScrollBar_ContextMenu_Top";

		public const string ScrollBar_ContextMenu_Bottom = "ScrollBar_ContextMenu_Bottom";

		public const string ScrollBar_ContextMenu_PageLeft = "ScrollBar_ContextMenu_PageLeft";

		public const string ScrollBar_ContextMenu_PageRight = "ScrollBar_ContextMenu_PageRight";

		public const string ScrollBar_ContextMenu_PageUp = "ScrollBar_ContextMenu_PageUp";

		public const string ScrollBar_ContextMenu_PageDown = "ScrollBar_ContextMenu_PageDown";

		public const string ScrollBar_ContextMenu_ScrollLeft = "ScrollBar_ContextMenu_ScrollLeft";

		public const string ScrollBar_ContextMenu_ScrollRight = "ScrollBar_ContextMenu_ScrollRight";

		public const string ScrollBar_ContextMenu_ScrollUp = "ScrollBar_ContextMenu_ScrollUp";

		public const string ScrollBar_ContextMenu_ScrollDown = "ScrollBar_ContextMenu_ScrollDown";

		public const string XpsValidatingLoaderUnsupportedMimeType = "XpsValidatingLoaderUnsupportedMimeType";

		public const string XpsValidatingLoaderUnlistedResource = "XpsValidatingLoaderUnlistedResource";

		public const string XpsValidatingLoaderUriNotInSamePackage = "XpsValidatingLoaderUriNotInSamePackage";

		public const string XpsValidatingLoaderDuplicateReference = "XpsValidatingLoaderDuplicateReference";

		public const string XpsValidatingLoaderMoreThanOnePrintTicketPart = "XpsValidatingLoaderMoreThanOnePrintTicketPart";

		public const string XpsValidatingLoaderMoreThanOneThumbnailInPackage = "XpsValidatingLoaderMoreThanOneThumbnailInPackage";

		public const string XpsValidatingLoaderMoreThanOneThumbnailPart = "XpsValidatingLoaderMoreThanOneThumbnailPart";

		public const string XpsValidatingLoaderMoreThanOneDiscardControlInPackage = "XpsValidatingLoaderMoreThanOneDiscardControlInPackage";

		public const string XpsValidatingLoaderThumbnailHasIncorrectType = "XpsValidatingLoaderThumbnailHasIncorrectType";

		public const string XpsValidatingLoaderPrintTicketHasIncorrectType = "XpsValidatingLoaderPrintTicketHasIncorrectType";

		public const string XpsValidatingLoaderDiscardControlHasIncorrectType = "XpsValidatingLoaderDiscardControlHasIncorrectType";

		public const string XpsValidatingLoaderRestrictedFontHasIncorrectType = "XpsValidatingLoaderRestrictedFontHasIncorrectType";

		public const string XpsValidatingLoaderUnsupportedEncoding = "XpsValidatingLoaderUnsupportedEncoding";

		public const string XpsValidatingLoaderUnsupportedRootNamespaceUri = "XpsValidatingLoaderUnsupportedRootNamespaceUri";

		public const string SerializerProviderWrongVersion = "SerializerProviderWrongVersion";

		public const string SerializerProviderCannotLoad = "SerializerProviderCannotLoad";

		public const string SerializerProviderUnknownSerializer = "SerializerProviderUnknownSerializer";

		public const string SerializerProviderAlreadyRegistered = "SerializerProviderAlreadyRegistered";

		public const string SerializerProviderNotRegistered = "SerializerProviderNotRegistered";

		public const string SerializerProviderDisplayNameNull = "SerializerProviderDisplayNameNull";

		public const string SerializerProviderManufacturerNameNull = "SerializerProviderManufacturerNameNull";

		public const string SerializerProviderManufacturerWebsiteNull = "SerializerProviderManufacturerWebsiteNull";

		public const string SerializerProviderDefaultFileExtensionNull = "SerializerProviderDefaultFileExtensionNull";

		public const string PageContentUnsupportedMimeType = "PageContentUnsupportedMimeType";

		public const string PageContentNotFound = "PageContentNotFound";

		public const string PageContentUnsupportedPageType = "PageContentUnsupportedPageType";

		public const string ExceptionInGetPage = "ExceptionInGetPage";

		public const string PrevoiusPartialPageContentOutstanding = "PrevoiusPartialPageContentOutstanding";

		public const string BadFixedTextPosition = "BadFixedTextPosition";

		public const string FixedDocumentReadonly = "FixedDocumentReadonly";

		public const string NotInAssociatedContainer = "NotInAssociatedContainer";

		public const string FixedDocumentExpectsDependencyObject = "FixedDocumentExpectsDependencyObject";

		public const string InvalidStoryFragmentsMarkup = "InvalidStoryFragmentsMarkup";

		public const string InvalidSFContentType = "InvalidSFContentType";

		public const string InvalidDSContentType = "InvalidDSContentType";

		public const string DocumentReferenceUnsupportedMimeType = "DocumentReferenceUnsupportedMimeType";

		public const string DocumentReferenceNotFound = "DocumentReferenceNotFound";

		public const string DocumentReferenceHasInvalidDocument = "DocumentReferenceHasInvalidDocument";

		public const string PrevoiusUninitializedDocumentReferenceOutstanding = "PrevoiusUninitializedDocumentReferenceOutstanding";

		public const string DocumentReadOnly = "DocumentReadOnly";

		public const string DocumentStructureUnexpectedParameterType1 = "DocumentStructureUnexpectedParameterType1";

		public const string DocumentStructureUnexpectedParameterType2 = "DocumentStructureUnexpectedParameterType2";

		public const string DocumentStructureUnexpectedParameterType4 = "DocumentStructureUnexpectedParameterType4";

		public const string DocumentStructureUnexpectedParameterType6 = "DocumentStructureUnexpectedParameterType6";

		public const string FrameNoAddChild = "FrameNoAddChild";

		public const string GlyphsClusterNoNestedClusters = "GlyphsClusterNoNestedClusters";

		public const string GlyphsClusterNoMatchingBracket = "GlyphsClusterNoMatchingBracket";

		public const string GlyphsClusterMisplacedSeparator = "GlyphsClusterMisplacedSeparator";

		public const string GlyphsClusterBadCharactersBeforeBracket = "GlyphsClusterBadCharactersBeforeBracket";

		public const string GlyphsIndexRequiredIfNoUnicode = "GlyphsIndexRequiredIfNoUnicode";

		public const string GlyphsAdvanceWidthCannotBeNegative = "GlyphsAdvanceWidthCannotBeNegative";

		public const string GlyphsTooManyCommas = "GlyphsTooManyCommas";

		public const string GlyphsIndexRequiredWithinCluster = "GlyphsIndexRequiredWithinCluster";

		public const string GlyphsUnicodeStringAndIndicesCannotBothBeEmpty = "GlyphsUnicodeStringAndIndicesCannotBothBeEmpty";

		public const string GlyphsUnicodeStringIsTooShort = "GlyphsUnicodeStringIsTooShort";

		public const string GlyphsCaretStopsContainsHexDigits = "GlyphsCaretStopsContainsHexDigits";

		public const string GlyphsCaretStopsLengthCorrespondsToUnicodeString = "GlyphsCaretStopsLengthCorrespondsToUnicodeString";

		public const string AlreadyHasLogicalChildren = "AlreadyHasLogicalChildren";

		public const string CannotHookupFCERoot = "CannotHookupFCERoot";

		public const string ChildNameMustBeNonEmpty = "ChildNameMustBeNonEmpty";

		public const string ChildNameNamePatternReserved = "ChildNameNamePatternReserved";

		public const string ChildTemplateInstanceDoesNotExist = "ChildTemplateInstanceDoesNotExist";

		public const string EventTriggerDoNotSetProperties = "EventTriggerDoNotSetProperties";

		public const string EventTriggerDoesNotEnterExit = "EventTriggerDoesNotEnterExit";

		public const string EventTriggerEventUnresolvable = "EventTriggerEventUnresolvable";

		public const string EventTriggerNeedEvent = "EventTriggerNeedEvent";

		public const string EventTriggerTargetNameUnresolvable = "EventTriggerTargetNameUnresolvable";

		public const string EventTriggerOnStyleNotAllowedToHaveTarget = "EventTriggerOnStyleNotAllowedToHaveTarget";

		public const string NamesNotSupportedInsideResourceDictionary = "NamesNotSupportedInsideResourceDictionary";

		public const string FrameworkElementFactoryAlreadyParented = "FrameworkElementFactoryAlreadyParented";

		public const string FrameworkElementFactoryCannotAddText = "FrameworkElementFactoryCannotAddText";

		public const string FrameworkElementFactoryMustBeSealed = "FrameworkElementFactoryMustBeSealed";

		public const string InputStreamMustBeReadable = "InputStreamMustBeReadable";

		public const string InvalidPropertyValue = "InvalidPropertyValue";

		public const string KeyCollectionHasInvalidKey = "KeyCollectionHasInvalidKey";

		public const string MustBaseOnStyleOfABaseType = "MustBaseOnStyleOfABaseType";

		public const string MustBeFrameworkDerived = "MustBeFrameworkDerived";

		public const string MustBeFrameworkOr3DDerived = "MustBeFrameworkOr3DDerived";

		public const string MustBeTriggerAction = "MustBeTriggerAction";

		public const string MustBeCondition = "MustBeCondition";

		public const string InvalidControlTemplateTargetType = "InvalidControlTemplateTargetType";

		public const string Illegal_InheritanceBehaviorSettor = "Illegal_InheritanceBehaviorSettor";

		public const string NullPropertyIllegal = "NullPropertyIllegal";

		public const string NullTypeIllegal = "NullTypeIllegal";

		public const string NameScopeNameNotEmptyString = "NameScopeNameNotEmptyString";

		public const string NameScopeNameNotFound = "NameScopeNameNotFound";

		public const string NameScopeDuplicateNamesNotAllowed = "NameScopeDuplicateNamesNotAllowed";

		public const string NameScopeNotFound = "NameScopeNotFound";

		public const string NameScopeInvalidIdentifierName = "NameScopeInvalidIdentifierName";

		public const string CrossThreadAccessOfUnshareableFreezable = "CrossThreadAccessOfUnshareableFreezable";

		public const string CyclicStyleReferenceDetected = "CyclicStyleReferenceDetected";

		public const string CyclicThemeStyleReferenceDetected = "CyclicThemeStyleReferenceDetected";

		public const string PropertyTriggerCycleDetected = "PropertyTriggerCycleDetected";

		public const string PropertyTriggerLayerLimitExceeded = "PropertyTriggerLayerLimitExceeded";

		public const string ReadOnlyPropertyNotAllowed = "ReadOnlyPropertyNotAllowed";

		public const string SetterOnStyleNotAllowedToHaveTarget = "SetterOnStyleNotAllowedToHaveTarget";

		public const string SetterValueCannotBeUnset = "SetterValueCannotBeUnset";

		public const string StyleBasedOnHasLoop = "StyleBasedOnHasLoop";

		public const string StyleCannotBeBasedOnSelf = "StyleCannotBeBasedOnSelf";

		public const string CannotChangeAfterSealed = "CannotChangeAfterSealed";

		public const string TemplateCircularReferenceFound = "TemplateCircularReferenceFound";

		public const string TemplateCannotHaveNestedContentPresenterAndGridViewRowPresenter = "TemplateCannotHaveNestedContentPresenterAndGridViewRowPresenter";

		public const string Template3DValueOnly = "Template3DValueOnly";

		public const string StyleForWrongType = "StyleForWrongType";

		public const string NameNotEmptyString = "NameNotEmptyString";

		public const string NameNotFound = "NameNotFound";

		public const string StylePropertyInStyleNotAllowed = "StylePropertyInStyleNotAllowed";

		public const string SystemResourceForTypeIsNotStyle = "SystemResourceForTypeIsNotStyle";

		public const string TargetNameNotFound = "TargetNameNotFound";

		public const string TypeMustImplementIAddChild = "TypeMustImplementIAddChild";

		public const string NestedBeginInitNotSupported = "NestedBeginInitNotSupported";

		public const string EndInitWithoutBeginInitNotSupported = "EndInitWithoutBeginInitNotSupported";

		public const string VisualTreeRootIsFrameworkElement = "VisualTreeRootIsFrameworkElement";

		public const string VisualTriggerSettersIncludeUnsupportedSetterType = "VisualTriggerSettersIncludeUnsupportedSetterType";

		public const string ModifyingLogicalTreeViaStylesNotImplemented = "ModifyingLogicalTreeViaStylesNotImplemented";

		public const string InvalidSetterValue = "InvalidSetterValue";

		public const string TemplateChildIndexOutOfRange = "TemplateChildIndexOutOfRange";

		public const string NamedObjectMustBeFrameworkElement = "NamedObjectMustBeFrameworkElement";

		public const string StyleHasTooManyElements = "StyleHasTooManyElements";

		public const string TemplateHasNestedNameScope = "TemplateHasNestedNameScope";

		public const string TriggerActionMustBelongToASingleTrigger = "TriggerActionMustBelongToASingleTrigger";

		public const string TriggerActionAlreadySealed = "TriggerActionAlreadySealed";

		public const string TriggersSupportsEventTriggersOnly = "TriggersSupportsEventTriggersOnly";

		public const string HandlerTypeIllegal = "HandlerTypeIllegal";

		public const string UnexpectedValueTypeForDataTrigger = "UnexpectedValueTypeForDataTrigger";

		public const string UnexpectedValueTypeForCondition = "UnexpectedValueTypeForCondition";

		public const string ConditionCannotUseBothPropertyAndBinding = "ConditionCannotUseBothPropertyAndBinding";

		public const string CannotHaveOverridesDefaultStyleInThemeStyle = "CannotHaveOverridesDefaultStyleInThemeStyle";

		public const string CannotHavePropertyInStyle = "CannotHavePropertyInStyle";

		public const string CannotHavePropertyInTemplate = "CannotHavePropertyInTemplate";

		public const string CannotHaveEventHandlersInThemeStyle = "CannotHaveEventHandlersInThemeStyle";

		public const string StyleTargetTypeMismatchWithElement = "StyleTargetTypeMismatchWithElement";

		public const string StyleTriggersCannotTargetTheTemplate = "StyleTriggersCannotTargetTheTemplate";

		public const string CannotModifyLogicalChildrenDuringTreeWalk = "CannotModifyLogicalChildrenDuringTreeWalk";

		public const string EventTriggerBadAction = "EventTriggerBadAction";

		public const string SourceNameNotSupportedForDataTriggers = "SourceNameNotSupportedForDataTriggers";

		public const string TriggerOnStyleNotAllowedToHaveSource = "TriggerOnStyleNotAllowedToHaveSource";

		public const string ResourceDictionaryLoadFromFailure = "ResourceDictionaryLoadFromFailure";

		public const string ResourceDictionaryDeferredContentFailure = "ResourceDictionaryDeferredContentFailure";

		public const string ResourceDictionaryDuplicateDeferredContent = "ResourceDictionaryDuplicateDeferredContent";

		public const string NoDefaultUpdateSourceTrigger = "NoDefaultUpdateSourceTrigger";

		public const string UnsupportedTriggerInStyle = "UnsupportedTriggerInStyle";

		public const string Storyboard_AnimationMismatch = "Storyboard_AnimationMismatch";

		public const string Storyboard_BeginStoryboardNameNotFound = "Storyboard_BeginStoryboardNameNotFound";

		public const string Storyboard_BeginStoryboardNameRequired = "Storyboard_BeginStoryboardNameRequired";

		public const string Storyboard_BeginStoryboardNoStoryboard = "Storyboard_BeginStoryboardNoStoryboard";

		public const string Storyboard_ComplexPathNotSupported = "Storyboard_ComplexPathNotSupported";

		public const string Storyboard_ImmutableTargetNotSupported = "Storyboard_ImmutableTargetNotSupported";

		public const string Storyboard_MediaElementNotFound = "Storyboard_MediaElementNotFound";

		public const string Storyboard_MediaElementRequired = "Storyboard_MediaElementRequired";

		public const string Storyboard_NameNotFound = "Storyboard_NameNotFound";

		public const string Storyboard_NoNameScope = "Storyboard_NoNameScope";

		public const string Storyboard_NeverApplied = "Storyboard_NeverApplied";

		public const string Storyboard_PropertyPathEmpty = "Storyboard_PropertyPathEmpty";

		public const string Storyboard_PropertyPathFrozenCheckFailed = "Storyboard_PropertyPathFrozenCheckFailed";

		public const string Storyboard_PropertyPathSealedCheckFailed = "Storyboard_PropertyPathSealedCheckFailed";

		public const string Storyboard_PropertyPathIncludesNonAnimatableProperty = "Storyboard_PropertyPathIncludesNonAnimatableProperty";

		public const string Storyboard_PropertyPathMustPointToDependencyObject = "Storyboard_PropertyPathMustPointToDependencyObject";

		public const string Storyboard_PropertyPathMustPointToDependencyProperty = "Storyboard_PropertyPathMustPointToDependencyProperty";

		public const string Storyboard_PropertyPathObjectNotFound = "Storyboard_PropertyPathObjectNotFound";

		public const string Storyboard_PropertyPathPropertyNotFound = "Storyboard_PropertyPathPropertyNotFound";

		public const string Storyboard_PropertyPathUnresolved = "Storyboard_PropertyPathUnresolved";

		public const string Storyboard_StoryboardReferenceRequired = "Storyboard_StoryboardReferenceRequired";

		public const string Storyboard_TargetNameNotDependencyObject = "Storyboard_TargetNameNotDependencyObject";

		public const string Storyboard_TargetNameNotAllowedInStyle = "Storyboard_TargetNameNotAllowedInStyle";

		public const string Storyboard_TargetPropertyRequired = "Storyboard_TargetPropertyRequired";

		public const string Storyboard_UnableToFreeze = "Storyboard_UnableToFreeze";

		public const string Storyboard_UnrecognizedHandoffBehavior = "Storyboard_UnrecognizedHandoffBehavior";

		public const string Storyboard_UnrecognizedTimeSeekOrigin = "Storyboard_UnrecognizedTimeSeekOrigin";

		public const string Storyboard_NoTarget = "Storyboard_NoTarget";

		public const string TemplateInvalidBamlRecord = "TemplateInvalidBamlRecord";

		public const string TemplateTargetTypeMismatch = "TemplateTargetTypeMismatch";

		public const string TemplateNotTargetType = "TemplateNotTargetType";

		public const string MustNotTemplateUnassociatedControl = "MustNotTemplateUnassociatedControl";

		public const string UnsupportedTriggerInTemplate = "UnsupportedTriggerInTemplate";

		public const string TemplateFindNameInInvalidElement = "TemplateFindNameInInvalidElement";

		public const string TemplateContentSetTwice = "TemplateContentSetTwice";

		public const string ConditionValueOfMarkupExtensionNotSupported = "ConditionValueOfMarkupExtensionNotSupported";

		public const string ConditionValueOfExpressionNotSupported = "ConditionValueOfExpressionNotSupported";

		public const string SetterValueOfMarkupExtensionNotSupported = "SetterValueOfMarkupExtensionNotSupported";

		public const string StyleValueOfExpressionNotSupported = "StyleValueOfExpressionNotSupported";

		public const string ReparentModelChildIllegal = "ReparentModelChildIllegal";

		public const string CannotBeSelfParent = "CannotBeSelfParent";

		public const string LogicalTreeLoop = "LogicalTreeLoop";

		public const string HasLogicalParent = "HasLogicalParent";

		public const string InvalidStringThickness = "InvalidStringThickness";

		public const string InvalidStringVirtualizationCacheLength = "InvalidStringVirtualizationCacheLength";

		public const string InvalidStringCornerRadius = "InvalidStringCornerRadius";

		public const string InvalidCtorParameterNoNaN = "InvalidCtorParameterNoNaN";

		public const string InvalidCtorParameterNoInfinity = "InvalidCtorParameterNoInfinity";

		public const string InvalidCtorParameterNoNegative = "InvalidCtorParameterNoNegative";

		public const string InvalidCtorParameterUnknownGridUnitType = "InvalidCtorParameterUnknownGridUnitType";

		public const string InvalidCtorParameterUnknownFigureUnitType = "InvalidCtorParameterUnknownFigureUnitType";

		public const string InvalidCtorParameterUnknownVirtualizationCacheLengthUnitType = "InvalidCtorParameterUnknownVirtualizationCacheLengthUnitType";

		public const string InvalidItemContainer = "InvalidItemContainer";

		public const string MeasureReentrancyInvalid = "MeasureReentrancyInvalid";

		public const string ArrangeReentrancyInvalid = "ArrangeReentrancyInvalid";

		public const string TextContainerChangingReentrancyInvalid = "TextContainerChangingReentrancyInvalid";

		public const string IDPNegativePageNumber = "IDPNegativePageNumber";

		public const string IDPInvalidContentPosition = "IDPInvalidContentPosition";

		public const string FlowDocumentFormattingReentrancy = "FlowDocumentFormattingReentrancy";

		public const string FlowDocumentInvalidContnetChange = "FlowDocumentInvalidContnetChange";

		public const string PTSError = "PTSError";

		public const string PTSInvalidHandle = "PTSInvalidHandle";

		public const string IllegalTreeChangeDetected = "IllegalTreeChangeDetected";

		public const string IllegalTreeChangeDetectedPostAction = "IllegalTreeChangeDetectedPostAction";

		public const string FormatRestrictionsExceeded = "FormatRestrictionsExceeded";

		public const string TextPanelIllegalParaTypeForIAddChild = "TextPanelIllegalParaTypeForIAddChild";

		public const string TextContainerDoesNotContainElement = "TextContainerDoesNotContainElement";

		public const string HyphenatorDisposed = "HyphenatorDisposed";

		public const string Grid_UnexpectedParameterType = "Grid_UnexpectedParameterType";

		public const string GridCollection_CannotModifyReadOnly = "GridCollection_CannotModifyReadOnly";

		public const string GridCollection_MustBeCertainType = "GridCollection_MustBeCertainType";

		public const string GridCollection_InOtherCollection = "GridCollection_InOtherCollection";

		public const string GridCollection_DestArrayInvalidLowerBound = "GridCollection_DestArrayInvalidLowerBound";

		public const string GridCollection_DestArrayInvalidRank = "GridCollection_DestArrayInvalidRank";

		public const string GridCollection_DestArrayInvalidLength = "GridCollection_DestArrayInvalidLength";

		public const string TableCollectionElementTypeExpected = "TableCollectionElementTypeExpected";

		public const string TableCollectionRankMultiDimNotSupported = "TableCollectionRankMultiDimNotSupported";

		public const string TableCollectionOutOfRange = "TableCollectionOutOfRange";

		public const string TableCollectionRangeOutOfRange = "TableCollectionRangeOutOfRange";

		public const string TableCollectionOutOfRangeNeedNonNegNum = "TableCollectionOutOfRangeNeedNonNegNum";

		public const string TableCollectionCountNeedNonNegNum = "TableCollectionCountNeedNonNegNum";

		public const string TableCollectionInvalidOffLen = "TableCollectionInvalidOffLen";

		public const string TableCollectionNotEnoughCapacity = "TableCollectionNotEnoughCapacity";

		public const string TableCollectionInOtherCollection = "TableCollectionInOtherCollection";

		public const string TableCollectionWrongProxyParent = "TableCollectionWrongProxyParent";

		public const string TableInvalidParentNodeType = "TableInvalidParentNodeType";

		public const string EnumeratorNotStarted = "EnumeratorNotStarted";

		public const string EnumeratorReachedEnd = "EnumeratorReachedEnd";

		public const string EnumeratorVersionChanged = "EnumeratorVersionChanged";

		public const string EnumeratorInvalidOperation = "EnumeratorInvalidOperation";

		public const string EnumeratorCollectionDisposed = "EnumeratorCollectionDisposed";

		public const string ListElementItemNotAChildOfList = "ListElementItemNotAChildOfList";

		public const string TextPositionIsFrozen = "TextPositionIsFrozen";

		public const string NotInThisTree = "NotInThisTree";

		public const string NotInAssociatedTree = "NotInAssociatedTree";

		public const string BadDistance = "BadDistance";

		public const string NegativeValue = "NegativeValue";

		public const string InDifferentTextContainers = "InDifferentTextContainers";

		public const string InDifferentParagraphs = "InDifferentParagraphs";

		public const string InDifferentScope = "InDifferentScope";

		public const string BadTextPositionOrder = "BadTextPositionOrder";

		public const string NoElement = "NoElement";

		public const string NoElementObject = "NoElementObject";

		public const string NoScopingElement = "NoScopingElement";

		public const string TextContainer_UndoManagerCreatedMoreThanOnce = "TextContainer_UndoManagerCreatedMoreThanOnce";

		public const string StartIndexExceedsBufferSize = "StartIndexExceedsBufferSize";

		public const string MaxLengthExceedsBufferSize = "MaxLengthExceedsBufferSize";

		public const string TextElementCollection_TextElementTypeExpected = "TextElementCollection_TextElementTypeExpected";

		public const string TextElementCollection_IndexOutOfRange = "TextElementCollection_IndexOutOfRange";

		public const string TextElementCollection_PreviousSiblingDoesNotBelongToThisCollection = "TextElementCollection_PreviousSiblingDoesNotBelongToThisCollection";

		public const string TextElementCollection_NextSiblingDoesNotBelongToThisCollection = "TextElementCollection_NextSiblingDoesNotBelongToThisCollection";

		public const string TextElementCollection_CannotCopyToArrayNotSufficientMemory = "TextElementCollection_CannotCopyToArrayNotSufficientMemory";

		public const string TextElementCollection_ItemHasUnexpectedType = "TextElementCollection_ItemHasUnexpectedType";

		public const string TextElementCollection_NoEnumerator = "TextElementCollection_NoEnumerator";

		public const string TextSchema_TextIsNotAllowedInThisContext = "TextSchema_TextIsNotAllowedInThisContext";

		public const string TextSchema_ChildTypeIsInvalid = "TextSchema_ChildTypeIsInvalid";

		public const string TextSchema_TheChildElementBelongsToAnotherTreeAlready = "TextSchema_TheChildElementBelongsToAnotherTreeAlready";

		public const string TextSchema_TextIsNotAllowed = "TextSchema_TextIsNotAllowed";

		public const string TextSchema_UIElementNotAllowedInThisPosition = "TextSchema_UIElementNotAllowedInThisPosition";

		public const string TextSchema_CannotInsertContentInThisPosition = "TextSchema_CannotInsertContentInThisPosition";

		public const string TextSchema_ThisInlineUIContainerHasAChildUIElementAlready = "TextSchema_ThisInlineUIContainerHasAChildUIElementAlready";

		public const string TextSchema_ThisBlockUIContainerHasAChildUIElementAlready = "TextSchema_ThisBlockUIContainerHasAChildUIElementAlready";

		public const string TextSchema_CannotSplitElement = "TextSchema_CannotSplitElement";

		public const string TextSchema_IllegalHyperlinkChild = "TextSchema_IllegalHyperlinkChild";

		public const string TextSchema_IllegalElement = "TextSchema_IllegalElement";

		public const string TextElement_UnmatchedEndPointer = "TextElement_UnmatchedEndPointer";

		public const string TextPointer_CannotInsertTextElementBecauseItBelongsToAnotherTree = "TextPointer_CannotInsertTextElementBecauseItBelongsToAnotherTree";

		public const string TextRange_InvalidParameterValue = "TextRange_InvalidParameterValue";

		public const string TextRange_UnsupportedDataFormat = "TextRange_UnsupportedDataFormat";

		public const string TextRange_UnrecognizedStructureInDataFormat = "TextRange_UnrecognizedStructureInDataFormat";

		public const string TextRange_PropertyCannotBeIncrementedOrDecremented = "TextRange_PropertyCannotBeIncrementedOrDecremented";

		public const string TextRangeEdit_InvalidStructuralPropertyApply = "TextRangeEdit_InvalidStructuralPropertyApply";

		public const string KeyCorrectionList = "KeyCorrectionList";

		public const string KeyToggleInsert = "KeyToggleInsert";

		public const string KeyDelete = "KeyDelete";

		public const string KeyBackspace = "KeyBackspace";

		public const string KeyShiftBackspace = "KeyShiftBackspace";

		public const string KeyDeleteNextWord = "KeyDeleteNextWord";

		public const string KeyDeletePreviousWord = "KeyDeletePreviousWord";

		public const string KeyEnterParagraphBreak = "KeyEnterParagraphBreak";

		public const string KeyEnterLineBreak = "KeyEnterLineBreak";

		public const string KeyTabForward = "KeyTabForward";

		public const string KeyTabBackward = "KeyTabBackward";

		public const string KeySpace = "KeySpace";

		public const string KeyShiftSpace = "KeyShiftSpace";

		public const string KeyMoveRightByCharacter = "KeyMoveRightByCharacter";

		public const string KeyMoveLeftByCharacter = "KeyMoveLeftByCharacter";

		public const string KeyMoveRightByWord = "KeyMoveRightByWord";

		public const string KeyMoveLeftByWord = "KeyMoveLeftByWord";

		public const string KeyMoveDownByLine = "KeyMoveDownByLine";

		public const string KeyMoveUpByLine = "KeyMoveUpByLine";

		public const string KeyMoveDownByParagraph = "KeyMoveDownByParagraph";

		public const string KeyMoveUpByParagraph = "KeyMoveUpByParagraph";

		public const string KeyMoveDownByPage = "KeyMoveDownByPage";

		public const string KeyMoveUpByPage = "KeyMoveUpByPage";

		public const string KeyMoveToLineStart = "KeyMoveToLineStart";

		public const string KeyMoveToLineEnd = "KeyMoveToLineEnd";

		public const string KeyMoveToColumnStart = "KeyMoveToColumnStart";

		public const string KeyMoveToColumnEnd = "KeyMoveToColumnEnd";

		public const string KeyMoveToWindowTop = "KeyMoveToWindowTop";

		public const string KeyMoveToWindowBottom = "KeyMoveToWindowBottom";

		public const string KeyMoveToDocumentStart = "KeyMoveToDocumentStart";

		public const string KeyMoveToDocumentEnd = "KeyMoveToDocumentEnd";

		public const string KeySelectAll = "KeySelectAll";

		public const string KeySelectRightByCharacter = "KeySelectRightByCharacter";

		public const string KeySelectLeftByCharacter = "KeySelectLeftByCharacter";

		public const string KeySelectRightByWord = "KeySelectRightByWord";

		public const string KeySelectLeftByWord = "KeySelectLeftByWord";

		public const string KeySelectDownByLine = "KeySelectDownByLine";

		public const string KeySelectUpByLine = "KeySelectUpByLine";

		public const string KeySelectDownByParagraph = "KeySelectDownByParagraph";

		public const string KeySelectUpByParagraph = "KeySelectUpByParagraph";

		public const string KeySelectDownByPage = "KeySelectDownByPage";

		public const string KeySelectUpByPage = "KeySelectUpByPage";

		public const string KeySelectToLineStart = "KeySelectToLineStart";

		public const string KeySelectToLineEnd = "KeySelectToLineEnd";

		public const string KeySelectToColumnStart = "KeySelectToColumnStart";

		public const string KeySelectToColumnEnd = "KeySelectToColumnEnd";

		public const string KeySelectToWindowTop = "KeySelectToWindowTop";

		public const string KeySelectToWindowBottom = "KeySelectToWindowBottom";

		public const string KeySelectToDocumentStart = "KeySelectToDocumentStart";

		public const string KeySelectToDocumentEnd = "KeySelectToDocumentEnd";

		public const string KeyUndo = "KeyUndo";

		public const string KeyAltUndo = "KeyAltUndo";

		public const string KeyRedo = "KeyRedo";

		public const string KeyCut = "KeyCut";

		public const string KeyCopy = "KeyCopy";

		public const string KeyShiftDelete = "KeyShiftDelete";

		public const string KeyCtrlInsert = "KeyCtrlInsert";

		public const string KeyShiftInsert = "KeyShiftInsert";

		public const string KeyCopyFormat = "KeyCopyFormat";

		public const string KeyPasteFormat = "KeyPasteFormat";

		public const string KeyResetFormat = "KeyResetFormat";

		public const string KeyToggleBold = "KeyToggleBold";

		public const string KeyToggleItalic = "KeyToggleItalic";

		public const string KeyToggleUnderline = "KeyToggleUnderline";

		public const string KeyToggleSubscript = "KeyToggleSubscript";

		public const string KeyToggleSuperscript = "KeyToggleSuperscript";

		public const string KeyIncreaseFontSize = "KeyIncreaseFontSize";

		public const string KeyDecreaseFontSize = "KeyDecreaseFontSize";

		public const string KeyApplyFontSize = "KeyApplyFontSize";

		public const string KeyApplyFontFamily = "KeyApplyFontFamily";

		public const string KeyApplyForeground = "KeyApplyForeground";

		public const string KeyApplyBackground = "KeyApplyBackground";

		public const string KeyToggleSpellCheck = "KeyToggleSpellCheck";

		public const string KeyAlignLeft = "KeyAlignLeft";

		public const string KeyAlignCenter = "KeyAlignCenter";

		public const string KeyAlignRight = "KeyAlignRight";

		public const string KeyAlignJustify = "KeyAlignJustify";

		public const string KeyApplySingleSpace = "KeyApplySingleSpace";

		public const string KeyApplyOneAndAHalfSpace = "KeyApplyOneAndAHalfSpace";

		public const string KeyApplyDoubleSpace = "KeyApplyDoubleSpace";

		public const string KeyIncreaseIndentation = "KeyIncreaseIndentation";

		public const string KeyDecreaseIndentation = "KeyDecreaseIndentation";

		public const string KeyRemoveListMarkers = "KeyRemoveListMarkers";

		public const string KeyToggleBullets = "KeyToggleBullets";

		public const string KeyToggleNumbering = "KeyToggleNumbering";

		public const string KeyInsertTable = "KeyInsertTable";

		public const string KeyInsertRows = "KeyInsertRows";

		public const string KeyInsertColumns = "KeyInsertColumns";

		public const string KeyDeleteRows = "KeyDeleteRows";

		public const string KeyDeleteColumns = "KeyDeleteColumns";

		public const string KeyMergeCells = "KeyMergeCells";

		public const string KeySplitCell = "KeySplitCell";

		public const string KeyCorrectionListDisplayString = "KeyCorrectionListDisplayString";

		public const string KeyToggleInsertDisplayString = "KeyToggleInsertDisplayString";

		public const string KeyDeleteDisplayString = "KeyDeleteDisplayString";

		public const string KeyBackspaceDisplayString = "KeyBackspaceDisplayString";

		public const string KeyShiftBackspaceDisplayString = "KeyShiftBackspaceDisplayString";

		public const string KeyDeleteNextWordDisplayString = "KeyDeleteNextWordDisplayString";

		public const string KeyDeletePreviousWordDisplayString = "KeyDeletePreviousWordDisplayString";

		public const string KeyEnterParagraphBreakDisplayString = "KeyEnterParagraphBreakDisplayString";

		public const string KeyEnterLineBreakDisplayString = "KeyEnterLineBreakDisplayString";

		public const string KeyTabForwardDisplayString = "KeyTabForwardDisplayString";

		public const string KeyTabBackwardDisplayString = "KeyTabBackwardDisplayString";

		public const string KeySpaceDisplayString = "KeySpaceDisplayString";

		public const string KeyShiftSpaceDisplayString = "KeyShiftSpaceDisplayString";

		public const string KeyMoveRightByCharacterDisplayString = "KeyMoveRightByCharacterDisplayString";

		public const string KeyMoveLeftByCharacterDisplayString = "KeyMoveLeftByCharacterDisplayString";

		public const string KeyMoveRightByWordDisplayString = "KeyMoveRightByWordDisplayString";

		public const string KeyMoveLeftByWordDisplayString = "KeyMoveLeftByWordDisplayString";

		public const string KeyMoveDownByLineDisplayString = "KeyMoveDownByLineDisplayString";

		public const string KeyMoveUpByLineDisplayString = "KeyMoveUpByLineDisplayString";

		public const string KeyMoveDownByParagraphDisplayString = "KeyMoveDownByParagraphDisplayString";

		public const string KeyMoveUpByParagraphDisplayString = "KeyMoveUpByParagraphDisplayString";

		public const string KeyMoveDownByPageDisplayString = "KeyMoveDownByPageDisplayString";

		public const string KeyMoveUpByPageDisplayString = "KeyMoveUpByPageDisplayString";

		public const string KeyMoveToLineStartDisplayString = "KeyMoveToLineStartDisplayString";

		public const string KeyMoveToLineEndDisplayString = "KeyMoveToLineEndDisplayString";

		public const string KeyMoveToColumnStartDisplayString = "KeyMoveToColumnStartDisplayString";

		public const string KeyMoveToColumnEndDisplayString = "KeyMoveToColumnEndDisplayString";

		public const string KeyMoveToWindowTopDisplayString = "KeyMoveToWindowTopDisplayString";

		public const string KeyMoveToWindowBottomDisplayString = "KeyMoveToWindowBottomDisplayString";

		public const string KeyMoveToDocumentStartDisplayString = "KeyMoveToDocumentStartDisplayString";

		public const string KeyMoveToDocumentEndDisplayString = "KeyMoveToDocumentEndDisplayString";

		public const string KeySelectAllDisplayString = "KeySelectAllDisplayString";

		public const string KeySelectRightByCharacterDisplayString = "KeySelectRightByCharacterDisplayString";

		public const string KeySelectLeftByCharacterDisplayString = "KeySelectLeftByCharacterDisplayString";

		public const string KeySelectRightByWordDisplayString = "KeySelectRightByWordDisplayString";

		public const string KeySelectLeftByWordDisplayString = "KeySelectLeftByWordDisplayString";

		public const string KeySelectDownByLineDisplayString = "KeySelectDownByLineDisplayString";

		public const string KeySelectUpByLineDisplayString = "KeySelectUpByLineDisplayString";

		public const string KeySelectDownByParagraphDisplayString = "KeySelectDownByParagraphDisplayString";

		public const string KeySelectUpByParagraphDisplayString = "KeySelectUpByParagraphDisplayString";

		public const string KeySelectDownByPageDisplayString = "KeySelectDownByPageDisplayString";

		public const string KeySelectUpByPageDisplayString = "KeySelectUpByPageDisplayString";

		public const string KeySelectToLineStartDisplayString = "KeySelectToLineStartDisplayString";

		public const string KeySelectToLineEndDisplayString = "KeySelectToLineEndDisplayString";

		public const string KeySelectToColumnStartDisplayString = "KeySelectToColumnStartDisplayString";

		public const string KeySelectToColumnEndDisplayString = "KeySelectToColumnEndDisplayString";

		public const string KeySelectToWindowTopDisplayString = "KeySelectToWindowTopDisplayString";

		public const string KeySelectToWindowBottomDisplayString = "KeySelectToWindowBottomDisplayString";

		public const string KeySelectToDocumentStartDisplayString = "KeySelectToDocumentStartDisplayString";

		public const string KeySelectToDocumentEndDisplayString = "KeySelectToDocumentEndDisplayString";

		public const string KeyUndoDisplayString = "KeyUndoDisplayString";

		public const string KeyAltUndoDisplayString = "KeyAltUndoDisplayString";

		public const string KeyRedoDisplayString = "KeyRedoDisplayString";

		public const string KeyCutDisplayString = "KeyCutDisplayString";

		public const string KeyCopyDisplayString = "KeyCopyDisplayString";

		public const string KeyShiftDeleteDisplayString = "KeyShiftDeleteDisplayString";

		public const string KeyCtrlInsertDisplayString = "KeyCtrlInsertDisplayString";

		public const string KeyShiftInsertDisplayString = "KeyShiftInsertDisplayString";

		public const string KeyCopyFormatDisplayString = "KeyCopyFormatDisplayString";

		public const string KeyPasteFormatDisplayString = "KeyPasteFormatDisplayString";

		public const string KeyResetFormatDisplayString = "KeyResetFormatDisplayString";

		public const string KeyToggleBoldDisplayString = "KeyToggleBoldDisplayString";

		public const string KeyToggleItalicDisplayString = "KeyToggleItalicDisplayString";

		public const string KeyToggleUnderlineDisplayString = "KeyToggleUnderlineDisplayString";

		public const string KeyToggleSubscriptDisplayString = "KeyToggleSubscriptDisplayString";

		public const string KeyToggleSuperscriptDisplayString = "KeyToggleSuperscriptDisplayString";

		public const string KeyIncreaseFontSizeDisplayString = "KeyIncreaseFontSizeDisplayString";

		public const string KeyDecreaseFontSizeDisplayString = "KeyDecreaseFontSizeDisplayString";

		public const string KeyApplyFontSizeDisplayString = "KeyApplyFontSizeDisplayString";

		public const string KeyApplyFontFamilyDisplayString = "KeyApplyFontFamilyDisplayString";

		public const string KeyApplyForegroundDisplayString = "KeyApplyForegroundDisplayString";

		public const string KeyApplyBackgroundDisplayString = "KeyApplyBackgroundDisplayString";

		public const string KeyToggleSpellCheckDisplayString = "KeyToggleSpellCheckDisplayString";

		public const string KeyAlignLeftDisplayString = "KeyAlignLeftDisplayString";

		public const string KeyAlignCenterDisplayString = "KeyAlignCenterDisplayString";

		public const string KeyAlignRightDisplayString = "KeyAlignRightDisplayString";

		public const string KeyAlignJustifyDisplayString = "KeyAlignJustifyDisplayString";

		public const string KeyApplySingleSpaceDisplayString = "KeyApplySingleSpaceDisplayString";

		public const string KeyApplyOneAndAHalfSpaceDisplayString = "KeyApplyOneAndAHalfSpaceDisplayString";

		public const string KeyApplyDoubleSpaceDisplayString = "KeyApplyDoubleSpaceDisplayString";

		public const string KeyIncreaseIndentationDisplayString = "KeyIncreaseIndentationDisplayString";

		public const string KeyDecreaseIndentationDisplayString = "KeyDecreaseIndentationDisplayString";

		public const string KeyRemoveListMarkersDisplayString = "KeyRemoveListMarkersDisplayString";

		public const string KeyToggleBulletsDisplayString = "KeyToggleBulletsDisplayString";

		public const string KeyToggleNumberingDisplayString = "KeyToggleNumberingDisplayString";

		public const string KeyInsertTableDisplayString = "KeyInsertTableDisplayString";

		public const string KeyInsertRowsDisplayString = "KeyInsertRowsDisplayString";

		public const string KeyInsertColumnsDisplayString = "KeyInsertColumnsDisplayString";

		public const string KeyDeleteRowsDisplayString = "KeyDeleteRowsDisplayString";

		public const string KeyDeleteColumnsDisplayString = "KeyDeleteColumnsDisplayString";

		public const string KeyMergeCellsDisplayString = "KeyMergeCellsDisplayString";

		public const string KeySplitCellDisplayString = "KeySplitCellDisplayString";

		public const string KeySwitchViewingMode = "KeySwitchViewingMode";

		public const string KeySwitchViewingModeDisplayString = "KeySwitchViewingModeDisplayString";

		public const string TextStore_E_NOTIMPL = "TextStore_E_NOTIMPL";

		public const string TextStore_E_NOINTERFACE = "TextStore_E_NOINTERFACE";

		public const string TextStore_CONNECT_E_CANNOTCONNECT = "TextStore_CONNECT_E_CANNOTCONNECT";

		public const string TextStore_CONNECT_E_NOCONNECTION = "TextStore_CONNECT_E_NOCONNECTION";

		public const string TextStore_TS_E_INVALIDPOINT = "TextStore_TS_E_INVALIDPOINT";

		public const string TextStore_TS_E_NOLAYOUT = "TextStore_TS_E_NOLAYOUT";

		public const string TextStore_TS_E_READONLY = "TextStore_TS_E_READONLY";

		public const string TextStore_TS_E_FORMAT = "TextStore_TS_E_FORMAT";

		public const string TextStore_NoSink = "TextStore_NoSink";

		public const string TextStore_BadLockFlags = "TextStore_BadLockFlags";

		public const string TextStore_ReentrantRequestLock = "TextStore_ReentrantRequestLock";

		public const string TextStore_CompositionRejected = "TextStore_CompositionRejected";

		public const string TextStore_BadIMECharOffset = "TextStore_BadIMECharOffset";

		public const string InputScopeAttribute_E_OUTOFMEMORY = "InputScopeAttribute_E_OUTOFMEMORY";

		public const string WpfPayload_InvalidImageSource = "WpfPayload_InvalidImageSource";

		public const string SelectionChangeActive = "SelectionChangeActive";

		public const string SelectionChangeNotActive = "SelectionChangeNotActive";

		public const string CannotSelectNotSelectableItem = "CannotSelectNotSelectableItem";

		public const string ListBoxSelectAllSelectionMode = "ListBoxSelectAllSelectionMode";

		public const string ChangingCollectionNotSupported = "ChangingCollectionNotSupported";

		public const string DeferSelectionActive = "DeferSelectionActive";

		public const string DeferSelectionNotActive = "DeferSelectionNotActive";

		public const string InsertInDeferSelectionActive = "InsertInDeferSelectionActive";

		public const string SetInDeferSelectionActive = "SetInDeferSelectionActive";

		public const string MoveInDeferSelectionActive = "MoveInDeferSelectionActive";

		public const string MultiSelectorSelectAll = "MultiSelectorSelectAll";

		public const string ListBoxSelectAllKey = "ListBoxSelectAllKey";

		public const string ListBoxSelectAllKeyDisplayString = "ListBoxSelectAllKeyDisplayString";

		public const string ListBoxSelectAllText = "ListBoxSelectAllText";

		public const string ListBoxInvalidAnchorItem = "ListBoxInvalidAnchorItem";

		public const string CreateRootPopup_ChildHasLogicalParent = "CreateRootPopup_ChildHasLogicalParent";

		public const string CreateRootPopup_ChildHasVisualParent = "CreateRootPopup_ChildHasVisualParent";

		public const string ElementMustBeInPopup = "ElementMustBeInPopup";

		public const string PopupReopeningNotAllowed = "PopupReopeningNotAllowed";

		public const string ContextMenuInDifferentDispatcher = "ContextMenuInDifferentDispatcher";

		public const string ToolTipStaysOpenFalseNotAllowed = "ToolTipStaysOpenFalseNotAllowed";

		public const string StyleImpliedAndComplexChildren = "StyleImpliedAndComplexChildren";

		public const string StyleInvalidElementTag = "StyleInvalidElementTag";

		public const string StyleKnownTagWrongLocation = "StyleKnownTagWrongLocation";

		public const string StyleNoTemplateBindInSetters = "StyleNoTemplateBindInSetters";

		public const string StyleNoTemplateBindInVisualTrigger = "StyleNoTemplateBindInVisualTrigger";

		public const string StyleNoClrEvent = "StyleNoClrEvent";

		public const string StyleNoDef = "StyleNoDef";

		public const string StyleNoDictionaryKey = "StyleNoDictionaryKey";

		public const string StyleNoSetterResource = "StyleNoSetterResource";

		public const string StyleNoTopLevelElement = "StyleNoTopLevelElement";

		public const string StylePropertyCustom = "StylePropertyCustom";

		public const string StylePropertySetterMinAttrs = "StylePropertySetterMinAttrs";

		public const string StylePropTriggerPropMissing = "StylePropTriggerPropMissing";

		public const string StyleDataTriggerBindingMissing = "StyleDataTriggerBindingMissing";

		public const string StyleDataTriggerBindingHasBadValue = "StyleDataTriggerBindingHasBadValue";

		public const string StyleSetterUnknownProp = "StyleSetterUnknownProp";

		public const string StyleTagNotSupported = "StyleTagNotSupported";

		public const string StyleTextNotSupported = "StyleTextNotSupported";

		public const string StyleUnknownProp = "StyleUnknownProp";

		public const string StyleUnknownTrigger = "StyleUnknownTrigger";

		public const string StyleNoEventSetters = "StyleNoEventSetters";

		public const string SourceNameNotSupportedForStyleTriggers = "SourceNameNotSupportedForStyleTriggers";

		public const string StyleNoPropOrEvent = "StyleNoPropOrEvent";

		public const string StyleNoTarget = "StyleNoTarget";

		public const string TargetNameNotSupportedForStyleSetters = "TargetNameNotSupportedForStyleSetters";

		public const string TemplateDupName = "TemplateDupName";

		public const string TemplateBadDictionaryKey = "TemplateBadDictionaryKey";

		public const string TemplateInvalidRootElementTag = "TemplateInvalidRootElementTag";

		public const string TemplateKnownTagWrongLocation = "TemplateKnownTagWrongLocation";

		public const string TemplateNoTemplateBindInVisualTrigger = "TemplateNoTemplateBindInVisualTrigger";

		public const string TemplateNoMultipleRoots = "TemplateNoMultipleRoots";

		public const string TemplateNoTriggerTarget = "TemplateNoTriggerTarget";

		public const string TemplateNoProp = "TemplateNoProp";

		public const string TemplateNoTarget = "TemplateNoTarget";

		public const string TemplateTagNotSupported = "TemplateTagNotSupported";

		public const string TemplateTextNotSupported = "TemplateTextNotSupported";

		public const string TemplateUnknownProp = "TemplateUnknownProp";

		public const string ContentControlCannotHaveMultipleContent = "ContentControlCannotHaveMultipleContent";

		public const string MissingContentSource = "MissingContentSource";

		public const string CannotQueryPropertiesWhenPageNotInTreeWithWindow = "CannotQueryPropertiesWhenPageNotInTreeWithWindow";

		public const string ParentOfPageMustBeWindowOrFrame = "ParentOfPageMustBeWindowOrFrame";

		public const string PageCannotHaveMultipleContent = "PageCannotHaveMultipleContent";

		public const string WindowMustBeRoot = "WindowMustBeRoot";

		public const string CircularOwnerChild = "CircularOwnerChild";

		public const string CannotSetOwnerToItself = "CannotSetOwnerToItself";

		public const string CantSetOwnerToClosedWindow = "CantSetOwnerToClosedWindow";

		public const string CantSetOwnerWhosHwndIsNotCreated = "CantSetOwnerWhosHwndIsNotCreated";

		public const string ShowDialogOnVisible = "ShowDialogOnVisible";

		public const string ShowDialogOnModal = "ShowDialogOnModal";

		public const string CantSetOwnerAfterDialogIsShown = "CantSetOwnerAfterDialogIsShown";

		public const string DragMoveFail = "DragMoveFail";

		public const string IncorrectFlowDirection = "IncorrectFlowDirection";

		public const string CantSetInMarkup = "CantSetInMarkup";

		public const string ValueNotBetweenInt32MinMax = "ValueNotBetweenInt32MinMax";

		public const string InvalidValueForTopLeft = "InvalidValueForTopLeft";

		public const string TransformNotSupported = "TransformNotSupported";

		public const string ClipToBoundsNotSupported = "ClipToBoundsNotSupported";

		public const string DialogResultMustBeSetAfterShowDialog = "DialogResultMustBeSetAfterShowDialog";

		public const string IconMustBeBitmapFrame = "IconMustBeBitmapFrame";

		public const string ReshowNotAllowed = "ReshowNotAllowed";

		public const string InvalidOperationDuringClosing = "InvalidOperationDuringClosing";

		public const string InvalidCompositionTarget = "InvalidCompositionTarget";

		public const string ChangeNotAllowedAfterShow = "ChangeNotAllowedAfterShow";

		public const string MustUseWindowStyleNone = "MustUseWindowStyleNone";

		public const string ShowNonActivatedAndMaximized = "ShowNonActivatedAndMaximized";

		public const string NotAllowedBeforeShow = "NotAllowedBeforeShow";

		public const string NotSupportedInBrowser = "NotSupportedInBrowser";

		public const string WebBrowserOverlap = "WebBrowserOverlap";

		public const string PrintJobDescription = "PrintJobDescription";

		public const string UntitledPrintJobDescription = "UntitledPrintJobDescription";

		public const string CannotBeInsidePopup = "CannotBeInsidePopup";

		public const string CannotInvokeScript = "CannotInvokeScript";

		public const string NeedToBeComVisible = "NeedToBeComVisible";

		public const string AbsoluteUriOnly = "AbsoluteUriOnly";

		public const string CantShowMBServiceWithOwner = "CantShowMBServiceWithOwner";

		public const string NoMulticastHandlers = "NoMulticastHandlers";

		public const string PropertyPathSyntaxError = "PropertyPathSyntaxError";

		public const string PropertyPathNoProperty = "PropertyPathNoProperty";

		public const string PropertyPathNoOwnerType = "PropertyPathNoOwnerType";

		public const string PropertyPathInvalidAccessor = "PropertyPathInvalidAccessor";

		public const string BindingConflict = "BindingConflict";

		public const string PropertyNotBindable = "PropertyNotBindable";

		public const string RequiresExplicitCulture = "RequiresExplicitCulture";

		public const string BindingExpressionStatusChanged = "BindingExpressionStatusChanged";

		public const string PathSyntax = "PathSyntax";

		public const string UnmatchedBracket = "UnmatchedBracket";

		public const string UnmatchedParen = "UnmatchedParen";

		public const string BindingListCanOnlySortByOneProperty = "BindingListCanOnlySortByOneProperty";

		public const string BindingListCannotCustomFilter = "BindingListCannotCustomFilter";

		public const string InconsistentBindingList = "InconsistentBindingList";

		public const string RequiresXmlNamespaceMapping = "RequiresXmlNamespaceMapping";

		public const string RequiresXmlNamespaceMappingUri = "RequiresXmlNamespaceMappingUri";

		public const string ChildHasWrongType = "ChildHasWrongType";

		public const string BadTargetArray = "BadTargetArray";

		public const string CopyToNotEnoughSpace = "CopyToNotEnoughSpace";

		public const string MissingValueConverter = "MissingValueConverter";

		public const string MultiBindingHasNoConverter = "MultiBindingHasNoConverter";

		public const string NoUpdateSourceTriggerForInnerBindingOfMultiBinding = "NoUpdateSourceTriggerForInnerBindingOfMultiBinding";

		public const string BindingExpressionIsDetached = "BindingExpressionIsDetached";

		public const string DuplicatesNotAllowed = "DuplicatesNotAllowed";

		public const string ImplementOtherMembersWithSort = "ImplementOtherMembersWithSort";

		public const string NoCheckOrChangeWhenDeferred = "NoCheckOrChangeWhenDeferred";

		public const string TwoWayBindingNeedsPath = "TwoWayBindingNeedsPath";

		public const string AdornedElementPlaceholderMustBeInTemplate = "AdornedElementPlaceholderMustBeInTemplate";

		public const string BindingCollectionContainsNonBinding = "BindingCollectionContainsNonBinding";

		public const string CannotWriteToReadOnly = "CannotWriteToReadOnly";

		public const string PathParametersIndexOutOfRange = "PathParametersIndexOutOfRange";

		public const string PathParameterIsNull = "PathParameterIsNull";

		public const string PropertyPathIndexWrongType = "PropertyPathIndexWrongType";

		public const string ChangeSealedBinding = "ChangeSealedBinding";

		public const string CannotChangeLiveShaping = "CannotChangeLiveShaping";

		public const string ObjectDataProviderHasNoSource = "ObjectDataProviderHasNoSource";

		public const string ObjectDataProviderCanHaveOnlyOneSource = "ObjectDataProviderCanHaveOnlyOneSource";

		public const string ObjectDataProviderNonCLSException = "ObjectDataProviderNonCLSException";

		public const string ObjectDataProviderNonCLSExceptionInvoke = "ObjectDataProviderNonCLSExceptionInvoke";

		public const string ObjectDataProviderParameterCollectionIsNotInUse = "ObjectDataProviderParameterCollectionIsNotInUse";

		public const string RelativeSourceNotInFindAncestorMode = "RelativeSourceNotInFindAncestorMode";

		public const string RelativeSourceInvalidAncestorLevel = "RelativeSourceInvalidAncestorLevel";

		public const string RelativeSourceNeedsMode = "RelativeSourceNeedsMode";

		public const string RelativeSourceNeedsAncestorType = "RelativeSourceNeedsAncestorType";

		public const string RelativeSourceModeIsImmutable = "RelativeSourceModeIsImmutable";

		public const string RelativeSourceModeInvalid = "RelativeSourceModeInvalid";

		public const string ExceptionValidationRuleValidateNotSupported = "ExceptionValidationRuleValidateNotSupported";

		public const string ValidationRule_UnexpectedValue = "ValidationRule_UnexpectedValue";

		public const string ValidationRule_UnknownStep = "ValidationRule_UnknownStep";

		public const string Validation_ConversionFailed = "Validation_ConversionFailed";

		public const string BindingGroup_NoEntry = "BindingGroup_NoEntry";

		public const string BindingGroup_ValueUnavailable = "BindingGroup_ValueUnavailable";

		public const string BindingGroup_CannotChangeGroups = "BindingGroup_CannotChangeGroups";

		public const string IndexedPropDescNotImplemented = "IndexedPropDescNotImplemented";

		public const string NonCLSException = "NonCLSException";

		public const string DisplayMemberPathAndItemTemplateSelectorDefined = "DisplayMemberPathAndItemTemplateSelectorDefined";

		public const string DisplayMemberPathAndItemTemplateDefined = "DisplayMemberPathAndItemTemplateDefined";

		public const string ItemTemplateSelectorBreaksDisplayMemberPath = "ItemTemplateSelectorBreaksDisplayMemberPath";

		public const string CannotFindRemovedItem = "CannotFindRemovedItem";

		public const string PanelIsNotItemsHost = "PanelIsNotItemsHost";

		public const string CannotRemoveUnrealizedItems = "CannotRemoveUnrealizedItems";

		public const string GenerationInProgress = "GenerationInProgress";

		public const string GenerationNotInProgress = "GenerationNotInProgress";

		public const string RemoveRequiresOffsetZero = "RemoveRequiresOffsetZero";

		public const string RemoveRequiresPositiveCount = "RemoveRequiresPositiveCount";

		public const string MustBeTypeOrString = "MustBeTypeOrString";

		public const string DataTypeCannotBeObject = "DataTypeCannotBeObject";

		public const string ItemsPanelNotAPanel = "ItemsPanelNotAPanel";

		public const string ItemsPanelNotSingleNode = "ItemsPanelNotSingleNode";

		public const string TemplateMustBeFE = "TemplateMustBeFE";

		public const string CollectionViewTypeIsInitOnly = "CollectionViewTypeIsInitOnly";

		public const string CannotSortView = "CannotSortView";

		public const string CannotFilterView = "CannotFilterView";

		public const string CannotGroupView = "CannotGroupView";

		public const string RangeActionsNotSupported = "RangeActionsNotSupported";

		public const string AddedItemNotInCollection = "AddedItemNotInCollection";

		public const string AddedItemNotAtIndex = "AddedItemNotAtIndex";

		public const string RemovedItemNotFound = "RemovedItemNotFound";

		public const string CollectionChangeIndexOutOfRange = "CollectionChangeIndexOutOfRange";

		public const string MultiThreadedCollectionChangeNotSupported = "MultiThreadedCollectionChangeNotSupported";

		public const string CannotMoveToUnknownPosition = "CannotMoveToUnknownPosition";

		public const string CompositeCollectionResetOnlyOnClear = "CompositeCollectionResetOnlyOnClear";

		public const string CollectionContainerMustBeUniqueForComposite = "CollectionContainerMustBeUniqueForComposite";

		public const string MemberNotAllowedDuringAddOrEdit = "MemberNotAllowedDuringAddOrEdit";

		public const string MemberNotAllowedForView = "MemberNotAllowedForView";

		public const string MemberNotAllowedDuringTransaction = "MemberNotAllowedDuringTransaction";

		public const string RemovingPlaceholder = "RemovingPlaceholder";

		public const string CannotEditPlaceholder = "CannotEditPlaceholder";

		public const string CancelEditNotSupported = "CancelEditNotSupported";

		public const string MultiSingleton = "MultiSingleton";

		public const string ApplicationAlreadyRunning = "ApplicationAlreadyRunning";

		public const string CannotCallRunMultipleTimes = "CannotCallRunMultipleTimes";

		public const string WindowPassedShouldBeOnApplicationThread = "WindowPassedShouldBeOnApplicationThread";

		public const string ShutdownModeWhenAppShutdown = "ShutdownModeWhenAppShutdown";

		public const string UnknownContainerFormat = "UnknownContainerFormat";

		public const string ContentTypeNotSupported = "ContentTypeNotSupported";

		public const string UriNotMatchWithRootType = "UriNotMatchWithRootType";

		public const string WebRequestCreationFailed = "WebRequestCreationFailed";

		public const string GetResponseFailed = "GetResponseFailed";

		public const string GetStreamFailed = "GetStreamFailed";

		public const string EntryAssemblyIsNull = "EntryAssemblyIsNull";

		public const string UnableToLocateResource = "UnableToLocateResource";

		public const string CannotCallRunFromBrowserHostedApp = "CannotCallRunFromBrowserHostedApp";

		public const string AbsoluteUriNotAllowed = "AbsoluteUriNotAllowed";

		public const string CannotChangeMainWindowInBrowser = "CannotChangeMainWindowInBrowser";

		public const string ArgumentPropertyMustNotBeNull = "ArgumentPropertyMustNotBeNull";

		public const string NonPackAppAbsoluteUriNotAllowed = "NonPackAppAbsoluteUriNotAllowed";

		public const string NonPackSooAbsoluteUriNotAllowed = "NonPackSooAbsoluteUriNotAllowed";

		public const string NonClsActivationException = "NonClsActivationException";

		public const string AppActivationException = "AppActivationException";

		public const string KillBitEnforcedShutdown = "KillBitEnforcedShutdown";

		public const string ApplicationShuttingDown = "ApplicationShuttingDown";

		public const string AffectedByMsCtfIssue = "AffectedByMsCtfIssue";

		public const string AxRequiresApartmentThread = "AxRequiresApartmentThread";

		public const string AXNohWnd = "AXNohWnd";

		public const string AxNoEventInterface = "AxNoEventInterface";

		public const string AxNoSinkImplementation = "AxNoSinkImplementation";

		public const string AxNoSinkAdvise = "AxNoSinkAdvise";

		public const string AxNoConnectionPointContainer = "AxNoConnectionPointContainer";

		public const string AxNoConnectionPoint = "AxNoConnectionPoint";

		public const string WebBrowserNoCastToIWebBrowser2 = "WebBrowserNoCastToIWebBrowser2";

		public const string AxWindowlessControl = "AxWindowlessControl";

		public const string HyperLinkTargetNotFound = "HyperLinkTargetNotFound";

		public const string FailToNavigateUsingHyperlinkTarget = "FailToNavigateUsingHyperlinkTarget";

		public const string WrongNavigateRootElement = "WrongNavigateRootElement";

		public const string LoopDetected = "LoopDetected";

		public const string RequestNavigateEventMustHaveRoutedEvent = "RequestNavigateEventMustHaveRoutedEvent";

		public const string MustImplementIUriContext = "MustImplementIUriContext";

		public const string FailedToConvertResource = "FailedToConvertResource";

		public const string WindowAlreadyClosed = "WindowAlreadyClosed";

		public const string BamlIsNotSupportedOutsideOfApplicationResources = "BamlIsNotSupportedOutsideOfApplicationResources";

		public const string UiLessPageFunctionNotCallingOnReturn = "UiLessPageFunctionNotCallingOnReturn";

		public const string FailToLaunchDefaultBrowser = "FailToLaunchDefaultBrowser";

		public const string NoBackEntry = "NoBackEntry";

		public const string NoForwardEntry = "NoForwardEntry";

		public const string NoAddChild = "NoAddChild";

		public const string InvalidOperation_CannotClearFwdStack = "InvalidOperation_CannotClearFwdStack";

		public const string InvalidOperation_MustImplementIPCCSOrHandleNavigating = "InvalidOperation_MustImplementIPCCSOrHandleNavigating";

		public const string CustomContentStateMustBeSerializable = "CustomContentStateMustBeSerializable";

		public const string InvalidOperation_CantChangeJournalOwnership = "InvalidOperation_CantChangeJournalOwnership";

		public const string InvalidOperation_NoJournal = "InvalidOperation_NoJournal";

		public const string InvalidOperation_AddBackEntryNoContent = "InvalidOperation_AddBackEntryNoContent";

		public const string InvalidPageFunctionType = "InvalidPageFunctionType";

		public const string InvalidOperation_CannotReenterPageFunction = "InvalidOperation_CannotReenterPageFunction";

		public const string ReturnEventHandlerMustBeOnParentPage = "ReturnEventHandlerMustBeOnParentPage";

		public const string FailedResumePageFunction = "FailedResumePageFunction";

		public const string PropertyToSortByNotFoundOnType = "PropertyToSortByNotFoundOnType";

		public const string CannotDetermineSortByPropertiesForCollection = "CannotDetermineSortByPropertiesForCollection";

		public const string BamlReaderClosed = "BamlReaderClosed";

		public const string BamlReaderNoOwnerType = "BamlReaderNoOwnerType";

		public const string BamlScopeError = "BamlScopeError";

		public const string BamlBadExtensionValue = "BamlBadExtensionValue";

		public const string BamlWriterBadAssembly = "BamlWriterBadAssembly";

		public const string BamlWriterBadScope = "BamlWriterBadScope";

		public const string BamlWriterBadStream = "BamlWriterBadStream";

		public const string BamlWriterBadXmlns = "BamlWriterBadXmlns";

		public const string BamlWriterClosed = "BamlWriterClosed";

		public const string BamlWriterNoInElement = "BamlWriterNoInElement";

		public const string BamlWriterStartDoc = "BamlWriterStartDoc";

		public const string BamlWriterUnknownMarkupExtension = "BamlWriterUnknownMarkupExtension";

		public const string MarkupExtensionDynamicOrBindingOnClrProp = "MarkupExtensionDynamicOrBindingOnClrProp";

		public const string MarkupExtensionDynamicOrBindingInCollection = "MarkupExtensionDynamicOrBindingInCollection";

		public const string MarkupExtensionNoContext = "MarkupExtensionNoContext";

		public const string MarkupExtensionProperty = "MarkupExtensionProperty";

		public const string MarkupExtensionResourceKey = "MarkupExtensionResourceKey";

		public const string MarkupExtensionResourceNotFound = "MarkupExtensionResourceNotFound";

		public const string ColorConvertedBitmapExtensionSyntax = "ColorConvertedBitmapExtensionSyntax";

		public const string ColorConvertedBitmapExtensionNoSourceImage = "ColorConvertedBitmapExtensionNoSourceImage";

		public const string ColorConvertedBitmapExtensionNoSourceProfile = "ColorConvertedBitmapExtensionNoSourceProfile";

		public const string ParserAbandonedTypeConverterText = "ParserAbandonedTypeConverterText";

		public const string ParserAsyncOnRoot = "ParserAsyncOnRoot";

		public const string ParserAttachedPropInheritError = "ParserAttachedPropInheritError";

		public const string ParserAttributeArgsLow = "ParserAttributeArgsLow";

		public const string ParserBadAssemblyName = "ParserBadAssemblyName";

		public const string ParserBadAssemblyPath = "ParserBadAssemblyPath";

		public const string ParserBadChild = "ParserBadChild";

		public const string ParserBadConstructorParams = "ParserBadConstructorParams";

		public const string ParserBadName = "ParserBadName";

		public const string ParserBadUidOrNameME = "ParserBadUidOrNameME";

		public const string ParserBadNullableType = "ParserBadNullableType";

		public const string ParserBadKey = "ParserBadKey";

		public const string ParserBadSyncMode = "ParserBadSyncMode";

		public const string ParserBadTypeInArrayProperty = "ParserBadTypeInArrayProperty";

		public const string ParserBadEncoding = "ParserBadEncoding";

		public const string ParserBamlEvent = "ParserBamlEvent";

		public const string ParserBamlVersion = "ParserBamlVersion";

		public const string ParserCannotAddChild = "ParserCannotAddChild";

		public const string ParserCannotConvertString = "ParserCannotConvertString";

		public const string ParserCannotSetValue = "ParserCannotSetValue";

		public const string ParserCantCreateTextComplexProp = "ParserCantCreateTextComplexProp";

		public const string ParserCantCreateInstanceType = "ParserCantCreateInstanceType";

		public const string ParserCantGetDPOrPi = "ParserCantGetDPOrPi";

		public const string ParserCompatDuplicate = "ParserCompatDuplicate";

		public const string ParserDefaultConverterProperty = "ParserDefaultConverterProperty";

		public const string ParserDefaultConverterElement = "ParserDefaultConverterElement";

		public const string ParserDeferContentAsync = "ParserDeferContentAsync";

		public const string ParserDefTag = "ParserDefTag";

		public const string ParserDefSharedOnlyInCompiled = "ParserDefSharedOnlyInCompiled";

		public const string ParserDictionarySealed = "ParserDictionarySealed";

		public const string ParserDupDictionaryKey = "ParserDupDictionaryKey";

		public const string ParserDuplicateMarkupExtensionProperty = "ParserDuplicateMarkupExtensionProperty";

		public const string ParserDuplicateProperty1 = "ParserDuplicateProperty1";

		public const string ParserDuplicateProperty2 = "ParserDuplicateProperty2";

		public const string ParserEmptyComplexProp = "ParserEmptyComplexProp";

		public const string ParserEntityReference = "ParserEntityReference";

		public const string ParserErrorCreatingInstance = "ParserErrorCreatingInstance";

		public const string ParserErrorParsingAttrib = "ParserErrorParsingAttrib";

		public const string ParserErrorParsingAttribType = "ParserErrorParsingAttribType";

		public const string ParserFailFindType = "ParserFailFindType";

		public const string ParserFailedToCreateFromConstructor = "ParserFailedToCreateFromConstructor";

		public const string ParserFilterXmlReaderNoDefinitionPrefixChangeAllowed = "ParserFilterXmlReaderNoDefinitionPrefixChangeAllowed";

		public const string ParserFilterXmlReaderNoIndexAttributeAccess = "ParserFilterXmlReaderNoIndexAttributeAccess";

		public const string ParserCannotAddAnyChildren = "ParserCannotAddAnyChildren";

		public const string ParserCannotAddAnyChildren2 = "ParserCannotAddAnyChildren2";

		public const string ParserIAddChildText = "ParserIAddChildText";

		public const string ParserIEnumerableIAddChild = "ParserIEnumerableIAddChild";

		public const string ParserInvalidContentPropertyAttribute = "ParserInvalidContentPropertyAttribute";

		public const string ParserInvalidIdentifierName = "ParserInvalidIdentifierName";

		public const string ParserKeyOnExplicitDictionary = "ParserKeyOnExplicitDictionary";

		public const string ParserKeysAreStrings = "ParserKeysAreStrings";

		public const string ParserLineAndOffset = "ParserLineAndOffset";

		public const string ParserMapPIMissingKey = "ParserMapPIMissingKey";

		public const string ParserMapPIMissingAssembly = "ParserMapPIMissingAssembly";

		public const string ParserMappingUriInvalid = "ParserMappingUriInvalid";

		public const string ParserMarkupExtensionBadConstructorParam = "ParserMarkupExtensionBadConstructorParam";

		public const string ParserMarkupExtensionBadDelimiter = "ParserMarkupExtensionBadDelimiter";

		public const string ParserMarkupExtensionNoEndCurlie = "ParserMarkupExtensionNoEndCurlie";

		public const string ParserMarkupExtensionNoNameValue = "ParserMarkupExtensionNoNameValue";

		public const string ParserMarkupExtensionNoQuotesInName = "ParserMarkupExtensionNoQuotesInName";

		public const string ParserMarkupExtensionTrailingGarbage = "ParserMarkupExtensionTrailingGarbage";

		public const string ParserMarkupExtensionUnknownAttr = "ParserMarkupExtensionUnknownAttr";

		public const string ParserMarkupExtensionDelimiterBeforeFirstAttribute = "ParserMarkupExtensionDelimiterBeforeFirstAttribute";

		public const string ParserMetroUnknownAttribute = "ParserMetroUnknownAttribute";

		public const string ParserMultiBamls = "ParserMultiBamls";

		public const string ParserMultiRoot = "ParserMultiRoot";

		public const string ParserAttributeNamespaceMisMatch = "ParserAttributeNamespaceMisMatch";

		public const string ParserNestedComplexProp = "ParserNestedComplexProp";

		public const string ParserNoAttrArray = "ParserNoAttrArray";

		public const string ParserNoChildrenTag = "ParserNoChildrenTag";

		public const string ParserNoComplexMulti = "ParserNoComplexMulti";

		public const string ParserNoDefaultConstructor = "ParserNoDefaultConstructor";

		public const string ParserNoDefaultPropConstructor = "ParserNoDefaultPropConstructor";

		public const string ParserNoDictionaryKey = "ParserNoDictionaryKey";

		public const string ParserNoDictionaryName = "ParserNoDictionaryName";

		public const string ParserNoDigitEnums = "ParserNoDigitEnums";

		public const string ParserNoElementCreate2 = "ParserNoElementCreate2";

		public const string ParserNoEvents = "ParserNoEvents";

		public const string ParserNoEventTag = "ParserNoEventTag";

		public const string ParserNoMatchingArray = "ParserNoMatchingArray";

		public const string ParserNoMatchingIDictionary = "ParserNoMatchingIDictionary";

		public const string ParserNoMatchingIList = "ParserNoMatchingIList";

		public const string ParserNoNamespace = "ParserNoNamespace";

		public const string ParserNoPropOnComplexProp = "ParserNoPropOnComplexProp";

		public const string ParserNoResource = "ParserNoResource";

		public const string ParserNoSerializer = "ParserNoSerializer";

		public const string ParserNoSetterChild = "ParserNoSetterChild";

		public const string ParserNotMarkupExtension = "ParserNotMarkupExtension";

		public const string ParserNoType = "ParserNoType";

		public const string ParserNoTypeConv = "ParserNoTypeConv";

		public const string ParserNotMarkedPublic = "ParserNotMarkedPublic";

		public const string ParserNotAllowedInternalType = "ParserNotAllowedInternalType";

		public const string ParserNullReturned = "ParserNullReturned";

		public const string ParserNullPropertyCollection = "ParserNullPropertyCollection";

		public const string ParserOwnerEventMustBePublic = "ParserOwnerEventMustBePublic";

		public const string ParserParentDO = "ParserParentDO";

		public const string ParserPrefixNSProperty = "ParserPrefixNSProperty";

		public const string ParserPrefixNSElement = "ParserPrefixNSElement";

		public const string ParserPropertyCollectionClosed = "ParserPropertyCollectionClosed";

		public const string ParserPropNoValue = "ParserPropNoValue";

		public const string ParserPublicType = "ParserPublicType";

		public const string ParserReadOnlyProp = "ParserReadOnlyProp";

		public const string ParserResourceKeyType = "ParserResourceKeyType";

		public const string ParserSyncOnRoot = "ParserSyncOnRoot";

		public const string ParserTextInvalidInArrayOrDictionary = "ParserTextInvalidInArrayOrDictionary";

		public const string ParserTextInComplexProp = "ParserTextInComplexProp";

		public const string ParserTooManyAssemblies = "ParserTooManyAssemblies";

		public const string ParserUndeclaredNS = "ParserUndeclaredNS";

		public const string ParserUnexpectedEndEle = "ParserUnexpectedEndEle";

		public const string ParserUnexpInBAML = "ParserUnexpInBAML";

		public const string ParserUnknownAttribute = "ParserUnknownAttribute";

		public const string ParserUnknownBaml = "ParserUnknownBaml";

		public const string ParserUnknownDefAttribute = "ParserUnknownDefAttribute";

		public const string ParserUnknownPresentationOptionsAttribute = "ParserUnknownPresentationOptionsAttribute";

		public const string ParserUnknownDefAttributeCompiler = "ParserUnknownDefAttributeCompiler";

		public const string ParserUnknownTag = "ParserUnknownTag";

		public const string ParserUnknownXmlType = "ParserUnknownXmlType";

		public const string ParserWriterNoSeekEnd = "ParserWriterNoSeekEnd";

		public const string ParserWriterUnknownOrigin = "ParserWriterUnknownOrigin";

		public const string ParserXmlReaderNoLineInfo = "ParserXmlReaderNoLineInfo";

		public const string ParserNoNameOnType = "ParserNoNameOnType";

		public const string ParserErrorContext_Type = "ParserErrorContext_Type";

		public const string ParserErrorContext_File = "ParserErrorContext_File";

		public const string ParserErrorContext_Type_File = "ParserErrorContext_Type_File";

		public const string ParserErrorContext_Line = "ParserErrorContext_Line";

		public const string ParserErrorContext_Type_Line = "ParserErrorContext_Type_Line";

		public const string ParserErrorContext_File_Line = "ParserErrorContext_File_Line";

		public const string ParserErrorContext_Type_File_Line = "ParserErrorContext_Type_File_Line";

		public const string ParserCannotConvertInitializationText = "ParserCannotConvertInitializationText";

		public const string ParserCannotConvertPropertyValueString = "ParserCannotConvertPropertyValueString";

		public const string ParserCannotConvertPropertyValue = "ParserCannotConvertPropertyValue";

		public const string ParserCantSetAttribute = "ParserCantSetAttribute";

		public const string ParserCantGetProperty = "ParserCantGetProperty";

		public const string ParserReadOnlyNullProperty = "ParserReadOnlyNullProperty";

		public const string ParserCantSetTriggerCondition = "ParserCantSetTriggerCondition";

		public const string ParserEventDelegateTypeNotAccessible = "ParserEventDelegateTypeNotAccessible";

		public const string ParserCantCreateDelegate = "ParserCantCreateDelegate";

		public const string ParserNoNestedXmlDataIslands = "ParserNoNestedXmlDataIslands";

		public const string ParserXmlIslandUnexpected = "ParserXmlIslandUnexpected";

		public const string ParserXmlIslandMissing = "ParserXmlIslandMissing";

		public const string ParserCantSetContentProperty = "ParserCantSetContentProperty";

		public const string ParserContentMustBeContiguous = "ParserContentMustBeContiguous";

		public const string ParserCanOnlyHaveOneChild = "ParserCanOnlyHaveOneChild";

		public const string ParserProvideValueCantSetUri = "ParserProvideValueCantSetUri";

		public const string ParserTypeConverterTextUnusable = "ParserTypeConverterTextUnusable";

		public const string ParserXmlLangPropertyValueInvalid = "ParserXmlLangPropertyValueInvalid";

		public const string ParserNoNameUnderDefinitionScopeType = "ParserNoNameUnderDefinitionScopeType";

		public const string ParserBadString = "ParserBadString";

		public const string ParserTypeConverterTextNeedsEndElement = "ParserTypeConverterTextNeedsEndElement";

		public const string ParserInvalidStaticMember = "ParserInvalidStaticMember";

		public const string ParserBadMemberReference = "ParserBadMemberReference";

		public const string ParserNoDPOnOwner = "ParserNoDPOnOwner";

		public const string ParserNoPropType = "ParserNoPropType";

		public const string ParserFailedEndInit = "ParserFailedEndInit";

		public const string ParserCannotReuseXamlReader = "ParserCannotReuseXamlReader";

		public const string PositionalArgumentsWrongLength = "PositionalArgumentsWrongLength";

		public const string InvalidDeSerialize = "InvalidDeSerialize";

		public const string InvalidCustomSerialize = "InvalidCustomSerialize";

		public const string MustBeOfType = "MustBeOfType";

		public const string NonWhiteSpaceInAddText = "NonWhiteSpaceInAddText";

		public const string TypeValueSerializerUnavailable = "TypeValueSerializerUnavailable";

		public const string UnserializableKeyValue = "UnserializableKeyValue";

		public const string ValueSerializerContextUnavailable = "ValueSerializerContextUnavailable";

		public const string MarkupWriter_CannotSerializeNonPublictype = "MarkupWriter_CannotSerializeNonPublictype";

		public const string MarkupWriter_CannotSerializeNestedPublictype = "MarkupWriter_CannotSerializeNestedPublictype";

		public const string MarkupWriter_CannotSerializeGenerictype = "MarkupWriter_CannotSerializeGenerictype";

		public const string FilterBindRegionNotImplemented = "FilterBindRegionNotImplemented";

		public const string FilterInitInvalidAttributes = "FilterInitInvalidAttributes";

		public const string FilterGetValueMustBeStringOrDateTime = "FilterGetValueMustBeStringOrDateTime";

		public const string FilterGetValueAlreadyCalledOnCurrentChunk = "FilterGetValueAlreadyCalledOnCurrentChunk";

		public const string FilterGetTextBufferOverflow = "FilterGetTextBufferOverflow";

		public const string FilterGetTextNotSupported = "FilterGetTextNotSupported";

		public const string FilterGetValueNotSupported = "FilterGetValueNotSupported";

		public const string FilterPropSpecUnknownUnionSelector = "FilterPropSpecUnknownUnionSelector";

		public const string FilterGetChunkNoStream = "FilterGetChunkNoStream";

		public const string FileNameNullOrEmpty = "FileNameNullOrEmpty";

		public const string FileToFilterNotLoaded = "FileToFilterNotLoaded";

		public const string FilterLoadInvalidModeFlag = "FilterLoadInvalidModeFlag";

		public const string XamlFilterNestedFixedPage = "XamlFilterNestedFixedPage";

		public const string FilterEndOfChunks = "FilterEndOfChunks";

		public const string FilterNullGetTextBufferPointer = "FilterNullGetTextBufferPointer";

		public const string XmlGlyphRunInfoIsNonGraphic = "XmlGlyphRunInfoIsNonGraphic";

		public const string UnexpectedXmlNodeInXmlFixedPageInfoConstructor = "UnexpectedXmlNodeInXmlFixedPageInfoConstructor";

		public const string StreamDoesNotSupportWrite = "StreamDoesNotSupportWrite";

		public const string FilterIPersistFileIsReadOnly = "FilterIPersistFileIsReadOnly";

		public const string FilterIPersistStreamIsReadOnly = "FilterIPersistStreamIsReadOnly";

		public const string AuxiliaryFilterReturnedAnomalousCountOfCharacters = "AuxiliaryFilterReturnedAnomalousCountOfCharacters";

		public const string CorePropertyEnumeratorPositionedOutOfBounds = "CorePropertyEnumeratorPositionedOutOfBounds";

		public const string CannotSetNegativePosition = "CannotSetNegativePosition";

		public const string AnnotationAdorner_NotUIElement = "AnnotationAdorner_NotUIElement";

		public const string CreateHighlight = "CreateHighlight";

		public const string CreateTextNote = "CreateTextNote";

		public const string CreateInkNote = "CreateInkNote";

		public const string ClearHighlight = "ClearHighlight";

		public const string DeleteNotes = "DeleteNotes";

		public const string DeleteAnnotations = "DeleteAnnotations";

		public const string XmlNodeAlreadyOwned = "XmlNodeAlreadyOwned";

		public const string InvalidGuid = "InvalidGuid";

		public const string TypeNameMustBeSpecified = "TypeNameMustBeSpecified";

		public const string ModificationEarlierThanCreation = "ModificationEarlierThanCreation";

		public const string AlreadyHasParent = "AlreadyHasParent";

		public const string OnlyFlowAndFixedSupported = "OnlyFlowAndFixedSupported";

		public const string RequiredAttributeMissing = "RequiredAttributeMissing";

		public const string InvalidXmlContent = "InvalidXmlContent";

		public const string CannotSerializeInvalidInstance = "CannotSerializeInvalidInstance";

		public const string UnexpectedAttribute = "UnexpectedAttribute";

		public const string InvalidAttributeValue = "InvalidAttributeValue";

		public const string AnnotationAlreadyExists = "AnnotationAlreadyExists";

		public const string CannotParseId = "CannotParseId";

		public const string StreamNotSet = "StreamNotSet";

		public const string ObjectDisposed_StoreClosed = "ObjectDisposed_StoreClosed";

		public const string StreamCannotBeWritten = "StreamCannotBeWritten";

		public const string SeekNegative = "SeekNegative";

		public const string NullUri = "NullUri";

		public const string DuplicatedUri = "DuplicatedUri";

		public const string DuplicatedCompatibleUri = "DuplicatedCompatibleUri";

		public const string InvalidNamespace = "InvalidNamespace";

		public const string StreamDoesNotSupportSeek = "StreamDoesNotSupportSeek";

		public const string TextSegmentsMustNotOverlap = "TextSegmentsMustNotOverlap";

		public const string SelectionMustBeServiceProvider = "SelectionMustBeServiceProvider";

		public const string IncorrectLocatorPartType = "IncorrectLocatorPartType";

		public const string InvalidLocatorPart = "InvalidLocatorPart";

		public const string InvalidSubTreeProcessor = "InvalidSubTreeProcessor";

		public const string NoProcessorForSelectionType = "NoProcessorForSelectionType";

		public const string WrongSelectionType = "WrongSelectionType";

		public const string StartNodeMustBeDocumentPageViewOrFixedPage = "StartNodeMustBeDocumentPageViewOrFixedPage";

		public const string StartNodeMustBeFixedPageProxy = "StartNodeMustBeFixedPageProxy";

		public const string SelectionDoesNotResolveToAPage = "SelectionDoesNotResolveToAPage";

		public const string IncorrectAnchorLength = "IncorrectAnchorLength";

		public const string InvalidStartNodeForTextSelection = "InvalidStartNodeForTextSelection";

		public const string AnnotationServiceNotEnabled = "AnnotationServiceNotEnabled";

		public const string AnnotationServiceIsAlreadyEnabled = "AnnotationServiceIsAlreadyEnabled";

		public const string AnnotationAlreadyExistInService = "AnnotationAlreadyExistInService";

		public const string ParameterMustBeLogicalNode = "ParameterMustBeLogicalNode";

		public const string OnlyFlowFixedSupported = "OnlyFlowFixedSupported";

		public const string AnnotationServiceAlreadyExists = "AnnotationServiceAlreadyExists";

		public const string EmptySelectionNotSupported = "EmptySelectionNotSupported";

		public const string InvalidHighlightColor = "InvalidHighlightColor";

		public const string InvalidSelectionPages = "InvalidSelectionPages";

		public const string NotHighlightAnnotationType = "NotHighlightAnnotationType";

		public const string ComponentNotInPresentationContext = "ComponentNotInPresentationContext";

		public const string ComponentAlreadyInPresentationContext = "ComponentAlreadyInPresentationContext";

		public const string NoPresentationContextForGivenElement = "NoPresentationContextForGivenElement";

		public const string MoreThanOneAttachedAnnotation = "MoreThanOneAttachedAnnotation";

		public const string InvalidAttachedAnnotation = "InvalidAttachedAnnotation";

		public const string MissingAnnotationHighlightLayer = "MissingAnnotationHighlightLayer";

		public const string NoAttachedAnnotationToModify = "NoAttachedAnnotationToModify";

		public const string InvalidAttachedAnchor = "InvalidAttachedAnchor";

		public const string InvalidValueSpecified = "InvalidValueSpecified";

		public const string UndefinedHighlightAnchor = "UndefinedHighlightAnchor";

		public const string UndoNotInNormalState = "UndoNotInNormalState";

		public const string UndoUnitAlreadyOpen = "UndoUnitAlreadyOpen";

		public const string UndoUnitNotOnTopOfStack = "UndoUnitNotOnTopOfStack";

		public const string UndoContainerTypeMismatch = "UndoContainerTypeMismatch";

		public const string UndoUnitCantBeOpenedTwice = "UndoUnitCantBeOpenedTwice";

		public const string UndoUnitCantBeAddedTwice = "UndoUnitCantBeAddedTwice";

		public const string UndoServiceDisabled = "UndoServiceDisabled";

		public const string UndoUnitLocked = "UndoUnitLocked";

		public const string UndoNoOpenUnit = "UndoNoOpenUnit";

		public const string UndoNoOpenParentUnit = "UndoNoOpenParentUnit";

		public const string UndoUnitNotFound = "UndoUnitNotFound";

		public const string UndoManagerAlreadyAttached = "UndoManagerAlreadyAttached";

		public const string UndoUnitOpen = "UndoUnitOpen";

		public const string TextBoxBase_CantSetIsUndoEnabledInsideChangeBlock = "TextBoxBase_CantSetIsUndoEnabledInsideChangeBlock";

		public const string TextBoxBase_UnmatchedEndChange = "TextBoxBase_UnmatchedEndChange";

		public const string TextBoxInvalidTextContainer = "TextBoxInvalidTextContainer";

		public const string TextBoxScrollViewerMarkedAsTextBoxContentMustHaveNoContent = "TextBoxScrollViewerMarkedAsTextBoxContentMustHaveNoContent";

		public const string TextBoxDecoratorMarkedAsTextBoxContentMustHaveNoContent = "TextBoxDecoratorMarkedAsTextBoxContentMustHaveNoContent";

		public const string TextBoxMinMaxLinesMismatch = "TextBoxMinMaxLinesMismatch";

		public const string TextBoxInvalidChild = "TextBoxInvalidChild";

		public const string RichTextBox_DocumentBelongsToAnotherRichTextBoxAlready = "RichTextBox_DocumentBelongsToAnotherRichTextBoxAlready";

		public const string RichTextBox_PointerNotInSameDocument = "RichTextBox_PointerNotInSameDocument";

		public const string RichTextBox_CantSetDocumentInsideChangeBlock = "RichTextBox_CantSetDocumentInsideChangeBlock";

		public const string PasswordBoxInvalidTextContainer = "PasswordBoxInvalidTextContainer";

		public const string TextEditorCanNotRegisterCommandHandler = "TextEditorCanNotRegisterCommandHandler";

		public const string TextEditorPropertyIsNotApplicableForTextFormatting = "TextEditorPropertyIsNotApplicableForTextFormatting";

		public const string TextEditorTypeOfParameterIsNotAppropriateForFormattingProperty = "TextEditorTypeOfParameterIsNotAppropriateForFormattingProperty";

		public const string TextEditorCopyPaste_EntryPartIsMissingInXamlPackage = "TextEditorCopyPaste_EntryPartIsMissingInXamlPackage";

		public const string TextEditorSpellerInteropHasBeenDisposed = "TextEditorSpellerInteropHasBeenDisposed";

		public const string CustomDictionarySourcesUnsupportedURI = "CustomDictionarySourcesUnsupportedURI";

		public const string CustomDictionaryFailedToLoadDictionaryUri = "CustomDictionaryFailedToLoadDictionaryUri";

		public const string CustomDictionaryFailedToUnLoadDictionaryUri = "CustomDictionaryFailedToUnLoadDictionaryUri";

		public const string CustomDictionaryNullItem = "CustomDictionaryNullItem";

		public const string CustomDictionaryItemAlreadyExists = "CustomDictionaryItemAlreadyExists";

		public const string SetLengthNotSupported = "SetLengthNotSupported";

		public const string ReadCountNegative = "ReadCountNegative";

		public const string WriteNotSupported = "WriteNotSupported";

		public const string AdornedElementNotFound = "AdornedElementNotFound";

		public const string AdornerNotFound = "AdornerNotFound";

		public const string ItemsSourceInUse = "ItemsSourceInUse";

		public const string CannotUseItemsSource = "CannotUseItemsSource";

		public const string ItemCollectionRemoveArgumentOutOfRange = "ItemCollectionRemoveArgumentOutOfRange";

		public const string ItemCollectionShouldUseInnerSyncRoot = "ItemCollectionShouldUseInnerSyncRoot";

		public const string ItemCollectionHasNoCollection = "ItemCollectionHasNoCollection";

		public const string MoreThanOneStartingParts = "MoreThanOneStartingParts";

		public const string CollectionAddEventMissingItem = "CollectionAddEventMissingItem";

		public const string CannotRecyleHeterogeneousTypes = "CannotRecyleHeterogeneousTypes";

		public const string Generator_Readme0 = "Generator_Readme0";

		public const string Generator_Readme1 = "Generator_Readme1";

		public const string Generator_Readme2 = "Generator_Readme2";

		public const string Generator_Readme3 = "Generator_Readme3";

		public const string Generator_Readme4 = "Generator_Readme4";

		public const string Generator_Readme5 = "Generator_Readme5";

		public const string Generator_Readme6 = "Generator_Readme6";

		public const string Generator_Readme7 = "Generator_Readme7";

		public const string Generator_Readme8 = "Generator_Readme8";

		public const string Generator_Readme9 = "Generator_Readme9";

		public const string Generator_CountIsWrong = "Generator_CountIsWrong";

		public const string Generator_ItemIsWrong = "Generator_ItemIsWrong";

		public const string Generator_MoreErrors = "Generator_MoreErrors";

		public const string Generator_Unnamed = "Generator_Unnamed";

		public const string Generator_Inconsistent = "Generator_Inconsistent";

		public const string CollectionView_NameTypeDuplicity = "CollectionView_NameTypeDuplicity";

		public const string CollectionView_ViewTypeInsufficient = "CollectionView_ViewTypeInsufficient";

		public const string CollectionView_WrongType = "CollectionView_WrongType";

		public const string CollectionView_MissingSynchronizationCallback = "CollectionView_MissingSynchronizationCallback";

		public const string AccessCollectionAfterShutDown = "AccessCollectionAfterShutDown";

		public const string ListView_IllegalChildrenType = "ListView_IllegalChildrenType";

		public const string ListView_NotAllowShareColumnToTwoColumnCollection = "ListView_NotAllowShareColumnToTwoColumnCollection";

		public const string ListView_GridViewColumnCollectionIsReadOnly = "ListView_GridViewColumnCollectionIsReadOnly";

		public const string ListView_ViewCannotBeShared = "ListView_ViewCannotBeShared";

		public const string ListView_MissingParameterlessConstructor = "ListView_MissingParameterlessConstructor";

		public const string DataGridCellItemAutomationPeer_NameCoreFormat = "DataGridCellItemAutomationPeer_NameCoreFormat";

		public const string DataGridColumnHeaderItemAutomationPeer_NameCoreFormat = "DataGridColumnHeaderItemAutomationPeer_NameCoreFormat";

		public const string DataGridColumnHeaderItemAutomationPeer_Unsupported = "DataGridColumnHeaderItemAutomationPeer_Unsupported";

		public const string DataGridColumnHeaderItemAutomationPeer_Unresizable = "DataGridColumnHeaderItemAutomationPeer_Unresizable";

		public const string CalendarAutomationPeer_CalendarButtonLocalizedControlType = "CalendarAutomationPeer_CalendarButtonLocalizedControlType";

		public const string CalendarAutomationPeer_DayButtonLocalizedControlType = "CalendarAutomationPeer_DayButtonLocalizedControlType";

		public const string CalendarAutomationPeer_BlackoutDayHelpText = "CalendarAutomationPeer_BlackoutDayHelpText";

		public const string Calendar_NextButtonName = "Calendar_NextButtonName";

		public const string Calendar_PreviousButtonName = "Calendar_PreviousButtonName";

		public const string DatePickerAutomationPeer_LocalizedControlType = "DatePickerAutomationPeer_LocalizedControlType";

		public const string DatePickerTextBox_DefaultWatermarkText = "DatePickerTextBox_DefaultWatermarkText";

		public const string DatePicker_DropDownButtonName = "DatePicker_DropDownButtonName";

		public const string DatePicker_WatermarkText = "DatePicker_WatermarkText";

		public const string DataGrid_ColumnIndexOutOfRange = "DataGrid_ColumnIndexOutOfRange";

		public const string DataGrid_ColumnDisplayIndexOutOfRange = "DataGrid_ColumnDisplayIndexOutOfRange";

		public const string DataGrid_DisplayIndexOutOfRange = "DataGrid_DisplayIndexOutOfRange";

		public const string DataGrid_InvalidColumnReuse = "DataGrid_InvalidColumnReuse";

		public const string DataGrid_DuplicateDisplayIndex = "DataGrid_DuplicateDisplayIndex";

		public const string DataGrid_NewColumnInvalidDisplayIndex = "DataGrid_NewColumnInvalidDisplayIndex";

		public const string DataGrid_NullColumn = "DataGrid_NullColumn";

		public const string DataGrid_ReadonlyCellsItemsSource = "DataGrid_ReadonlyCellsItemsSource";

		public const string DataGrid_InvalidSortDescription = "DataGrid_InvalidSortDescription";

		public const string DataGrid_ProbableInvalidSortDescription = "DataGrid_ProbableInvalidSortDescription";

		public const string DataGrid_AutomationInvokeFailed = "DataGrid_AutomationInvokeFailed";

		public const string DataGrid_ColumnIsReadOnly = "DataGrid_ColumnIsReadOnly";

		public const string DataGridLength_InvalidType = "DataGridLength_InvalidType";

		public const string DataGridLength_Infinity = "DataGridLength_Infinity";

		public const string DataGrid_CannotSelectCell = "DataGrid_CannotSelectCell";

		public const string DataGridRow_CannotSelectRowWhenCells = "DataGridRow_CannotSelectRowWhenCells";

		public const string SelectedCellsCollection_InvalidItem = "SelectedCellsCollection_InvalidItem";

		public const string SelectedCellsCollection_DuplicateItem = "SelectedCellsCollection_DuplicateItem";

		public const string VirtualizedCellInfoCollection_IsReadOnly = "VirtualizedCellInfoCollection_IsReadOnly";

		public const string VirtualizedCellInfoCollection_DoesNotSupportIndexChanges = "VirtualizedCellInfoCollection_DoesNotSupportIndexChanges";

		public const string ClipboardCopyMode_Disabled = "ClipboardCopyMode_Disabled";

		public const string Calendar_OnDisplayModePropertyChanged_InvalidValue = "Calendar_OnDisplayModePropertyChanged_InvalidValue";

		public const string Calendar_OnFirstDayOfWeekChanged_InvalidValue = "Calendar_OnFirstDayOfWeekChanged_InvalidValue";

		public const string Calendar_OnSelectedDateChanged_InvalidValue = "Calendar_OnSelectedDateChanged_InvalidValue";

		public const string Calendar_OnSelectedDateChanged_InvalidOperation = "Calendar_OnSelectedDateChanged_InvalidOperation";

		public const string CalendarCollection_MultiThreadedCollectionChangeNotSupported = "CalendarCollection_MultiThreadedCollectionChangeNotSupported";

		public const string Calendar_CheckSelectionMode_InvalidOperation = "Calendar_CheckSelectionMode_InvalidOperation";

		public const string Calendar_OnSelectionModeChanged_InvalidValue = "Calendar_OnSelectionModeChanged_InvalidValue";

		public const string Calendar_UnSelectableDates = "Calendar_UnSelectableDates";

		public const string DatePickerTextBox_TemplatePartIsOfIncorrectType = "DatePickerTextBox_TemplatePartIsOfIncorrectType";

		public const string DatePicker_OnSelectedDateFormatChanged_InvalidValue = "DatePicker_OnSelectedDateFormatChanged_InvalidValue";

		public const string CalendarAutomationPeer_MonthMode = "CalendarAutomationPeer_MonthMode";

		public const string CalendarAutomationPeer_YearMode = "CalendarAutomationPeer_YearMode";

		public const string CalendarAutomationPeer_DecadeMode = "CalendarAutomationPeer_DecadeMode";

		public const string CalendarNamePropertyValueNotValid = "CalendarNamePropertyValueNotValid";

		public const string SetFocusFailed = "SetFocusFailed";

		public const string PropertyNotSupported = "PropertyNotSupported";

		public const string InavalidStartItem = "InavalidStartItem";

		public const string VirtualizedElement = "VirtualizedElement";

		public const string UIA_OperationCannotBePerformed = "UIA_OperationCannotBePerformed";

		public const string TextProvider_InvalidPoint = "TextProvider_InvalidPoint";

		public const string TextProvider_InvalidChildElement = "TextProvider_InvalidChildElement";

		public const string TextProvider_TextSelectionNotSupported = "TextProvider_TextSelectionNotSupported";

		public const string TextRangeProvider_WrongTextRange = "TextRangeProvider_WrongTextRange";

		public const string TextRangeProvider_InvalidParameterValue = "TextRangeProvider_InvalidParameterValue";

		public const string TextRangeProvider_EmptyStringParameter = "TextRangeProvider_EmptyStringParameter";

		public const string TextViewInvalidLayout = "TextViewInvalidLayout";

		public const string ThemeDictionaryExtension_Name = "ThemeDictionaryExtension_Name";

		public const string ThemeDictionaryExtension_Source = "ThemeDictionaryExtension_Source";

		public const string ProgressBarReadOnly = "ProgressBarReadOnly";

		public const string CantShowModalOnNonInteractive = "CantShowModalOnNonInteractive";

		public const string FileDialogInvalidFilter = "FileDialogInvalidFilter";

		public const string FileDialogInvalidFilterIndex = "FileDialogInvalidFilterIndex";

		public const string FileDialogSubClassFailure = "FileDialogSubClassFailure";

		public const string FileNameMustNotBeNull = "FileNameMustNotBeNull";

		public const string CantShowOnDifferentThread = "CantShowOnDifferentThread";

		public const string ResourceDictionaryIsReadOnly = "ResourceDictionaryIsReadOnly";

		public const string StaticResourceInXamlOnly = "StaticResourceInXamlOnly";

		public const string ResourceDictionaryInvalidMergedDictionary = "ResourceDictionaryInvalidMergedDictionary";

		public const string IntegerCollectionLengthLessThanZero = "IntegerCollectionLengthLessThanZero";

		public const string UnknownIndexType = "UnknownIndexType";

		public const string CantSwitchVirtualizationModePostMeasure = "CantSwitchVirtualizationModePostMeasure";

		public const string PageCacheSizeNotAllowed = "PageCacheSizeNotAllowed";

		public const string Untitled = "Untitled";

		public const string LengthFormatError = "LengthFormatError";

		public const string HostedWindowMustBeAChildWindow = "HostedWindowMustBeAChildWindow";

		public const string ChildWindowNotCreated = "ChildWindowNotCreated";

		public const string ChildWindowMustHaveCorrectParent = "ChildWindowMustHaveCorrectParent";

		public const string HwndHostDoesNotSupportChildKeyboardSinks = "HwndHostDoesNotSupportChildKeyboardSinks";

		public const string DesignerMetadata_CustomCategory_Accessibility = "DesignerMetadata_CustomCategory_Accessibility";

		public const string DesignerMetadata_CustomCategory_Content = "DesignerMetadata_CustomCategory_Content";

		public const string DesignerMetadata_CustomCategory_Navigation = "DesignerMetadata_CustomCategory_Navigation";

		public const string ToStringFormatString_Control = "ToStringFormatString_Control";

		public const string ToStringFormatString_ToggleButton = "ToStringFormatString_ToggleButton";

		public const string ToStringFormatString_ItemsControl = "ToStringFormatString_ItemsControl";

		public const string ToStringFormatString_HeaderedContentControl = "ToStringFormatString_HeaderedContentControl";

		public const string ToStringFormatString_HeaderedItemsControl = "ToStringFormatString_HeaderedItemsControl";

		public const string ToStringFormatString_RangeBase = "ToStringFormatString_RangeBase";

		public const string ToStringFormatString_GridView = "ToStringFormatString_GridView";

		public const string ToStringFormatString_GridViewColumn = "ToStringFormatString_GridViewColumn";

		public const string ToStringFormatString_GridViewRowPresenterBase = "ToStringFormatString_GridViewRowPresenterBase";

		public const string ToStringFormatString_GridViewRowPresenter = "ToStringFormatString_GridViewRowPresenter";

		public const string TextBox_ContextMenu_Cut = "TextBox_ContextMenu_Cut";

		public const string TextBox_ContextMenu_Copy = "TextBox_ContextMenu_Copy";

		public const string TextBox_ContextMenu_Paste = "TextBox_ContextMenu_Paste";

		public const string TextBox_ContextMenu_NoSpellingSuggestions = "TextBox_ContextMenu_NoSpellingSuggestions";

		public const string TextBox_ContextMenu_IgnoreAll = "TextBox_ContextMenu_IgnoreAll";

		public const string TextBox_ContextMenu_More = "TextBox_ContextMenu_More";

		public const string TextBox_ContextMenu_Description_SBCSSpace = "TextBox_ContextMenu_Description_SBCSSpace";

		public const string TextBox_ContextMenu_Description_DBCSSpace = "TextBox_ContextMenu_Description_DBCSSpace";

		public const string DocumentViewerSearchDownCompleteLabel = "DocumentViewerSearchDownCompleteLabel";

		public const string DocumentViewerSearchUpCompleteLabel = "DocumentViewerSearchUpCompleteLabel";

		public const string DocumentViewerSearchCompleteTitle = "DocumentViewerSearchCompleteTitle";

		public const string DocumentViewerViewThumbnailsCommandText = "DocumentViewerViewThumbnailsCommandText";

		public const string DocumentViewerViewFitToWidthCommandText = "DocumentViewerViewFitToWidthCommandText";

		public const string DocumentViewerViewFitToHeightCommandText = "DocumentViewerViewFitToHeightCommandText";

		public const string DocumentViewerViewFitToMaxPagesAcrossCommandText = "DocumentViewerViewFitToMaxPagesAcrossCommandText";

		public const string FlowDocumentReader_MultipleViewProvider_PageViewName = "FlowDocumentReader_MultipleViewProvider_PageViewName";

		public const string FlowDocumentReader_MultipleViewProvider_TwoPageViewName = "FlowDocumentReader_MultipleViewProvider_TwoPageViewName";

		public const string FlowDocumentReader_MultipleViewProvider_ScrollViewName = "FlowDocumentReader_MultipleViewProvider_ScrollViewName";

		public const string FileDialogBufferTooSmall = "FileDialogBufferTooSmall";

		public const string FileDialogCreatePrompt = "FileDialogCreatePrompt";

		public const string FileDialogFileNotFound = "FileDialogFileNotFound";

		public const string FileDialogInvalidFileName = "FileDialogInvalidFileName";

		public const string FileDialogOverwritePrompt = "FileDialogOverwritePrompt";

		public const string NavWindowMenuCurrentPage = "NavWindowMenuCurrentPage";

		public const string InvalidStartOfBaml = "InvalidStartOfBaml";

		public const string UnRecognizedBamlNodeType = "UnRecognizedBamlNodeType";

		public const string InvalidEndOfBaml = "InvalidEndOfBaml";

		public const string NullParentNode = "NullParentNode";

		public const string BamlTypeIdNotFound = "BamlTypeIdNotFound";

		public const string BamlAssemblyIdNotFound = "BamlAssemblyIdNotFound";

		public const string InvalidLocCommentTarget = "InvalidLocCommentTarget";

		public const string InvalidLocCommentValue = "InvalidLocCommentValue";

		public const string UnmatchedLocComment = "UnmatchedLocComment";

		public const string InvalidLocalizabilityValue = "InvalidLocalizabilityValue";

		public const string InvalidTempFileName = "InvalidTempFileName";

		public const string InvalidByteRanges = "InvalidByteRanges";

		public const string ByteRangeDownloaderNotInitialized = "ByteRangeDownloaderNotInitialized";

		public const string InvalidEventHandle = "InvalidEventHandle";

		public const string CannotProcessInkCommand = "CannotProcessInkCommand";

		public const string InvalidStickyNoteTemplate = "InvalidStickyNoteTemplate";

		public const string InvalidInkForeground = "InvalidInkForeground";

		public const string AddAnnotationsNotImplemented = "AddAnnotationsNotImplemented";

		public const string AnnotationIsNull = "AnnotationIsNull";

		public const string NotSupported = "NotSupported";

		public const string InvalidAnchorPosition = "InvalidAnchorPosition";

		public const string InvalidStickyNoteAnnotation = "InvalidStickyNoteAnnotation";

		public const string MaximumNoteSizeExceeded = "MaximumNoteSizeExceeded";

		public const string InvalidEmptyStrokeCollection = "InvalidEmptyStrokeCollection";

		public const string InvalidEmptyArray = "InvalidEmptyArray";

		public const string InvalidClipboardFormat = "InvalidClipboardFormat";

		public const string InvalidPoint = "InvalidPoint";

		public const string InkCanvasDeselectKey = "InkCanvasDeselectKey";

		public const string InkCanvasDeselectKeyDisplayString = "InkCanvasDeselectKeyDisplayString";

		public const string InvalidDiameter = "InvalidDiameter";

		public const string HostingStatusDownloadAppInfo = "HostingStatusDownloadAppInfo";

		public const string HostingStatusVerifying = "HostingStatusVerifying";

		public const string HostingStatusDownloadApp = "HostingStatusDownloadApp";

		public const string HostingStatusFailed = "HostingStatusFailed";

		public const string HostingStatusCancelled = "HostingStatusCancelled";

		public const string HostingStatusPreparingToRun = "HostingStatusPreparingToRun";

		public const string CancelledTitle = "CancelledTitle";

		public const string CancelledText = "CancelledText";

		public const string InvalidDeployTitle = "InvalidDeployTitle";

		public const string InvalidDeployText = "InvalidDeployText";

		public const string PlatformRequirementTitle = "PlatformRequirementTitle";

		public const string TrustNotGrantedTitle = "TrustNotGrantedTitle";

		public const string TrustNotGrantedText = "TrustNotGrantedText";

		public const string DeployTitle = "DeployTitle";

		public const string DeployText = "DeployText";

		public const string DownloadTitle = "DownloadTitle";

		public const string DownloadText = "DownloadText";

		public const string UnknownErrorTitle = "UnknownErrorTitle";

		public const string UnknownErrorText = "UnknownErrorText";

		public const string IncompatibleWinFXText = "IncompatibleWinFXText";

		public const string IncompatibleCLRText = "IncompatibleCLRText";

		public const string SetPositionNotSupported = "SetPositionNotSupported";

		public const string SeekFailed = "SeekFailed";

		public const string SeekNotSupported = "SeekNotSupported";

		public const string ReadNotSupported = "ReadNotSupported";

		public const string BufferOffsetNegative = "BufferOffsetNegative";

		public const string BufferTooSmall = "BufferTooSmall";

		public const string StreamObjectDisposed = "StreamObjectDisposed";

		public const string PrintDialogPageRange = "PrintDialogPageRange";

		public const string PrintDialogZeroNotAllowed = "PrintDialogZeroNotAllowed";

		public const string PrintDialogInvalidPageRange = "PrintDialogInvalidPageRange";

		public const string PartialTrustPrintDialogMustBeInvoked = "PartialTrustPrintDialogMustBeInvoked";

		public const string PrintDialogInstallPrintSupportCaption = "PrintDialogInstallPrintSupportCaption";

		public const string PrintDialogInstallPrintSupportMessageBox = "PrintDialogInstallPrintSupportMessageBox";

		public const string MediaElement_CannotSetSourceOnMediaElementDrivenByClock = "MediaElement_CannotSetSourceOnMediaElementDrivenByClock";

		public const string UnexpectedType = "UnexpectedType";

		public const string UnexpectedProperty = "UnexpectedProperty";

		public const string ArgumentLengthMismatch = "ArgumentLengthMismatch";

		public const string AttachablePropertyNotFound = "AttachablePropertyNotFound";

		public const string PropertyNotFound = "PropertyNotFound";

		public const string PropertyFoundOutsideStartElement = "PropertyFoundOutsideStartElement";

		public const string PropertyOutOfOrder = "PropertyOutOfOrder";

		public const string MissingTagInNamespace = "MissingTagInNamespace";

		public const string AssemblyTagMissing = "AssemblyTagMissing";

		public const string UnableToConvertInt32 = "UnableToConvertInt32";

		public const string MultipleAssemblyMatches = "MultipleAssemblyMatches";

		public const string AssemblyIdOutOfSequence = "AssemblyIdOutOfSequence";

		public const string TypeIdOutOfSequence = "TypeIdOutOfSequence";

		public const string PropertyIdOutOfSequence = "PropertyIdOutOfSequence";

		public const string StringIdOutOfSequence = "StringIdOutOfSequence";

		public const string RecordOutOfOrder = "RecordOutOfOrder";

		public const string UnknownBamlRecord = "UnknownBamlRecord";

		public const string ValueMustBeXamlReader = "ValueMustBeXamlReader";

		public const string ExpectedBinaryContent = "ExpectedBinaryContent";

		public const string DeferringLoaderNoContext = "DeferringLoaderNoContext";

		public const string ExpectedBamlSchemaContext = "ExpectedBamlSchemaContext";

		public const string ExpectedResourceDictionaryTarget = "ExpectedResourceDictionaryTarget";

		public const string DeferringLoaderNoSave = "DeferringLoaderNoSave";

		public const string MarkupExtensionBadStatic = "MarkupExtensionBadStatic";

		public const string MarkupExtensionStaticMember = "MarkupExtensionStaticMember";

		public const string JumpList_CantNestBeginInitCalls = "JumpList_CantNestBeginInitCalls";

		public const string JumpList_CantCallUnbalancedEndInit = "JumpList_CantCallUnbalancedEndInit";

		public const string JumpList_CantApplyUntilEndInit = "JumpList_CantApplyUntilEndInit";

		public const string JumpItemsRejectedEventArgs_CountMismatch = "JumpItemsRejectedEventArgs_CountMismatch";

		public const string RuntimeTypeRequired = "RuntimeTypeRequired";

		public const string AssemblyIdNegative = "AssemblyIdNegative";

		public const string KnownTypeIdNegative = "KnownTypeIdNegative";

		public const string MissingTriggerProperty = "MissingTriggerProperty";

		public const string SharedAttributeInLooseXaml = "SharedAttributeInLooseXaml";
	}
}
