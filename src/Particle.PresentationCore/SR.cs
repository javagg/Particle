using System.Resources;
using System.Runtime.InteropServices;

namespace MS.Internal.PresentationCore
{
    internal static class SR
    {
        internal static string Get(string id) => "";

        internal static string Get(string id, params object[] args) => "";

        internal static ResourceManager ResourceManager => null;
    }
}

namespace MS.Internal.PresentationCore
{
    [StructLayout(LayoutKind.Sequential, Size = 1)]
    internal struct SRID
    {
        
        public const string UsesPerPixelOpacityIsObsolete = "";
        public const string FamilyCollection_CannotFindCompositeFontsLocation = "";

        public const string Automation_InvalidSynchronizedInputType = "";
        

        public const string Effect_Shader30SamplerRegisterLimit = "";
        public const string Effect_Shader20SamplerRegisterLimit = "";
        public const string Effect_Shader30BoolConstantRegisterLimit = "";
        public const string Effect_Shader30IntConstantRegisterLimit = "";
        public const string Effect_20ShaderUsing30Registers = "";
        public const string Viewport2DVisual3D_MultipleInteractiveMaterials = "";
        public const string Viewport2DVisual3D_MaterialGroupIsInteractiveMaterial = "";
        public const string Effect_Shader20ConstantRegisterLimit = "";
        public const string Effect_Shader30FloatConstantRegisterLimit = "";

        
        
           
           
           
        
        
            
        
        public const string Manipulation_InvalidManipulationMode = "Manipulation_ManipulationNotActive";
        public const string CompatibilityPreferencesSealed = "Manipulation_ManipulationNotActive";

        public const string BitmapCacheBrush_OpacityChanged = "Manipulation_ManipulationNotActive";
        public const string BitmapCacheBrush_TransformChanged = "Manipulation_ManipulationNotActive";
        public const string BitmapCacheBrush_RelativeTransformChanged = "Manipulation_ManipulationNotActive";


        
            
        
        public const string Manipulation_ManipulationNotActive = "Manipulation_ManipulationNotActive";
        public const string Touch_DeviceNotActivated = "";
        public const string Touch_DeviceAlreadyActivated = "";
        public const string Freezable_UnexpectedChange = "";
        public const string Freezable_Reentrant = "";

        public const string Manipulation_ManipulationNotEnabled = "";
        public const string Touch_Category = "Touch_Category";
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

        public const string SecurityExceptionForSettingSandboxExternalToTrue = "SecurityExceptionForSettingSandboxExternalToTrue";

        public const string FileFormatException = "FileFormatException";

        public const string FileFormatExceptionWithFileName = "FileFormatExceptionWithFileName";

        public const string TypeMetadataCannotChangeAfterUse = "TypeMetadataCannotChangeAfterUse";

        public const string Visual_ArgumentOutOfRange = "Visual_ArgumentOutOfRange";

        public const string HwndSourceDisposed = "HwndSourceDisposed";

        public const string NullHwnd = "NullHwnd";

        public const string ParameterMustBeGreaterThanZero = "ParameterMustBeGreaterThanZero";

        public const string ParameterCannotBeLessThan = "ParameterCannotBeLessThan";

        public const string ParameterCannotBeGreaterThan = "ParameterCannotBeGreaterThan";

        public const string ParameterMustBeBetween = "ParameterMustBeBetween";

        public const string ParameterValueCannotBeInfinity = "ParameterValueCannotBeInfinity";

        public const string ParameterValueCannotBeNegative = "ParameterValueCannotBeNegative";

        public const string General_BadType = "General_BadType";

        public const string General_Expected_Type = "General_Expected_Type";

        public const string General_ObjectIsReadOnly = "General_ObjectIsReadOnly";

        public const string CollectionNumberOfElementsShouldBeEqualTo = "CollectionNumberOfElementsShouldBeEqualTo";

        public const string CollectionNumberOfElementsMustBeGreaterThanZero = "CollectionNumberOfElementsMustBeGreaterThanZero";

        public const string CollectionIsFixedSize = "CollectionIsFixedSize";

        public const string CollectionDuplicateKey = "CollectionDuplicateKey";

        public const string Enumerator_CollectionChanged = "Enumerator_CollectionChanged";

        public const string Enumerator_NotStarted = "Enumerator_NotStarted";

        public const string Enumerator_ReachedEnd = "Enumerator_ReachedEnd";

        public const string Rect_Empty = "Rect_Empty";

        public const string KeyboardSinkNotAChild = "KeyboardSinkNotAChild";

        public const string KeyboardSinkAlreadyOwned = "KeyboardSinkAlreadyOwned";

        public const string KeyboardSinkMustBeAnElement = "KeyboardSinkMustBeAnElement";

        public const string OnlyAcceptsKeyMessages = "OnlyAcceptsKeyMessages";

        public const string InvalidCursorType = "InvalidCursorType";

        public const string Cursor_LoadImageFailure = "Cursor_LoadImageFailure";

        public const string Cursor_UnsupportedFormat = "Cursor_UnsupportedFormat";

        public const string Cursor_InvalidStream = "Cursor_InvalidStream";

        public const string NotAllowedToAccessStagingArea = "NotAllowedToAccessStagingArea";

        public const string Invalid_IInputElement = "Invalid_IInputElement";

        public const string RequiresSTA = "RequiresSTA";

        public const string InputProviderSiteDisposed = "InputProviderSiteDisposed";

        public const string Penservice_Disposed = "Penservice_Disposed";

        public const string PenService_InvalidPacketData = "PenService_InvalidPacketData";

        public const string PenService_WindowAlreadyRegistered = "PenService_WindowAlreadyRegistered";

        public const string PenService_WindowNotRegistered = "PenService_WindowNotRegistered";

        public const string Stylus_InvalidMax = "Stylus_InvalidMax";

        public const string Stylus_IndexOutOfRange = "Stylus_IndexOutOfRange";

        public const string Stylus_MatrixNotInvertable = "Stylus_MatrixNotInvertable";

        public const string Stylus_PenContextFailure = "Stylus_PenContextFailure";

        public const string Stylus_EnumeratorFailure = "Stylus_EnumeratorFailure";

        public const string Stylus_PlugInIsNull = "Stylus_PlugInIsNull";

        public const string Stylus_PlugInIsDuplicated = "Stylus_PlugInIsDuplicated";

        public const string Stylus_PlugInNotExist = "Stylus_PlugInNotExist";

        public const string Stylus_CanOnlyCallForDownMoveOrUp = "Stylus_CanOnlyCallForDownMoveOrUp";

        public const string Stylus_StylusPointsCantBeEmpty = "Stylus_StylusPointsCantBeEmpty";

        public const string Stylus_MustBeDownToCallReset = "Stylus_MustBeDownToCallReset";

        public const string UnknownPathOperationType = "UnknownPathOperationType";

        public const string UIElement_Layout_PositiveInfinityReturned = "UIElement_Layout_PositiveInfinityReturned";

        public const string UIElement_Layout_NaNReturned = "UIElement_Layout_NaNReturned";

        public const string UIElement_Layout_InfinityArrange = "UIElement_Layout_InfinityArrange";

        public const string UIElement_Layout_NaNMeasure = "UIElement_Layout_NaNMeasure";

        public const string LayoutManager_DeepRecursion = "LayoutManager_DeepRecursion";

        public const string CreateContextFailure = "CreateContextFailure";

        public const string CreateLineFailure = "CreateLineFailure";

        public const string CreateParaBreakingSessionFailure = "CreateParaBreakingSessionFailure";

        public const string CreateBreaksFailure = "CreateBreaksFailure";

        public const string EnumLineFailure = "EnumLineFailure";

        public const string SetDocFailure = "SetDocFailure";

        public const string SetTabsFailure = "SetTabsFailure";

        public const string SetBreakingFailure = "SetBreakingFailure";

        public const string QueryLineFailure = "QueryLineFailure";

        public const string NonCLSException = "NonCLSException";

        public const string AcquireBreakRecordFailure = "AcquireBreakRecordFailure";

        public const string AcquirePenaltyModuleFailure = "AcquirePenaltyModuleFailure";

        public const string CloneBreakRecordFailure = "CloneBreakRecordFailure";

        public const string RelievePenaltyResourceFailure = "RelievePenaltyResourceFailure";

        public const string GetPenaltyModuleHandleFailure = "GetPenaltyModuleHandleFailure";

        public const string OptimalParagraphMustWrap = "OptimalParagraphMustWrap";

        public const string MultiSingleton = "MultiSingleton";

        public const string Unsupported_MouseAction = "Unsupported_MouseAction";

        public const string ReadOnlyInputGesturesCollection = "ReadOnlyInputGesturesCollection";

        public const string CollectionOnlyAcceptsCommandBindings = "CollectionOnlyAcceptsCommandBindings";

        public const string CollectionOnlyAcceptsInputGestures = "CollectionOnlyAcceptsInputGestures";

        public const string CollectionOnlyAcceptsInputBindings = "CollectionOnlyAcceptsInputBindings";

        public const string KeyGesture_Invalid = "KeyGesture_Invalid";

        public const string InputBinding_ExpectedInputGesture = "InputBinding_ExpectedInputGesture";

        public const string InvalidSiteOfOriginUri = "InvalidSiteOfOriginUri";

        public const string CannotNavigateToApplicationResourcesInWebBrowser = "CannotNavigateToApplicationResourcesInWebBrowser";

        public const string GetResponseFailed = "GetResponseFailed";

        public const string CutKey = "CutKey";

        public const string CopyKey = "CopyKey";

        public const string PasteKey = "PasteKey";

        public const string UndoKey = "UndoKey";

        public const string RedoKey = "RedoKey";

        public const string DeleteKey = "DeleteKey";

        public const string FindKey = "FindKey";

        public const string ReplaceKey = "ReplaceKey";

        public const string HelpKey = "HelpKey";

        public const string SelectAllKey = "SelectAllKey";

        public const string NewKey = "NewKey";

        public const string OpenKey = "OpenKey";

        public const string SaveKey = "SaveKey";

        public const string PrintKey = "PrintKey";

        public const string PrintPreviewKey = "PrintPreviewKey";

        public const string PropertiesKey = "PropertiesKey";

        public const string ContextMenuKey = "ContextMenuKey";

        public const string CorrectionListKey = "CorrectionListKey";

        public const string StopKey = "StopKey";

        public const string CutKeyDisplayString = "CutKeyDisplayString";

        public const string CopyKeyDisplayString = "CopyKeyDisplayString";

        public const string PasteKeyDisplayString = "PasteKeyDisplayString";

        public const string UndoKeyDisplayString = "UndoKeyDisplayString";

        public const string RedoKeyDisplayString = "RedoKeyDisplayString";

        public const string DeleteKeyDisplayString = "DeleteKeyDisplayString";

        public const string FindKeyDisplayString = "FindKeyDisplayString";

        public const string ReplaceKeyDisplayString = "ReplaceKeyDisplayString";

        public const string HelpKeyDisplayString = "HelpKeyDisplayString";

        public const string SelectAllKeyDisplayString = "SelectAllKeyDisplayString";

        public const string NewKeyDisplayString = "NewKeyDisplayString";

        public const string OpenKeyDisplayString = "OpenKeyDisplayString";

        public const string SaveKeyDisplayString = "SaveKeyDisplayString";

        public const string PrintKeyDisplayString = "PrintKeyDisplayString";

        public const string PrintPreviewKeyDisplayString = "PrintPreviewKeyDisplayString";

        public const string PropertiesKeyDisplayString = "PropertiesKeyDisplayString";

        public const string ContextMenuKeyDisplayString = "ContextMenuKeyDisplayString";

        public const string CorrectionListKeyDisplayString = "CorrectionListKeyDisplayString";

        public const string StopKeyDisplayString = "StopKeyDisplayString";

        public const string CutText = "CutText";

        public const string CopyText = "CopyText";

        public const string PasteText = "PasteText";

        public const string UndoText = "UndoText";

        public const string RedoText = "RedoText";

        public const string DeleteText = "DeleteText";

        public const string FindText = "FindText";

        public const string ReplaceText = "ReplaceText";

        public const string HelpText = "HelpText";

        public const string SelectAllText = "SelectAllText";

        public const string NewText = "NewText";

        public const string OpenText = "OpenText";

        public const string SaveText = "SaveText";

        public const string SaveAsText = "SaveAsText";

        public const string CloseText = "CloseText";

        public const string PrintText = "PrintText";

        public const string CancelPrintText = "CancelPrintText";

        public const string PrintPreviewText = "PrintPreviewText";

        public const string PropertiesText = "PropertiesText";

        public const string ContextMenuText = "ContextMenuText";

        public const string CorrectionListText = "CorrectionListText";

        public const string StopText = "StopText";

        public const string NotACommandText = "NotACommandText";

        public const string ScrollPageUpText = "ScrollPageUpText";

        public const string ScrollPageDownText = "ScrollPageDownText";

        public const string ScrollPageLeftText = "ScrollPageLeftText";

        public const string ScrollPageRightText = "ScrollPageRightText";

        public const string ScrollByLineText = "ScrollByLineText";

        public const string MoveLeftText = "MoveLeftText";

        public const string MoveRightText = "MoveRightText";

        public const string MoveUpText = "MoveUpText";

        public const string MoveDownText = "MoveDownText";

        public const string ExtendSelectionUpText = "ExtendSelectionUpText";

        public const string ExtendSelectionDownText = "ExtendSelectionDownText";

        public const string ExtendSelectionLeftText = "ExtendSelectionLeftText";

        public const string ExtendSelectionRightText = "ExtendSelectionRightText";

        public const string MoveToHomeText = "MoveToHomeText";

        public const string MoveToEndText = "MoveToEndText";

        public const string MoveToPageUpText = "MoveToPageUpText";

        public const string MoveToPageDownText = "MoveToPageDownText";

        public const string SelectToHomeText = "SelectToHomeText";

        public const string SelectToEndText = "SelectToEndText";

        public const string SelectToPageDownText = "SelectToPageDownText";

        public const string SelectToPageUpText = "SelectToPageUpText";

        public const string MoveFocusUpText = "MoveFocusUpText";

        public const string MoveFocusDownText = "MoveFocusDownText";

        public const string MoveFocusBackText = "MoveFocusBackText";

        public const string MoveFocusForwardText = "MoveFocusForwardText";

        public const string MoveFocusPageUpText = "MoveFocusPageUpText";

        public const string MoveFocusPageDownText = "MoveFocusPageDownText";

        public const string ScrollPageUpKey = "ScrollPageUpKey";

        public const string ScrollPageDownKey = "ScrollPageDownKey";

        public const string ScrollPageLeftKey = "ScrollPageLeftKey";

        public const string ScrollPageRightKey = "ScrollPageRightKey";

        public const string ScrollByLineKey = "ScrollByLineKey";

        public const string MoveLeftKey = "MoveLeftKey";

        public const string MoveRightKey = "MoveRightKey";

        public const string MoveUpKey = "MoveUpKey";

        public const string MoveDownKey = "MoveDownKey";

        public const string ExtendSelectionUpKey = "ExtendSelectionUpKey";

        public const string ExtendSelectionDownKey = "ExtendSelectionDownKey";

        public const string ExtendSelectionLeftKey = "ExtendSelectionLeftKey";

        public const string ExtendSelectionRightKey = "ExtendSelectionRightKey";

        public const string MoveToHomeKey = "MoveToHomeKey";

        public const string MoveToEndKey = "MoveToEndKey";

        public const string MoveToPageUpKey = "MoveToPageUpKey";

        public const string MoveToPageDownKey = "MoveToPageDownKey";

        public const string SelectToHomeKey = "SelectToHomeKey";

        public const string SelectToEndKey = "SelectToEndKey";

        public const string SelectToPageDownKey = "SelectToPageDownKey";

        public const string SelectToPageUpKey = "SelectToPageUpKey";

        public const string MoveFocusUpKey = "MoveFocusUpKey";

        public const string MoveFocusDownKey = "MoveFocusDownKey";

        public const string MoveFocusBackKey = "MoveFocusBackKey";

        public const string MoveFocusForwardKey = "MoveFocusForwardKey";

        public const string MoveFocusPageUpKey = "MoveFocusPageUpKey";

        public const string MoveFocusPageDownKey = "MoveFocusPageDownKey";

        public const string ScrollPageUpKeyDisplayString = "ScrollPageUpKeyDisplayString";

        public const string ScrollPageDownKeyDisplayString = "ScrollPageDownKeyDisplayString";

        public const string ScrollPageLeftKeyDisplayString = "ScrollPageLeftKeyDisplayString";

        public const string ScrollPageRightKeyDisplayString = "ScrollPageRightKeyDisplayString";

        public const string ScrollByLineKeyDisplayString = "ScrollByLineKeyDisplayString";

        public const string MoveLeftKeyDisplayString = "MoveLeftKeyDisplayString";

        public const string MoveRightKeyDisplayString = "MoveRightKeyDisplayString";

        public const string MoveUpKeyDisplayString = "MoveUpKeyDisplayString";

        public const string MoveDownKeyDisplayString = "MoveDownKeyDisplayString";

        public const string ExtendSelectionUpKeyDisplayString = "ExtendSelectionUpKeyDisplayString";

        public const string ExtendSelectionDownKeyDisplayString = "ExtendSelectionDownKeyDisplayString";

        public const string ExtendSelectionLeftKeyDisplayString = "ExtendSelectionLeftKeyDisplayString";

        public const string ExtendSelectionRightKeyDisplayString = "ExtendSelectionRightKeyDisplayString";

        public const string MoveToHomeKeyDisplayString = "MoveToHomeKeyDisplayString";

        public const string MoveToEndKeyDisplayString = "MoveToEndKeyDisplayString";

        public const string MoveToPageUpKeyDisplayString = "MoveToPageUpKeyDisplayString";

        public const string MoveToPageDownKeyDisplayString = "MoveToPageDownKeyDisplayString";

        public const string SelectToHomeKeyDisplayString = "SelectToHomeKeyDisplayString";

        public const string SelectToEndKeyDisplayString = "SelectToEndKeyDisplayString";

        public const string SelectToPageDownKeyDisplayString = "SelectToPageDownKeyDisplayString";

        public const string SelectToPageUpKeyDisplayString = "SelectToPageUpKeyDisplayString";

        public const string MoveFocusUpKeyDisplayString = "MoveFocusUpKeyDisplayString";

        public const string MoveFocusDownKeyDisplayString = "MoveFocusDownKeyDisplayString";

        public const string MoveFocusBackKeyDisplayString = "MoveFocusBackKeyDisplayString";

        public const string MoveFocusForwardKeyDisplayString = "MoveFocusForwardKeyDisplayString";

        public const string MoveFocusPageUpKeyDisplayString = "MoveFocusPageUpKeyDisplayString";

        public const string MoveFocusPageDownKeyDisplayString = "MoveFocusPageDownKeyDisplayString";

        public const string MediaPlayText = "MediaPlayText";

        public const string MediaPauseText = "MediaPauseText";

        public const string MediaStopText = "MediaStopText";

        public const string MediaRecordText = "MediaRecordText";

        public const string MediaNextTrackText = "MediaNextTrackText";

        public const string MediaPreviousTrackText = "MediaPreviousTrackText";

        public const string MediaFastForwardText = "MediaFastForwardText";

        public const string MediaRewindText = "MediaRewindText";

        public const string MediaChannelUpText = "MediaChannelUpText";

        public const string MediaChannelDownText = "MediaChannelDownText";

        public const string MediaSelectText = "MediaSelectText";

        public const string MediaTogglePlayPauseText = "MediaTogglePlayPauseText";

        public const string MediaIncreaseVolumeText = "MediaIncreaseVolumeText";

        public const string MediaDecreaseVolumeText = "MediaDecreaseVolumeText";

        public const string MediaMuteVolumeText = "MediaMuteVolumeText";

        public const string MediaIncreaseTrebleText = "MediaIncreaseTrebleText";

        public const string MediaDecreaseTrebleText = "MediaDecreaseTrebleText";

        public const string MediaIncreaseBassText = "MediaIncreaseBassText";

        public const string MediaDecreaseBassText = "MediaDecreaseBassText";

        public const string MediaBoostBassText = "MediaBoostBassText";

        public const string MediaIncreaseMicrophoneVolumeText = "MediaIncreaseMicrophoneVolumeText";

        public const string MediaDecreaseMicrophoneVolumeText = "MediaDecreaseMicrophoneVolumeText";

        public const string MediaMuteMicrophoneVolumeText = "MediaMuteMicrophoneVolumeText";

        public const string MediaToggleMicrophoneOnOffText = "MediaToggleMicrophoneOnOffText";

        public const string MediaPlayKey = "MediaPlayKey";

        public const string MediaPauseKey = "MediaPauseKey";

        public const string MediaStopKey = "MediaStopKey";

        public const string MediaRecordKey = "MediaRecordKey";

        public const string MediaNextTrackKey = "MediaNextTrackKey";

        public const string MediaPreviousTrackKey = "MediaPreviousTrackKey";

        public const string MediaFastForwardKey = "MediaFastForwardKey";

        public const string MediaRewindKey = "MediaRewindKey";

        public const string MediaChannelUpKey = "MediaChannelUpKey";

        public const string MediaChannelDownKey = "MediaChannelDownKey";

        public const string MediaSelectKey = "MediaSelectKey";

        public const string MediaTogglePlayPauseKey = "MediaTogglePlayPauseKey";

        public const string MediaIncreaseVolumeKey = "MediaIncreaseVolumeKey";

        public const string MediaDecreaseVolumeKey = "MediaDecreaseVolumeKey";

        public const string MediaMuteVolumeKey = "MediaMuteVolumeKey";

        public const string MediaIncreaseTrebleKey = "MediaIncreaseTrebleKey";

        public const string MediaDecreaseTrebleKey = "MediaDecreaseTrebleKey";

        public const string MediaIncreaseBassKey = "MediaIncreaseBassKey";

        public const string MediaDecreaseBassKey = "MediaDecreaseBassKey";

        public const string MediaBoostBassKey = "MediaBoostBassKey";

        public const string MediaIncreaseMicrophoneVolumeKey = "MediaIncreaseMicrophoneVolumeKey";

        public const string MediaDecreaseMicrophoneVolumeKey = "MediaDecreaseMicrophoneVolumeKey";

        public const string MediaMuteMicrophoneVolumeKey = "MediaMuteMicrophoneVolumeKey";

        public const string MediaToggleMicrophoneOnOffKey = "MediaToggleMicrophoneOnOffKey";

        public const string MediaPlayKeyDisplayString = "MediaPlayKeyDisplayString";

        public const string MediaPauseKeyDisplayString = "MediaPauseKeyDisplayString";

        public const string MediaStopKeyDisplayString = "MediaStopKeyDisplayString";

        public const string MediaRecordKeyDisplayString = "MediaRecordKeyDisplayString";

        public const string MediaNextTrackKeyDisplayString = "MediaNextTrackKeyDisplayString";

        public const string MediaPreviousTrackKeyDisplayString = "MediaPreviousTrackKeyDisplayString";

        public const string MediaFastForwardKeyDisplayString = "MediaFastForwardKeyDisplayString";

        public const string MediaRewindKeyDisplayString = "MediaRewindKeyDisplayString";

        public const string MediaChannelUpKeyDisplayString = "MediaChannelUpKeyDisplayString";

        public const string MediaChannelDownKeyDisplayString = "MediaChannelDownKeyDisplayString";

        public const string MediaSelectKeyDisplayString = "MediaSelectKeyDisplayString";

        public const string MediaTogglePlayPauseKeyDisplayString = "MediaTogglePlayPauseKeyDisplayString";

        public const string MediaIncreaseVolumeKeyDisplayString = "MediaIncreaseVolumeKeyDisplayString";

        public const string MediaDecreaseVolumeKeyDisplayString = "MediaDecreaseVolumeKeyDisplayString";

        public const string MediaMuteVolumeKeyDisplayString = "MediaMuteVolumeKeyDisplayString";

        public const string MediaIncreaseTrebleKeyDisplayString = "MediaIncreaseTrebleKeyDisplayString";

        public const string MediaDecreaseTrebleKeyDisplayString = "MediaDecreaseTrebleKeyDisplayString";

        public const string MediaIncreaseBassKeyDisplayString = "MediaIncreaseBassKeyDisplayString";

        public const string MediaDecreaseBassKeyDisplayString = "MediaDecreaseBassKeyDisplayString";

        public const string MediaBoostBassKeyDisplayString = "MediaBoostBassKeyDisplayString";

        public const string MediaIncreaseMicrophoneVolumeKeyDisplayString = "MediaIncreaseMicrophoneVolumeKeyDisplayString";

        public const string MediaDecreaseMicrophoneVolumeKeyDisplayString = "MediaDecreaseMicrophoneVolumeKeyDisplayString";

        public const string MediaMuteMicrophoneVolumeKeyDisplayString = "MediaMuteMicrophoneVolumeKeyDisplayString";

        public const string MediaToggleMicrophoneOnOffKeyDisplayString = "MediaToggleMicrophoneOnOffKeyDisplayString";

        public const string BrowseBackKey = "BrowseBackKey";

        public const string BrowseForwardKey = "BrowseForwardKey";

        public const string BrowseHomeKey = "BrowseHomeKey";

        public const string BrowseStopKey = "BrowseStopKey";

        public const string RefreshKey = "RefreshKey";

        public const string FavoritesKey = "FavoritesKey";

        public const string SearchKey = "SearchKey";

        public const string IncreaseZoomKey = "IncreaseZoomKey";

        public const string DecreaseZoomKey = "DecreaseZoomKey";

        public const string ZoomKey = "ZoomKey";

        public const string NextPageKey = "NextPageKey";

        public const string PreviousPageKey = "PreviousPageKey";

        public const string FirstPageKey = "FirstPageKey";

        public const string LastPageKey = "LastPageKey";

        public const string GoToPageKey = "GoToPageKey";

        public const string NavigateJournalKey = "NavigateJournalKey";

        public const string BrowseBackKeyDisplayString = "BrowseBackKeyDisplayString";

        public const string BrowseForwardKeyDisplayString = "BrowseForwardKeyDisplayString";

        public const string BrowseHomeKeyDisplayString = "BrowseHomeKeyDisplayString";

        public const string BrowseStopKeyDisplayString = "BrowseStopKeyDisplayString";

        public const string RefreshKeyDisplayString = "RefreshKeyDisplayString";

        public const string FavoritesKeyDisplayString = "FavoritesKeyDisplayString";

        public const string SearchKeyDisplayString = "SearchKeyDisplayString";

        public const string IncreaseZoomKeyDisplayString = "IncreaseZoomKeyDisplayString";

        public const string DecreaseZoomKeyDisplayString = "DecreaseZoomKeyDisplayString";

        public const string ZoomKeyDisplayString = "ZoomKeyDisplayString";

        public const string NextPageKeyDisplayString = "NextPageKeyDisplayString";

        public const string PreviousPageKeyDisplayString = "PreviousPageKeyDisplayString";

        public const string FirstPageKeyDisplayString = "FirstPageKeyDisplayString";

        public const string LastPageKeyDisplayString = "LastPageKeyDisplayString";

        public const string GoToPageKeyDisplayString = "GoToPageKeyDisplayString";

        public const string NavigateJournalKeyDisplayString = "NavigateJournalKeyDisplayString";

        public const string BrowseBackText = "BrowseBackText";

        public const string BrowseForwardText = "BrowseForwardText";

        public const string BrowseHomeText = "BrowseHomeText";

        public const string BrowseStopText = "BrowseStopText";

        public const string RefreshText = "RefreshText";

        public const string FavoritesText = "FavoritesText";

        public const string SearchText = "SearchText";

        public const string IncreaseZoomText = "IncreaseZoomText";

        public const string DecreaseZoomText = "DecreaseZoomText";

        public const string ZoomText = "ZoomText";

        public const string NextPageText = "NextPageText";

        public const string PreviousPageText = "PreviousPageText";

        public const string FirstPageText = "FirstPageText";

        public const string LastPageText = "LastPageText";

        public const string GoToPageText = "GoToPageText";

        public const string NavigateJournalText = "NavigateJournalText";

        public const string ParameterValueCannotBeNaN = "ParameterValueCannotBeNaN";

        public const string ParameterValueMustBeGreaterThanZero = "ParameterValueMustBeGreaterThanZero";

        public const string GlyphIndexOutOfRange = "GlyphIndexOutOfRange";

        public const string CodePointOutOfRange = "CodePointOutOfRange";

        public const string SidewaysRTLTextIsNotSupported = "SidewaysRTLTextIsNotSupported";

        public const string GlyphTypefaceNotRecorded = "GlyphTypefaceNotRecorded";

        public const string CompileFeatureSet_InvalidTypographyProperties = "CompileFeatureSet_InvalidTypographyProperties";

        public const string FaceIndexValidOnlyForTTC = "FaceIndexValidOnlyForTTC";

        public const string FaceIndexMustBePositiveOrZero = "FaceIndexMustBePositiveOrZero";

        public const string UriNotAbsolute = "UriNotAbsolute";

        public const string UriMustBeFileOrPack = "UriMustBeFileOrPack";

        public const string InvalidAbsoluteUriInFontFamilyName = "InvalidAbsoluteUriInFontFamilyName";

        public const string NullBaseUriParam = "NullBaseUriParam";

        public const string ClusterMapFirstEntryMustBeZero = "ClusterMapFirstEntryMustBeZero";

        public const string ClusterMapEntriesShouldNotDecrease = "ClusterMapEntriesShouldNotDecrease";

        public const string ClusterMapEntryShouldPointWithinGlyphIndices = "ClusterMapEntryShouldPointWithinGlyphIndices";

        public const string InvalidTextDecorationCollectionString = "InvalidTextDecorationCollectionString";

        public const string TextLineHasBeenDisposed = "TextLineHasBeenDisposed";

        public const string TextBreakpointHasBeenDisposed = "TextBreakpointHasBeenDisposed";

        public const string TextPenaltyModuleHasBeenDisposed = "TextPenaltyModuleHasBeenDisposed";

        public const string TextObjectMetrics_WidthOutOfRange = "TextObjectMetrics_WidthOutOfRange";

        public const string SpecificNumberCultureRequired = "SpecificNumberCultureRequired";

        public const string TextRunPropertiesCannotBeNull = "TextRunPropertiesCannotBeNull";

        public const string GlyphCoordinateTooBig = "GlyphCoordinateTooBig";

        public const string GlyphAreaTooBig = "GlyphAreaTooBig";

        public const string TooManyGlyphRuns = "TooManyGlyphRuns";

        public const string PropertyValueCannotBeNaN = "PropertyValueCannotBeNaN";

        public const string PropertyMustBeGreaterThanZero = "PropertyMustBeGreaterThanZero";

        public const string PropertyOfClassMustBeGreaterThanZero = "PropertyOfClassMustBeGreaterThanZero";

        public const string PropertyOfClassCannotBeGreaterThan = "PropertyOfClassCannotBeGreaterThan";

        public const string PropertyOfClassCannotBeNull = "PropertyOfClassCannotBeNull";

        public const string PropertyCannotBeNegative = "PropertyCannotBeNegative";

        public const string TextFormatterReentranceProhibited = "TextFormatterReentranceProhibited";

        public const string CurrentDispatcherNotFound = "CurrentDispatcherNotFound";

        public const string InitializationIncomplete = "InitializationIncomplete";

        public const string OnlyOneInitialization = "OnlyOneInitialization";

        public const string InInitialization = "InInitialization";

        public const string NotInInitialization = "NotInInitialization";

        public const string CompositeFontUnknownElement = "CompositeFontUnknownElement";

        public const string CompositeFontUnknownAttribute = "CompositeFontUnknownAttribute";

        public const string CompositeFontMissingElement = "CompositeFontMissingElement";

        public const string CompositeFontMissingAttribute = "CompositeFontMissingAttribute";

        public const string CompositeFontAttributeValue1 = "CompositeFontAttributeValue1";

        public const string CompositeFontAttributeValue2 = "CompositeFontAttributeValue2";

        public const string CompositeFontInvalidUnicodeRange = "CompositeFontInvalidUnicodeRange";

        public const string CompositeFontSignificantWhitespace = "CompositeFontSignificantWhitespace";

        public const string CompositeFont_TooManyFamilyMaps = "CompositeFont_TooManyFamilyMaps";

        public const string CompositeFont_DuplicateTypeface = "CompositeFont_DuplicateTypeface";

        public const string FamilyMap_TargetNotSet = "FamilyMap_TargetNotSet";

        public const string CharacterMetrics_MissingRequiredField = "CharacterMetrics_MissingRequiredField";

        public const string CharacterMetrics_TooManyFields = "CharacterMetrics_TooManyFields";

        public const string CharacterMetrics_NegativeHorizontalAdvance = "CharacterMetrics_NegativeHorizontalAdvance";

        public const string CharacterMetrics_NegativeVerticalAdvance = "CharacterMetrics_NegativeVerticalAdvance";

        public const string FontFamily_ReadOnly = "FontFamily_ReadOnly";

        public const string MilErr_UnsupportedVersion = "MilErr_UnsupportedVersion";

        public const string DrawingGroup_AlreadyOpen = "DrawingGroup_AlreadyOpen";

        public const string DrawingGroup_CannotAppendToNullCollection = "DrawingGroup_CannotAppendToNullCollection";

        public const string DrawingGroup_CannotAppendToFrozenCollection = "DrawingGroup_CannotAppendToFrozenCollection";

        public const string DrawingContext_TooManyPops = "DrawingContext_TooManyPops";

        public const string Visual_NotAVisual = "Visual_NotAVisual";

        public const string Visual_NotA3DVisual = "Visual_NotA3DVisual";

        public const string Visual_NoCommonAncestor = "Visual_NoCommonAncestor";

        public const string Visual_NotADescendant = "Visual_NotADescendant";

        public const string Visual_NotAnAncestor = "Visual_NotAnAncestor";

        public const string Visual_HasParent = "Visual_HasParent";

        public const string Visual_NotChild = "Visual_NotChild";

        public const string Visual_NoPresentationSource = "Visual_NoPresentationSource";

        public const string Visual_CannotTransformPoint = "Visual_CannotTransformPoint";

        public const string VisualTarget_AnotherTargetAlreadyConnected = "VisualTarget_AnotherTargetAlreadyConnected";

        public const string HwndTarget_InvalidWindowHandle = "HwndTarget_InvalidWindowHandle";

        public const string HwndTarget_InvalidWindowProcess = "HwndTarget_InvalidWindowProcess";

        public const string HwndTarget_InvalidWindowThread = "HwndTarget_InvalidWindowThread";

        public const string HwndTarget_WindowAlreadyHasContent = "HwndTarget_WindowAlreadyHasContent";

        public const string HwndTarget_HardwareNotSupportDueToProtocolMismatch = "HwndTarget_HardwareNotSupportDueToProtocolMismatch";

        public const string VisualCollection_NotEnoughCapacity = "VisualCollection_NotEnoughCapacity";

        public const string VisualCollection_EntryInUse = "VisualCollection_EntryInUse";

        public const string VisualCollection_VisualHasParent = "VisualCollection_VisualHasParent";

        public const string VisualCollection_ReadOnly = "VisualCollection_ReadOnly";

        public const string MediaContext_APINotAllowed = "MediaContext_APINotAllowed";

        public const string MediaContext_InfiniteTickLoop = "MediaContext_InfiniteTickLoop";

        public const string MediaContext_InfiniteLayoutLoop = "MediaContext_InfiniteLayoutLoop";

        public const string MediaContext_RenderThreadError = "MediaContext_RenderThreadError";

        public const string MediaSystem_ApiInvalidContext = "MediaSystem_ApiInvalidContext";

        public const string MediaSystem_OutOfOrderConnectOrDisconnect = "MediaSystem_OutOfOrderConnectOrDisconnect";

        public const string MediaContext_OutOfVideoMemory = "MediaContext_OutOfVideoMemory";

        public const string MediaContext_NoBadShaderHandler = "MediaContext_NoBadShaderHandler";

        public const string CompositionTarget_RootVisual_HasParent = "CompositionTarget_RootVisual_HasParent";

        public const string Channel_InvalidCommandBufferPointer = "Channel_InvalidCommandBufferPointer";

        public const string Collection_BadDestArray = "Collection_BadDestArray";

        public const string Collection_BadRank = "Collection_BadRank";

        public const string Collection_NoNull = "Collection_NoNull";

        public const string PathGeometry_InternalReadBackError = "PathGeometry_InternalReadBackError";

        public const string HitTest_Invalid = "HitTest_Invalid";

        public const string Converter_ConvertToNotSupported = "Converter_ConvertToNotSupported";

        public const string Converter_ConvertFromNotSupported = "Converter_ConvertFromNotSupported";

        public const string Parsers_IllegalToken = "Parsers_IllegalToken";

        public const string Parsers_IllegalToken_250_Chars = "Parsers_IllegalToken_250_Chars";

        public const string Parser_UnexpectedToken = "Parser_UnexpectedToken";

        public const string Parser_BadForm = "Parser_BadForm";

        public const string Parser_Empty = "Parser_Empty";

        public const string BrushUnknownBamlType = "BrushUnknownBamlType";

        public const string FloatUnknownBamlType = "FloatUnknownBamlType";

        public const string Image_NoArgument = "Image_NoArgument";

        public const string Image_NeitherArgument = "Image_NeitherArgument";

        public const string Image_SizeOutOfRange = "Image_SizeOutOfRange";

        public const string Image_SizeOptionsAngle = "Image_SizeOptionsAngle";

        public const string Image_ComponentNotFound = "Image_ComponentNotFound";

        public const string Image_NoFrames = "Image_NoFrames";

        public const string Image_BadPixelFormat = "Image_BadPixelFormat";

        public const string Image_PaletteFixedType = "Image_PaletteFixedType";

        public const string Image_CantBeFrozen = "Image_CantBeFrozen";

        public const string Image_CantDealWithStream = "Image_CantDealWithStream";

        public const string Image_CantDealWithUri = "Image_CantDealWithUri";

        public const string Image_NoDecodeFrames = "Image_NoDecodeFrames";

        public const string Image_OnlyOneSave = "Image_OnlyOneSave";

        public const string Image_OnlyOrthogonal = "Image_OnlyOrthogonal";

        public const string Image_BadVersion = "Image_BadVersion";

        public const string WIC_NotInitialized = "WIC_NotInitialized";

        public const string Image_NotInitialized = "Image_NotInitialized";

        public const string Image_PropertyNotFound = "Image_PropertyNotFound";

        public const string Image_PropertyNotSupported = "Image_PropertyNotSupported";

        public const string Image_PropertySize = "Image_PropertySize";

        public const string Image_CodecPresent = "Image_CodecPresent";

        public const string Image_NoThumbnail = "Image_NoThumbnail";

        public const string Image_SingularMatrix = "Image_SingularMatrix";

        public const string Image_NoPalette = "Image_NoPalette";

        public const string Image_PaletteZeroColors = "Image_PaletteZeroColors";

        public const string Image_PaletteColorsDoNotMatchFormat = "Image_PaletteColorsDoNotMatchFormat";

        public const string Image_BadDimensions = "Image_BadDimensions";

        public const string Image_TooManyScanlines = "Image_TooManyScanlines";

        public const string Image_InternalError = "Image_InternalError";

        public const string Image_DisplayStateInvalid = "Image_DisplayStateInvalid";

        public const string Image_NoCodecsFound = "Image_NoCodecsFound";

        public const string Image_NoPixelFormatFound = "Image_NoPixelFormatFound";

        public const string Image_FrameMissing = "Image_FrameMissing";

        public const string Image_UnsupportedPixelFormat = "Image_UnsupportedPixelFormat";

        public const string Image_UnsupportedOperation = "Image_UnsupportedOperation";

        public const string Image_BadMetadataHeader = "Image_BadMetadataHeader";

        public const string Image_BadStreamData = "Image_BadStreamData";

        public const string Image_StreamWrite = "Image_StreamWrite";

        public const string Image_StreamRead = "Image_StreamRead";

        public const string Image_GuidEmpty = "Image_GuidEmpty";

        public const string Image_InvalidArrayForPixel = "Image_InvalidArrayForPixel";

        public const string Image_InitializationIncomplete = "Image_InitializationIncomplete";

        public const string Image_OnlyOneInit = "Image_OnlyOneInit";

        public const string Image_InInitialize = "Image_InInitialize";

        public const string Image_EndInitWithoutBeginInit = "Image_EndInitWithoutBeginInit";

        public const string Image_SetPropertyOutsideBeginEndInit = "Image_SetPropertyOutsideBeginEndInit";

        public const string Image_EncoderNoGlobalThumbnail = "Image_EncoderNoGlobalThumbnail";

        public const string Image_EncoderNoGlobalMetadata = "Image_EncoderNoGlobalMetadata";

        public const string Image_EncoderNoPreview = "Image_EncoderNoPreview";

        public const string Image_EncoderNoColorContext = "Image_EncoderNoColorContext";

        public const string Image_IndexedPixelFormatRequiresPalette = "Image_IndexedPixelFormatRequiresPalette";

        public const string Image_WrongState = "Image_WrongState";

        public const string Image_Overflow = "Image_Overflow";

        public const string Image_FreezableCloneNotAllowed = "Image_FreezableCloneNotAllowed";

        public const string Image_UnexpectedMetadataType = "Image_UnexpectedMetadataType";

        public const string Image_InvalidQueryRequest = "Image_InvalidQueryRequest";

        public const string Image_RequestOnlyValidAtMetadataRoot = "Image_RequestOnlyValidAtMetadataRoot";

        public const string Image_InvalidQueryCharacter = "Image_InvalidQueryCharacter";

        public const string Image_DuplicateMetadataPresent = "Image_DuplicateMetadataPresent";

        public const string Image_PropertyUnexpectedType = "Image_PropertyUnexpectedType";

        public const string Image_TooMuchMetadata = "Image_TooMuchMetadata";

        public const string Image_OriginalStreamReadOnly = "Image_OriginalStreamReadOnly";

        public const string Image_MetadataReadOnly = "Image_MetadataReadOnly";

        public const string Image_MetadataSizeFixed = "Image_MetadataSizeFixed";

        public const string Image_MetadataInitializationIncomplete = "Image_MetadataInitializationIncomplete";

        public const string Image_InplaceMetadataNoCopy = "Image_InplaceMetadataNoCopy";

        public const string Image_InsufficientBufferSize = "Image_InsufficientBufferSize";

        public const string Image_MetadataNotCompatible = "Image_MetadataNotCompatible";

        public const string Image_ContentTypeDoesNotMatchDecoder = "Image_ContentTypeDoesNotMatchDecoder";

        public const string Image_CannotCreateTempFile = "Image_CannotCreateTempFile";

        public const string Image_MetadataNotSupported = "Image_MetadataNotSupported";

        public const string Image_AlphaThresholdOutOfRange = "Image_AlphaThresholdOutOfRange";

        public const string Image_StreamNotAvailable = "Image_StreamNotAvailable";

        public const string Image_InvalidColorContext = "Image_InvalidColorContext";

        public const string Image_InsufficientBuffer = "Image_InsufficientBuffer";

        public const string Image_LockCountLimit = "Image_LockCountLimit";

        public const string Image_MustBeLocked = "Image_MustBeLocked";

        public const string D3DImage_MustHaveBackBuffer = "D3DImage_MustHaveBackBuffer";

        public const string D3DImage_SurfaceTooBig = "D3DImage_SurfaceTooBig";

        public const string D3DImage_InvalidUsage = "D3DImage_InvalidUsage";

        public const string D3DImage_InvalidPool = "D3DImage_InvalidPool";

        public const string D3DImage_InvalidDevice = "D3DImage_InvalidDevice";

        public const string D3DImage_AARequires9Ex = "D3DImage_AARequires9Ex";

        public const string AddText_Invalid = "AddText_Invalid";

        public const string Animation_AnimationTimelineTypeMismatch = "Animation_AnimationTimelineTypeMismatch";

        public const string Animation_CalculatedValueIsInvalidForProperty = "Animation_CalculatedValueIsInvalidForProperty";

        public const string IAnimatable_CantAnimateSealedDO = "IAnimatable_CantAnimateSealedDO";

        public const string Animation_ChildTypeMismatch = "Animation_ChildTypeMismatch";

        public const string Animation_DependencyPropertyIsNotAnimatable = "Animation_DependencyPropertyIsNotAnimatable";

        public const string Animation_KeySpline_InvalidValue = "Animation_KeySpline_InvalidValue";

        public const string Animation_KeyTime_LessThanZero = "Animation_KeyTime_LessThanZero";

        public const string Animation_KeyTime_InvalidPercentValue = "Animation_KeyTime_InvalidPercentValue";

        public const string Animation_NoAnimationsSpecified = "Animation_NoAnimationsSpecified";

        public const string Animation_Exception = "Animation_Exception";

        public const string Animation_ReturnedUnsetValueInstance = "Animation_ReturnedUnsetValueInstance";

        public const string Animation_UnrecognizedHandoffBehavior = "Animation_UnrecognizedHandoffBehavior";

        public const string Timing_ChildMustBeTimeline = "Timing_ChildMustBeTimeline";

        public const string Timing_CreateClockMustReturnNewClock = "Timing_CreateClockMustReturnNewClock";

        public const string Timing_DifferentThreads = "Timing_DifferentThreads";

        public const string Timing_EnumeratorInvalidated = "Timing_EnumeratorInvalidated";

        public const string Timing_EnumeratorOutOfRange = "Timing_EnumeratorOutOfRange";

        public const string Timing_InvalidArgAccelAndDecel = "Timing_InvalidArgAccelAndDecel";

        public const string Timing_AccelAndDecelGreaterThanOne = "Timing_AccelAndDecelGreaterThanOne";

        public const string Timing_InvalidArgFiniteNonNegative = "Timing_InvalidArgFiniteNonNegative";

        public const string Timing_InvalidArgFinitePositive = "Timing_InvalidArgFinitePositive";

        public const string Timing_InvalidArgNonNegative = "Timing_InvalidArgNonNegative";

        public const string Timing_InvalidArgPositive = "Timing_InvalidArgPositive";

        public const string Timing_NoTextChildren = "Timing_NoTextChildren";

        public const string Timing_NotTimeSpan = "Timing_NotTimeSpan";

        public const string Timing_OperationEnqueuedOutOfOrder = "Timing_OperationEnqueuedOutOfOrder";

        public const string Timing_RepeatBehaviorInvalidIterationCount = "Timing_RepeatBehaviorInvalidIterationCount";

        public const string Timing_RepeatBehaviorInvalidRepeatDuration = "Timing_RepeatBehaviorInvalidRepeatDuration";

        public const string Timing_RepeatBehaviorNotIterationCount = "Timing_RepeatBehaviorNotIterationCount";

        public const string Timing_RepeatBehaviorNotRepeatDuration = "Timing_RepeatBehaviorNotRepeatDuration";

        public const string Timing_SeekDestinationAmbiguousDueToSlip = "Timing_SeekDestinationAmbiguousDueToSlip";

        public const string Timing_SeekDestinationIndefinite = "Timing_SeekDestinationIndefinite";

        public const string Timing_SeekDestinationNegative = "Timing_SeekDestinationNegative";

        public const string Timing_SkipToFillDestinationIndefinite = "Timing_SkipToFillDestinationIndefinite";

        public const string Timing_SlipBehavior_SlipOnlyOnSimpleTimelines = "Timing_SlipBehavior_SlipOnlyOnSimpleTimelines";

        public const string Timing_SlipBehavior_SyncOnlyWithSimpleParents = "Timing_SlipBehavior_SyncOnlyWithSimpleParents";

        public const string Timing_CanSlipOnlyOnSimpleTimelines = "Timing_CanSlipOnlyOnSimpleTimelines";

        public const string SourceNotSet = "SourceNotSet";

        public const string Mismatched_RoutedEvent = "Mismatched_RoutedEvent";

        public const string HandlerTypeIllegal = "HandlerTypeIllegal";

        public const string DuplicateEventName = "DuplicateEventName";

        public const string TreeLoop = "TreeLoop";

        public const string RoutedEventArgsMustHaveRoutedEvent = "RoutedEventArgsMustHaveRoutedEvent";

        public const string ClassTypeIllegal = "ClassTypeIllegal";

        public const string TooManyRoutedEvents = "TooManyRoutedEvents";

        public const string CannotModifyVisualChildrenDuringTreeWalk = "CannotModifyVisualChildrenDuringTreeWalk";

        public const string RoutedEventCannotChangeWhileRouting = "RoutedEventCannotChangeWhileRouting";

        public const string Color_DimensionMismatch = "Color_DimensionMismatch";

        public const string Color_ColorContextTypeMismatch = "Color_ColorContextTypeMismatch";

        public const string Color_ColorContextNotsRGB_or_scRGB = "Color_ColorContextNotsRGB_or_scRGB";

        public const string Color_NullColorContext = "Color_NullColorContext";

        public const string ColorContext_FileTooLarge = "ColorContext_FileTooLarge";

        public const string HitTest_Singular = "HitTest_Singular";

        public const string Matrix3D_NotAffineTransform = "Matrix3D_NotAffineTransform";

        public const string Matrix3D_NotInvertible = "Matrix3D_NotInvertible";

        public const string Size3D_DimensionCannotBeNegative = "Size3D_DimensionCannotBeNegative";

        public const string Size3D_CannotModifyEmptySize = "Size3D_CannotModifyEmptySize";

        public const string Rect3D_CannotModifyEmptyRect = "Rect3D_CannotModifyEmptyRect";

        public const string Rect3D_CannotCallMethod = "Rect3D_CannotCallMethod";

        public const string Quaternion_ZeroAxisSpecified = "Quaternion_ZeroAxisSpecified";

        public const string ScopeMustBeUIElementOrContent = "ScopeMustBeUIElementOrContent";

        public const string OleRegisterDragDropFailure = "OleRegisterDragDropFailure";

        public const string OleRevokeDragDropFailure = "OleRevokeDragDropFailure";

        public const string DragDrop_DragDropEffectsInvalid = "DragDrop_DragDropEffectsInvalid";

        public const string DragDrop_DragActionInvalid = "DragDrop_DragActionInvalid";

        public const string DataObject_DataFormatNotPresentOnDataObject = "DataObject_DataFormatNotPresentOnDataObject";

        public const string DataObject_DataObjectMustHaveAtLeastOneFormat = "DataObject_DataObjectMustHaveAtLeastOneFormat";

        public const string DataObject_CannotSetDataOnAFozenOLEDataDbject = "DataObject_CannotSetDataOnAFozenOLEDataDbject";

        public const string DataObject_NotImplementedEnumFormatEtc = "DataObject_NotImplementedEnumFormatEtc";

        public const string DataObject_FileDropListIsEmpty = "DataObject_FileDropListIsEmpty";

        public const string DataObject_FileDropListHasInvalidFileDropPath = "DataObject_FileDropListHasInvalidFileDropPath";

        public const string DataObject_EmptyFormatNotAllowed = "DataObject_EmptyFormatNotAllowed";

        public const string DataObject_HasInvalidDataForOleDataObject = "DataObject_HasInvalidDataForOleDataObject";

        public const string AnimEffect_CollectionInUse = "AnimEffect_CollectionInUse";

        public const string AnimEffect_NoVisual = "AnimEffect_NoVisual";

        public const string AnimEffect_AlreadyAttached = "AnimEffect_AlreadyAttached";

        public const string Effect_PixelFormat = "Effect_PixelFormat";

        public const string Media_UninitializedResource = "Media_UninitializedResource";

        public const string Media_StreamClosed = "Media_StreamClosed";

        public const string Media_InvalidArgument = "Media_InvalidArgument";

        public const string Media_InvalidWmpVersion = "Media_InvalidWmpVersion";

        public const string Media_UriNotSpecified = "Media_UriNotSpecified";

        public const string Media_InsufficientVideoResources = "Media_InsufficientVideoResources";

        public const string Media_HardwareVideoAccelerationNotAvailable = "Media_HardwareVideoAccelerationNotAvailable";

        public const string Media_LogonFailure = "Media_LogonFailure";

        public const string Media_FileNotFound = "Media_FileNotFound";

        public const string Media_DownloadFailed = "Media_DownloadFailed";

        public const string Media_FileFormatNotSupported = "Media_FileFormatNotSupported";

        public const string Media_PlaylistFormatNotSupported = "Media_PlaylistFormatNotSupported";

        public const string Media_NotAllowedWhileTimingEngineInControl = "Media_NotAllowedWhileTimingEngineInControl";

        public const string Media_UnknownMediaExecption = "Media_UnknownMediaExecption";

        public const string Media_PlayerIsClosed = "Media_PlayerIsClosed";

        public const string Media_UnknownChannelType = "Media_UnknownChannelType";

        public const string Media_PackURIsAreNotSupported = "Media_PackURIsAreNotSupported";

        public const string AccessKeyManager_NotAUnicodeCharacter = "AccessKeyManager_NotAUnicodeCharacter";

        public const string InputMethod_InvalidConversionMode = "InputMethod_InvalidConversionMode";

        public const string InputMethod_InvalidSentenceMode = "InputMethod_InvalidSentenceMode";

        public const string InputLanguageManager_NotReadyToChangeCurrentLanguage = "InputLanguageManager_NotReadyToChangeCurrentLanguage";

        public const string InputScope_InvalidInputScopeName = "InputScope_InvalidInputScopeName";

        public const string TextComposition_NullResultText = "TextComposition_NullResultText";

        public const string TextCompositionManager_TextCompositionHasStarted = "TextCompositionManager_TextCompositionHasStarted";

        public const string TextCompositionManager_TextCompositionNotStarted = "TextCompositionManager_TextCompositionNotStarted";

        public const string TextCompositionManager_TextCompositionHasDone = "TextCompositionManager_TextCompositionHasDone";

        public const string TextCompositionManager_NoInputManager = "TextCompositionManager_NoInputManager";

        public const string ByteRangeDownloaderDisposed = "ByteRangeDownloaderDisposed";

        public const string ByteRangeRequestIsNotSupported = "ByteRangeRequestIsNotSupported";

        public const string ByteRangeDownloaderErroredOut = "ByteRangeDownloaderErroredOut";

        public const string InvalidScheme = "InvalidScheme";

        public const string InvalidByteRanges = "InvalidByteRanges";

        public const string InvalidTempFileName = "InvalidTempFileName";

        public const string RequestAlreadyStarted = "RequestAlreadyStarted";

        public const string InvalidEventHandle = "InvalidEventHandle";

        public const string FlushNotSupported = "FlushNotSupported";

        public const string OffsetNegative = "OffsetNegative";

        public const string IOBufferOverflow = "IOBufferOverflow";

        public const string ReadCountNegative = "ReadCountNegative";

        public const string SeekOriginInvalid = "SeekOriginInvalid";

        public const string SetLengthNotSupported = "SetLengthNotSupported";

        public const string WriteNotSupported = "WriteNotSupported";

        public const string WebResponseFailure = "WebResponseFailure";

        public const string WebResponseCloseFailure = "WebResponseCloseFailure";

        public const string WebRequestTimeout = "WebRequestTimeout";

        public const string PackWebRequestCachePolicyIllegal = "PackWebRequestCachePolicyIllegal";

        public const string WebResponsePartNotFound = "WebResponsePartNotFound";

        public const string UriSchemeMismatch = "UriSchemeMismatch";

        public const string UriMustBeAbsolute = "UriMustBeAbsolute";

        public const string PackageAlreadyExists = "PackageAlreadyExists";

        public const string NotAllowedPackageUri = "NotAllowedPackageUri";

        public const string InnerRequestNotAllowed = "InnerRequestNotAllowed";

        public const string SchemaInvalidForTransport = "SchemaInvalidForTransport";

        public const string ResourceNotFoundUnderCacheOnlyPolicy = "ResourceNotFoundUnderCacheOnlyPolicy";

        public const string SeekNegative = "SeekNegative";

        public const string InvalidPartName = "InvalidPartName";

        public const string NonWhiteSpaceInAddText = "NonWhiteSpaceInAddText";

        public const string OleServicesContext_oleInitializeFailure = "OleServicesContext_oleInitializeFailure";

        public const string OleServicesContext_ThreadMustBeSTA = "OleServicesContext_ThreadMustBeSTA";

        public const string SetFocusFailed = "SetFocusFailed";

        public const string AutomationTimeout = "AutomationTimeout";

        public const string AutomationDispatcherShutdown = "AutomationDispatcherShutdown";

        public const string TextProvider_InvalidChild = "TextProvider_InvalidChild";

        public const string TextRangeProvider_InvalidRangeProvider = "TextRangeProvider_InvalidRangeProvider";

        public const string FileNotFoundExceptionWithFileName = "FileNotFoundExceptionWithFileName";

        public const string DirectoryNotFoundExceptionWithFileName = "DirectoryNotFoundExceptionWithFileName";

        public const string UnauthorizedAccessExceptionWithFileName = "UnauthorizedAccessExceptionWithFileName";

        public const string IOExceptionWithFileName = "IOExceptionWithFileName";

        public const string PathTooLongExceptionWithFileName = "PathTooLongExceptionWithFileName";

        public const string EventArgIsNull = "EventArgIsNull";

        public const string InvalidDrawingAttributesHeight = "InvalidDrawingAttributesHeight";

        public const string InvalidDrawingAttributesWidth = "InvalidDrawingAttributesWidth";

        public const string EPExists = "EPExists";

        public const string EPNotFound = "EPNotFound";

        public const string EPGuidNotFound = "EPGuidNotFound";

        public const string ValueNotValidForGuid = "ValueNotValidForGuid";

        public const string CannotBothBeNull = "CannotBothBeNull";

        public const string Invalid_isfData_Length = "Invalid_isfData_Length";

        public const string InvalidRemovedStroke = "InvalidRemovedStroke";

        public const string StrokeIsDuplicated = "StrokeIsDuplicated";

        public const string InvalidReplacedStroke = "InvalidReplacedStroke";

        public const string EmptyScToReplaceWith = "EmptyScToReplaceWith";

        public const string EmptyScToReplace = "EmptyScToReplace";

        public const string StrokesNotContiguously = "StrokesNotContiguously";

        public const string CollectionEnumerationError = "CollectionEnumerationError";

        public const string InvalidDiameter = "InvalidDiameter";

        public const string EmptyArray = "EmptyArray";

        public const string SCEraseShape = "SCEraseShape";

        public const string SCErasePath = "SCErasePath";

        public const string SCDataChanged = "SCDataChanged";

        public const string StrokeCollectionIsReadOnly = "StrokeCollectionIsReadOnly";

        public const string EmptyArrayNotAllowedAsArgument = "EmptyArrayNotAllowedAsArgument";

        public const string VisualCannotBeDetached = "VisualCannotBeDetached";

        public const string EndHitTestingCalled = "EndHitTestingCalled";

        public const string CannotAttachVisualTwice = "CannotAttachVisualTwice";

        public const string UnknownStroke = "UnknownStroke";

        public const string UnknownStroke1 = "UnknownStroke1";

        public const string UnknownStroke3 = "UnknownStroke3";

        public const string UnexpectedStroke = "UnexpectedStroke";

        public const string DuplicateStrokeAdded = "DuplicateStrokeAdded";

        public const string InvalidGuid = "InvalidGuid";

        public const string InvalidValueType = "InvalidValueType";

        public const string InvalidValueType1 = "InvalidValueType1";

        public const string InvalidSttValue = "InvalidSttValue";

        public const string InvalidValueOfType = "InvalidValueOfType";

        public const string InitializingCompressorFailed = "InitializingCompressorFailed";

        public const string DecompressPacketDataFailed = "DecompressPacketDataFailed";

        public const string DecompressPropertyFailed = "DecompressPropertyFailed";

        public const string InvalidEpInIsf = "InvalidEpInIsf";

        public const string EmptyDataToLoad = "EmptyDataToLoad";

        public const string IsfOperationFailed = "IsfOperationFailed";

        public const string InvalidStream = "InvalidStream";

        public const string InvalidDataTypeForExtendedProperty = "InvalidDataTypeForExtendedProperty";

        public const string MatrixNotInvertible = "MatrixNotInvertible";

        public const string InvalidSizeSpecified = "InvalidSizeSpecified";

        public const string InvalidDataInISF = "InvalidDataInISF";

        public const string InvalidBufferLength = "InvalidBufferLength";

        public const string EndOfStreamReached = "EndOfStreamReached";

        public const string CountOfBitsOutOfRange = "CountOfBitsOutOfRange";

        public const string CountOfBitsGreatThanRemainingBits = "CountOfBitsGreatThanRemainingBits";

        public const string ConstructorRecursion = "ConstructorRecursion";

        public const string InvalidMatrixContainsNaN = "InvalidMatrixContainsNaN";

        public const string InvalidMatrixContainsInfinity = "InvalidMatrixContainsInfinity";

        public const string GestureRecognizerNotAvailable = "GestureRecognizerNotAvailable";

        public const string ApplicationGestureArrayLengthIsZero = "ApplicationGestureArrayLengthIsZero";

        public const string AllGesturesMustExistAlone = "AllGesturesMustExistAlone";

        public const string ApplicationGestureIsInvalid = "ApplicationGestureIsInvalid";

        public const string DuplicateApplicationGestureFound = "DuplicateApplicationGestureFound";

        public const string UnspecifiedGestureException = "UnspecifiedGestureException";

        public const string UnspecifiedGestureConstructionException = "UnspecifiedGestureConstructionException";

        public const string UnspecifiedSetEnabledGesturesException = "UnspecifiedSetEnabledGesturesException";

        public const string StrokeCollectionCountTooBig = "StrokeCollectionCountTooBig";

        public const string InvalidPressureValue = "InvalidPressureValue";

        public const string InvalidStylusPointProperty = "InvalidStylusPointProperty";

        public const string InvalidIsButtonForId = "InvalidIsButtonForId";

        public const string InvalidIsButtonForId2 = "InvalidIsButtonForId2";

        public const string InvalidStylusPointDescription = "InvalidStylusPointDescription";

        public const string InvalidStylusPointDescriptionDuplicatesFound = "InvalidStylusPointDescriptionDuplicatesFound";

        public const string IncompatibleStylusPointDescriptions = "IncompatibleStylusPointDescriptions";

        public const string InvalidStylusPointDescriptionButtonsMustBeLast = "InvalidStylusPointDescriptionButtonsMustBeLast";

        public const string InvalidMinMaxForButton = "InvalidMinMaxForButton";

        public const string InvalidStylusPointDescriptionSubset = "InvalidStylusPointDescriptionSubset";

        public const string InvalidStylusPointCollectionZeroCount = "InvalidStylusPointCollectionZeroCount";

        public const string InvalidAdditionalDataForStylusPoint = "InvalidAdditionalDataForStylusPoint";

        public const string InvalidStylusPointDescriptionTooManyButtons = "InvalidStylusPointDescriptionTooManyButtons";

        public const string InvalidStylusPointConstructionZeroLengthCollection = "InvalidStylusPointConstructionZeroLengthCollection";

        public const string InvalidStylusPointPropertyInfoResolution = "InvalidStylusPointPropertyInfoResolution";

        public const string InvalidStylusPointXYNaN = "InvalidStylusPointXYNaN";

        public const string Image_DecoderError = "Image_DecoderError";

        public const string Image_HeaderError = "Image_HeaderError";

        public const string Image_UnknownFormat = "Image_UnknownFormat";

        public const string Image_ColorTransformInvalid = "Image_ColorTransformInvalid";

        public const string Image_ColorContextInvalid = "Image_ColorContextInvalid";

        public const string Effect_No_InputSource = "Effect_No_InputSource";

        public const string Effect_No_ContextInputSource = "Effect_No_ContextInputSource";

        public const string Effect_InvalidInput = "Effect_InvalidInput";

        public const string Visual_No_Effect_Input = "Visual_No_Effect_Input";

        public const string Visual_No_Effect = "Visual_No_Effect";

        public const string Transform_No_Effect = "Transform_No_Effect";

        public const string Transform_No_Effect_Input = "Transform_No_Effect_Input";

        public const string Effect_Not_Affine = "Effect_Not_Affine";

        public const string GeneralTransform_TransformFailed = "GeneralTransform_TransformFailed";

        public const string Effect_UnknownProperty = "Effect_UnknownProperty";

        public const string Effect_ConnectorNotConnected = "Effect_ConnectorNotConnected";

        public const string Effect_ConnectorNotAssociatedWithEffect = "Effect_ConnectorNotAssociatedWithEffect";

        public const string Effect_CycleDetected = "Effect_CycleDetected";

        public const string Effect_NoChildren = "Effect_NoChildren";

        public const string Effect_EmptyAreaBounds = "Effect_EmptyAreaBounds";

        public const string Effect_OutputSizeTooLarge = "Effect_OutputSizeTooLarge";

        public const string Effect_CombinedLegacyAndNew = "Effect_CombinedLegacyAndNew";

        public const string Effect_ShaderConstantType = "Effect_ShaderConstantType";

        public const string Effect_ShaderConstantRegisterLimit = "Effect_ShaderConstantRegisterLimit";

        public const string Effect_ShaderSamplerType = "Effect_ShaderSamplerType";

        public const string Effect_ShaderSamplerRegisterLimit = "Effect_ShaderSamplerRegisterLimit";

        public const string Effect_ShaderDdxUvDdyUvRegisterIndex = "Effect_ShaderDdxUvDdyUvRegisterIndex";

        public const string Effect_ShaderPixelShaderSet = "Effect_ShaderPixelShaderSet";

        public const string Effect_SourceUriMustBeFileOrPack = "Effect_SourceUriMustBeFileOrPack";

        public const string Effect_ShaderSeekableStream = "Effect_ShaderSeekableStream";

        public const string Effect_ShaderBytecodeSize = "Effect_ShaderBytecodeSize";

        public const string Effect_ShaderBytecodeSource = "Effect_ShaderBytecodeSource";

        public const string Effect_RenderThreadError = "Effect_RenderThreadError";

        public const string Effect_ShaderEffectPadding = "Effect_ShaderEffectPadding";

        public const string Automation_UnsupportedUIAutomationEventAssociation = "Automation_UnsupportedUIAutomationEventAssociation";

        public const string NonPackAppAbsoluteUriNotAllowed = "NonPackAppAbsoluteUriNotAllowed";

        public const string WrongFirstSegment = "WrongFirstSegment";

        public const string Geometry_BadNumber = "Geometry_BadNumber";

        public const string StreamGeometry_NeedBeginFigure = "StreamGeometry_NeedBeginFigure";

        public const string PaginatorNegativePageNumber = "PaginatorNegativePageNumber";

        public const string PaginatorMissingContentPosition = "PaginatorMissingContentPosition";

        public const string Automation_RecursivePublicCall = "Automation_RecursivePublicCall";

        public const string Automation_InvalidEventId = "Automation_InvalidEventId";

        public const string Automation_InvalidConnectedPeer = "Automation_InvalidConnectedPeer";

        public const string XmlLangMalformed = "XmlLangMalformed";

        public const string XmlLangGetSpecificCulture = "XmlLangGetSpecificCulture";

        public const string XmlLangGetCultureFailure = "XmlLangGetCultureFailure";

        public const string Invalid_URI = "Invalid_URI";

        public const string Freezable_CloneInvalidType = "Freezable_CloneInvalidType";
    }
}
