using System.Resources;
using System.Runtime.InteropServices;

namespace MS.Internal.WindowsBase
{
	internal static class SR
	{
		internal static string Get(string id) => "";

	    internal static string Get(string id, params object[] args) => "";

	    internal static ResourceManager ResourceManager => null;
	}
}

namespace MS.Internal.WindowsBase
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

		public const string WPF_UILanguage = "WPF_UILanguage";

		public const string Rect_CannotModifyEmptyRect = "Rect_CannotModifyEmptyRect";

		public const string Rect_CannotCallMethod = "Rect_CannotCallMethod";

		public const string Size_WidthAndHeightCannotBeNegative = "Size_WidthAndHeightCannotBeNegative";

		public const string Size_WidthCannotBeNegative = "Size_WidthCannotBeNegative";

		public const string Size_HeightCannotBeNegative = "Size_HeightCannotBeNegative";

		public const string Size_CannotModifyEmptySize = "Size_CannotModifyEmptySize";

		public const string Transform_NotInvertible = "Transform_NotInvertible";

		public const string General_Expected_Type = "General_Expected_Type";

		public const string ReferenceIsNull = "ReferenceIsNull";

		public const string ParameterMustBeBetween = "ParameterMustBeBetween";

		public const string Freezable_UnregisteredHandler = "Freezable_UnregisteredHandler";

		public const string Freezable_AttemptToUseInnerValueWithDifferentThread = "Freezable_AttemptToUseInnerValueWithDifferentThread";

		public const string Freezable_CantFreeze = "Freezable_CantFreeze";

		public const string Freezable_NotAContext = "Freezable_NotAContext";

		public const string FrugalList_TargetMapCannotHoldAllData = "FrugalList_TargetMapCannotHoldAllData";

		public const string FrugalList_CannotPromoteBeyondArray = "FrugalList_CannotPromoteBeyondArray";

		public const string FrugalMap_TargetMapCannotHoldAllData = "FrugalMap_TargetMapCannotHoldAllData";

		public const string FrugalMap_CannotPromoteBeyondHashtable = "FrugalMap_CannotPromoteBeyondHashtable";

		public const string Unsupported_Key = "Unsupported_Key";

		public const string InvalidPriority = "InvalidPriority";

		public const string InvalidPriorityRangeOrder = "InvalidPriorityRangeOrder";

		public const string DispatcherHasShutdown = "DispatcherHasShutdown";

		public const string ThreadMayNotWaitOnOperationsAlreadyExecutingOnTheSameThread = "ThreadMayNotWaitOnOperationsAlreadyExecutingOnTheSameThread";

		public const string VerifyAccess = "VerifyAccess";

		public const string MismatchedDispatchers = "MismatchedDispatchers";

		public const string DispatcherProcessingDisabledButStillPumping = "DispatcherProcessingDisabledButStillPumping";

		public const string DispatcherProcessingDisabled = "DispatcherProcessingDisabled";

		public const string DispatcherPriorityAwaiterInvalid = "DispatcherPriorityAwaiterInvalid";

		public const string DispatcherYieldNoAvailableDispatcher = "DispatcherYieldNoAvailableDispatcher";

		public const string ExceptionFilterCodeNotPresent = "ExceptionFilterCodeNotPresent";

		public const string Unsupported_Modifier = "Unsupported_Modifier";

		public const string TimeSpanPeriodOutOfRange_TooSmall = "TimeSpanPeriodOutOfRange_TooSmall";

		public const string TimeSpanPeriodOutOfRange_TooLarge = "TimeSpanPeriodOutOfRange_TooLarge";

		public const string ClearOnReadOnlyObjectNotAllowed = "ClearOnReadOnlyObjectNotAllowed";

		public const string DefaultValueAutoAssignFailed = "DefaultValueAutoAssignFailed";

		public const string DefaultValueMayNotBeExpression = "DefaultValueMayNotBeExpression";

		public const string DefaultValueMayNotBeUnset = "DefaultValueMayNotBeUnset";

		public const string DefaultValueMustBeFreeThreaded = "DefaultValueMustBeFreeThreaded";

		public const string DefaultValuePropertyTypeMismatch = "DefaultValuePropertyTypeMismatch";

		public const string DefaultValueInvalid = "DefaultValueInvalid";

		public const string DTypeNotSupportForSystemType = "DTypeNotSupportForSystemType";

		public const string InvalidPropertyValue = "InvalidPropertyValue";

		public const string LocalValueEnumerationOutOfBounds = "LocalValueEnumerationOutOfBounds";

		public const string LocalValueEnumerationReset = "LocalValueEnumerationReset";

		public const string LocalValueEnumerationInvalidated = "LocalValueEnumerationInvalidated";

		public const string MissingCreateDefaultValue = "MissingCreateDefaultValue";

		public const string OverridingMetadataDoesNotMatchBaseMetadataType = "OverridingMetadataDoesNotMatchBaseMetadataType";

		public const string PropertyAlreadyRegistered = "PropertyAlreadyRegistered";

		public const string PropertyNotReadOnly = "PropertyNotReadOnly";

		public const string ReadOnlyChangeNotAllowed = "ReadOnlyChangeNotAllowed";

		public const string ReadOnlyKeyNotAuthorized = "ReadOnlyKeyNotAuthorized";

		public const string ReadOnlyOverrideNotAllowed = "ReadOnlyOverrideNotAllowed";

		public const string ReadOnlyOverrideKeyNotAuthorized = "ReadOnlyOverrideKeyNotAuthorized";

		public const string ReadOnlyDesignerCoersionNotAllowed = "ReadOnlyDesignerCoersionNotAllowed";

		public const string SetOnReadOnlyObjectNotAllowed = "SetOnReadOnlyObjectNotAllowed";

		public const string ShareableExpressionsCannotChangeSources = "ShareableExpressionsCannotChangeSources";

		public const string SharingNonSharableExpression = "SharingNonSharableExpression";

		public const string SpecialMethodMustBePublic = "SpecialMethodMustBePublic";

		public const string SourcesMustBeInSameThread = "SourcesMustBeInSameThread";

		public const string SourceChangeExpressionMismatch = "SourceChangeExpressionMismatch";

		public const string TooManyDependencyProperties = "TooManyDependencyProperties";

		public const string TypeMetadataAlreadyInUse = "TypeMetadataAlreadyInUse";

		public const string TypeMetadataAlreadyRegistered = "TypeMetadataAlreadyRegistered";

		public const string TypeMustBeDependencyObjectDerived = "TypeMustBeDependencyObjectDerived";

		public const string UnknownExpressionMode = "UnknownExpressionMode";

		public const string BufferTooSmall = "BufferTooSmall";

		public const string BufferOffsetNegative = "BufferOffsetNegative";

		public const string CompoundFilePathNullEmpty = "CompoundFilePathNullEmpty";

		public const string CanNotCreateContainerOnReadOnlyStream = "CanNotCreateContainerOnReadOnlyStream";

		public const string CanNotCreateAsReadOnly = "CanNotCreateAsReadOnly";

		public const string CanNotCreateInReadOnly = "CanNotCreateInReadOnly";

		public const string CanNotCreateStorageRootOnNonReadableStream = "CanNotCreateStorageRootOnNonReadableStream";

		public const string CanNotDelete = "CanNotDelete";

		public const string CanNotDeleteAccessDenied = "CanNotDeleteAccessDenied";

		public const string CanNotCreateAccessDenied = "CanNotCreateAccessDenied";

		public const string CanNotDeleteInReadOnly = "CanNotDeleteInReadOnly";

		public const string CanNotDeleteNonEmptyStorage = "CanNotDeleteNonEmptyStorage";

		public const string CanNotDeleteRoot = "CanNotDeleteRoot";

		public const string CanNotOnNonExistStorage = "CanNotOnNonExistStorage";

		public const string CanNotOpenStorage = "CanNotOpenStorage";

		public const string ContainerNotFound = "ContainerNotFound";

		public const string ContainerCanNotOpen = "ContainerCanNotOpen";

		public const string CreateModeMustBeCreateOrOpen = "CreateModeMustBeCreateOrOpen";

		public const string CFAPIFailure = "CFAPIFailure";

		public const string DataSpaceLabelInUse = "DataSpaceLabelInUse";

		public const string DataSpaceLabelInvalidEmpty = "DataSpaceLabelInvalidEmpty";

		public const string DataSpaceLabelUndefined = "DataSpaceLabelUndefined";

		public const string DataSpaceManagerDisposed = "DataSpaceManagerDisposed";

		public const string DataSpaceMapEntryInvalid = "DataSpaceMapEntryInvalid";

		public const string FileAccessInvalid = "FileAccessInvalid";

		public const string FileAlreadyExists = "FileAlreadyExists";

		public const string FileModeUnsupported = "FileModeUnsupported";

		public const string FileModeInvalid = "FileModeInvalid";

		public const string FileShareUnsupported = "FileShareUnsupported";

		public const string FileShareInvalid = "FileShareInvalid";

		public const string ILockBytesStreamMustSeek = "ILockBytesStreamMustSeek";

		public const string InvalidArgumentValue = "InvalidArgumentValue";

		public const string InvalidCondition01 = "InvalidCondition01";

		public const string InvalidStringFormat = "InvalidStringFormat";

		public const string InvalidTableType = "InvalidTableType";

		public const string MoveToDestNotExist = "MoveToDestNotExist";

		public const string MoveToNYI = "MoveToNYI";

		public const string NameAlreadyInUse = "NameAlreadyInUse";

		public const string NameCanNotHaveDelimiter = "NameCanNotHaveDelimiter";

		public const string NamedAPIFailure = "NamedAPIFailure";

		public const string NameTableCorruptStg = "NameTableCorruptStg";

		public const string NameTableCorruptMem = "NameTableCorruptMem";

		public const string NameTableVersionMismatchRead = "NameTableVersionMismatchRead";

		public const string NameTableVersionMismatchWrite = "NameTableVersionMismatchWrite";

		public const string NYIDefault = "NYIDefault";

		public const string PathHasEmptyElement = "PathHasEmptyElement";

		public const string ReadCountNegative = "ReadCountNegative";

		public const string SeekFailed = "SeekFailed";

		public const string SeekNegative = "SeekNegative";

		public const string SeekOriginInvalid = "SeekOriginInvalid";

		public const string StorageFlagsUnsupported = "StorageFlagsUnsupported";

		public const string StorageAlreadyExist = "StorageAlreadyExist";

		public const string StreamAlreadyExist = "StreamAlreadyExist";

		public const string StorageInfoDisposed = "StorageInfoDisposed";

		public const string StorageNotExist = "StorageNotExist";

		public const string StorageRootDisposed = "StorageRootDisposed";

		public const string StreamInfoDisposed = "StreamInfoDisposed";

		public const string StreamLengthNegative = "StreamLengthNegative";

		public const string StreamNotExist = "StreamNotExist";

		public const string StreamNameNotValid = "StreamNameNotValid";

		public const string StreamTimeStampNotImplemented = "StreamTimeStampNotImplemented";

		public const string StringCanNotBeReservedName = "StringCanNotBeReservedName";

		public const string TimeStampNotAvailable = "TimeStampNotAvailable";

		public const string TransformLabelInUse = "TransformLabelInUse";

		public const string TransformLabelUndefined = "TransformLabelUndefined";

		public const string TransformObjectConstructorParam = "TransformObjectConstructorParam";

		public const string TransformObjectImplementIDataTransform = "TransformObjectImplementIDataTransform";

		public const string TransformObjectInitFailed = "TransformObjectInitFailed";

		public const string TransformTypeUnsupported = "TransformTypeUnsupported";

		public const string TransformStackValid = "TransformStackValid";

		public const string UnableToCreateOnStream = "UnableToCreateOnStream";

		public const string UnableToCreateStorage = "UnableToCreateStorage";

		public const string UnableToCreateStream = "UnableToCreateStream";

		public const string UnableToOpenStream = "UnableToOpenStream";

		public const string UnsupportedTypeEncounteredWhenBuildingStgEnum = "UnsupportedTypeEncounteredWhenBuildingStgEnum";

		public const string WriteFailure = "WriteFailure";

		public const string WriteOnlyUnsupported = "WriteOnlyUnsupported";

		public const string WriteSizeNegative = "WriteSizeNegative";

		public const string CFM_CorruptMetadataStream = "CFM_CorruptMetadataStream";

		public const string CFM_CorruptMetadataStream_Root = "CFM_CorruptMetadataStream_Root";

		public const string CFM_CorruptMetadataStream_DuplicateKey = "CFM_CorruptMetadataStream_DuplicateKey";

		public const string CFM_ObjectMustBeCompoundFileMetadataKey = "CFM_ObjectMustBeCompoundFileMetadataKey";

		public const string CFM_ReadOnlyContainer = "CFM_ReadOnlyContainer";

		public const string CFM_TypeTableFormat = "CFM_TypeTableFormat";

		public const string CFM_UnicodeCharInvalid = "CFM_UnicodeCharInvalid";

		public const string CFM_ValueMustBeString = "CFM_ValueMustBeString";

		public const string CFM_XMLCharInvalid = "CFM_XMLCharInvalid";

		public const string CanNotCompareDiffTypes = "CanNotCompareDiffTypes";

		public const string CFRCorrupt = "CFRCorrupt";

		public const string CFRCorruptMultiStream = "CFRCorruptMultiStream";

		public const string CFRCorruptStgFollowStm = "CFRCorruptStgFollowStm";

		public const string DelimiterLeading = "DelimiterLeading";

		public const string DelimiterTrailing = "DelimiterTrailing";

		public const string OffsetNegative = "OffsetNegative";

		public const string UnknownReferenceComponentType = "UnknownReferenceComponentType";

		public const string UnknownReferenceSerialize = "UnknownReferenceSerialize";

		public const string MalformedCompoundFilePath = "MalformedCompoundFilePath";

		public const string CannotMakeStreamLengthNegative = "CannotMakeStreamLengthNegative";

		public const string CorruptStream = "CorruptStream";

		public const string LengthNotSupported = "LengthNotSupported";

		public const string ReadBufferTooSmall = "ReadBufferTooSmall";

		public const string ReadNotSupported = "ReadNotSupported";

		public const string SeekNotSupported = "SeekNotSupported";

		public const string SetLengthNotSupported = "SetLengthNotSupported";

		public const string SetPositionNotSupported = "SetPositionNotSupported";

		public const string StreamPositionNegative = "StreamPositionNegative";

		public const string TransformParametersFixed = "TransformParametersFixed";

		public const string WriteBufferTooSmall = "WriteBufferTooSmall";

		public const string WriteCountNegative = "WriteCountNegative";

		public const string WriteNotSupported = "WriteNotSupported";

		public const string ZLibVersionError = "ZLibVersionError";

		public const string ExpectedVersionPairObject = "ExpectedVersionPairObject";

		public const string VersionNumberComponentNegative = "VersionNumberComponentNegative";

		public const string ZeroLengthFeatureID = "ZeroLengthFeatureID";

		public const string VersionStreamMissing = "VersionStreamMissing";

		public const string VersionUpdateFailure = "VersionUpdateFailure";

		public const string CannotRemoveSignatureFromReadOnlyFile = "CannotRemoveSignatureFromReadOnlyFile";

		public const string CannotSignReadOnlyFile = "CannotSignReadOnlyFile";

		public const string DigSigCannotLocateCertificate = "DigSigCannotLocateCertificate";

		public const string DigSigDuplicateCertificate = "DigSigDuplicateCertificate";

		public const string CertSelectionDialogTitle = "CertSelectionDialogTitle";

		public const string CertSelectionDialogMessage = "CertSelectionDialogMessage";

		public const string DuplicateSignature = "DuplicateSignature";

		public const string XmlSignatureParseError = "XmlSignatureParseError";

		public const string RequiredXmlAttributeMissing = "RequiredXmlAttributeMissing";

		public const string UnexpectedXmlTag = "UnexpectedXmlTag";

		public const string RequiredTagNotFound = "RequiredTagNotFound";

		public const string PackageSignatureObjectTagRequired = "PackageSignatureObjectTagRequired";

		public const string PackageSignatureReferenceTagRequired = "PackageSignatureReferenceTagRequired";

		public const string MoreThanOnePackageSpecificReference = "MoreThanOnePackageSpecificReference";

		public const string InvalidUriAttribute = "InvalidUriAttribute";

		public const string NoCounterSignUnsignedContainer = "NoCounterSignUnsignedContainer";

		public const string BadSignatureTimeFormatString = "BadSignatureTimeFormatString";

		public const string PackageSignatureCorruption = "PackageSignatureCorruption";

		public const string UnsupportedHashAlgorithm = "UnsupportedHashAlgorithm";

		public const string RelationshipTransformNotFollowedByCanonicalizationTransform = "RelationshipTransformNotFollowedByCanonicalizationTransform";

		public const string MultipleRelationshipTransformsFound = "MultipleRelationshipTransformsFound";

		public const string UnsupportedTransformAlgorithm = "UnsupportedTransformAlgorithm";

		public const string UnsupportedCanonicalizationMethod = "UnsupportedCanonicalizationMethod";

		public const string HashAlgorithmMustBeReusable = "HashAlgorithmMustBeReusable";

		public const string PartReferenceUriMalformed = "PartReferenceUriMalformed";

		public const string SignatureOriginNotFound = "SignatureOriginNotFound";

		public const string MultipleSignatureOrigins = "MultipleSignatureOrigins";

		public const string NothingToSign = "NothingToSign";

		public const string EmptySignatureId = "EmptySignatureId";

		public const string SignatureDeleted = "SignatureDeleted";

		public const string SignaturePackageObjectTagMustBeUnique = "SignaturePackageObjectTagMustBeUnique";

		public const string PackageSpecificReferenceTagMustBeUnique = "PackageSpecificReferenceTagMustBeUnique";

		public const string SignatureObjectIdMustBeUnique = "SignatureObjectIdMustBeUnique";

		public const string CanOnlyCounterSignSignatureParts = "CanOnlyCounterSignSignatureParts";

		public const string CertificatePartContentTypeMismatch = "CertificatePartContentTypeMismatch";

		public const string CertificateKeyTypeNotSupported = "CertificateKeyTypeNotSupported";

		public const string PartToSignMissing = "PartToSignMissing";

		public const string DuplicateObjectId = "DuplicateObjectId";

		public const string CallbackParameterInvalid = "CallbackParameterInvalid";

		public const string CannotChangePublishLicense = "CannotChangePublishLicense";

		public const string CannotChangeCryptoProvider = "CannotChangeCryptoProvider";

		public const string ExcessiveLengthPrefix = "ExcessiveLengthPrefix";

		public const string GetOlePropertyFailed = "GetOlePropertyFailed";

		public const string InvalidAuthenticationTypeString = "InvalidAuthenticationTypeString";

		public const string InvalidDocumentPropertyType = "InvalidDocumentPropertyType";

		public const string InvalidDocumentPropertyVariantType = "InvalidDocumentPropertyVariantType";

		public const string InvalidTypePrefixedUserName = "InvalidTypePrefixedUserName";

		public const string InvalidTransformFeatureName = "InvalidTransformFeatureName";

		public const string PackageNotFound = "PackageNotFound";

		public const string NoPublishLicenseStream = "NoPublishLicenseStream";

		public const string NoUseLicenseStorage = "NoUseLicenseStorage";

		public const string ReaderVersionError = "ReaderVersionError";

		public const string PublishLicenseStreamCorrupt = "PublishLicenseStreamCorrupt";

		public const string PublishLicenseNotFound = "PublishLicenseNotFound";

		public const string RightsManagementEncryptionTransformNotFound = "RightsManagementEncryptionTransformNotFound";

		public const string MultipleRightsManagementEncryptionTransformFound = "MultipleRightsManagementEncryptionTransformFound";

		public const string StreamNeedsReadWriteAccess = "StreamNeedsReadWriteAccess";

		public const string CryptoProviderCanNotDecrypt = "CryptoProviderCanNotDecrypt";

		public const string CryptoProviderCanNotMergeBlocks = "CryptoProviderCanNotMergeBlocks";

		public const string EncryptedPackageEnvelopeDisposed = "EncryptedPackageEnvelopeDisposed";

		public const string CryptoProviderDisposed = "CryptoProviderDisposed";

		public const string UpdaterVersionError = "UpdaterVersionError";

		public const string DictionaryIsReadOnly = "DictionaryIsReadOnly";

		public const string CryptoProviderIsNotReady = "CryptoProviderIsNotReady";

		public const string UseLicenseStreamCorrupt = "UseLicenseStreamCorrupt";

		public const string EncryptedDataStreamCorrupt = "EncryptedDataStreamCorrupt";

		public const string UnknownDocumentProperty = "UnknownDocumentProperty";

		public const string WrongDocumentPropertyVariantType = "WrongDocumentPropertyVariantType";

		public const string UserIsNotActivated = "UserIsNotActivated";

		public const string UserHasNoClientLicensorCert = "UserHasNoClientLicensorCert";

		public const string EncryptionRightIsNotGranted = "EncryptionRightIsNotGranted";

		public const string DecryptionRightIsNotGranted = "DecryptionRightIsNotGranted";

		public const string NoPrivilegesForPublishLicenseDecryption = "NoPrivilegesForPublishLicenseDecryption";

		public const string InvalidPublishLicense = "InvalidPublishLicense";

		public const string PublishLicenseStreamHeaderTooLong = "PublishLicenseStreamHeaderTooLong";

		public const string OnlyPassportOrWindowsAuthenticatedUsersAreAllowed = "OnlyPassportOrWindowsAuthenticatedUsersAreAllowed";

		public const string RmExceptionGenericMessage = "RmExceptionGenericMessage";

		public const string RmExceptionInvalidLicense = "RmExceptionInvalidLicense";

		public const string RmExceptionInfoNotInLicense = "RmExceptionInfoNotInLicense";

		public const string RmExceptionInvalidLicenseSignature = "RmExceptionInvalidLicenseSignature";

		public const string RmExceptionEncryptionNotPermitted = "RmExceptionEncryptionNotPermitted";

		public const string RmExceptionRightNotGranted = "RmExceptionRightNotGranted";

		public const string RmExceptionInvalidVersion = "RmExceptionInvalidVersion";

		public const string RmExceptionInvalidEncodingType = "RmExceptionInvalidEncodingType";

		public const string RmExceptionInvalidNumericalValue = "RmExceptionInvalidNumericalValue";

		public const string RmExceptionInvalidAlgorithmType = "RmExceptionInvalidAlgorithmType";

		public const string RmExceptionEnvironmentNotLoaded = "RmExceptionEnvironmentNotLoaded";

		public const string RmExceptionEnvironmentCannotLoad = "RmExceptionEnvironmentCannotLoad";

		public const string RmExceptionTooManyLoadedEnvironments = "RmExceptionTooManyLoadedEnvironments";

		public const string RmExceptionIncompatibleObjects = "RmExceptionIncompatibleObjects";

		public const string RmExceptionLibraryFail = "RmExceptionLibraryFail";

		public const string RmExceptionEnablingPrincipalFailure = "RmExceptionEnablingPrincipalFailure";

		public const string RmExceptionInfoNotPresent = "RmExceptionInfoNotPresent";

		public const string RmExceptionBadGetInfoQuery = "RmExceptionBadGetInfoQuery";

		public const string RmExceptionKeyTypeUnsupported = "RmExceptionKeyTypeUnsupported";

		public const string RmExceptionCryptoOperationUnsupported = "RmExceptionCryptoOperationUnsupported";

		public const string RmExceptionClockRollbackDetected = "RmExceptionClockRollbackDetected";

		public const string RmExceptionQueryReportsNoResults = "RmExceptionQueryReportsNoResults";

		public const string RmExceptionUnexpectedException = "RmExceptionUnexpectedException";

		public const string RmExceptionBindValidityTimeViolated = "RmExceptionBindValidityTimeViolated";

		public const string RmExceptionBrokenCertChain = "RmExceptionBrokenCertChain";

		public const string RmExceptionBindPolicyViolation = "RmExceptionBindPolicyViolation";

		public const string RmExceptionManifestPolicyViolation = "RmExceptionManifestPolicyViolation";

		public const string RmExceptionBindRevokedLicense = "RmExceptionBindRevokedLicense";

		public const string RmExceptionBindRevokedIssuer = "RmExceptionBindRevokedIssuer";

		public const string RmExceptionBindRevokedPrincipal = "RmExceptionBindRevokedPrincipal";

		public const string RmExceptionBindRevokedResource = "RmExceptionBindRevokedResource";

		public const string RmExceptionBindRevokedModule = "RmExceptionBindRevokedModule";

		public const string RmExceptionBindContentNotInEndUseLicense = "RmExceptionBindContentNotInEndUseLicense";

		public const string RmExceptionBindAccessPrincipalNotEnabling = "RmExceptionBindAccessPrincipalNotEnabling";

		public const string RmExceptionBindAccessUnsatisfied = "RmExceptionBindAccessUnsatisfied";

		public const string RmExceptionBindIndicatedPrincipalMissing = "RmExceptionBindIndicatedPrincipalMissing";

		public const string RmExceptionBindMachineNotFoundInGroupIdentity = "RmExceptionBindMachineNotFoundInGroupIdentity";

		public const string RmExceptionLibraryUnsupportedPlugIn = "RmExceptionLibraryUnsupportedPlugIn";

		public const string RmExceptionBindRevocationListStale = "RmExceptionBindRevocationListStale";

		public const string RmExceptionBindNoApplicableRevocationList = "RmExceptionBindNoApplicableRevocationList";

		public const string RmExceptionInvalidHandle = "RmExceptionInvalidHandle";

		public const string RmExceptionBindIntervalTimeViolated = "RmExceptionBindIntervalTimeViolated";

		public const string RmExceptionBindNoSatisfiedRightsGroup = "RmExceptionBindNoSatisfiedRightsGroup";

		public const string RmExceptionBindSpecifiedWorkMissing = "RmExceptionBindSpecifiedWorkMissing";

		public const string RmExceptionNoMoreData = "RmExceptionNoMoreData";

		public const string RmExceptionLicenseAcquisitionFailed = "RmExceptionLicenseAcquisitionFailed";

		public const string RmExceptionIdMismatch = "RmExceptionIdMismatch";

		public const string RmExceptionTooManyCertificates = "RmExceptionTooManyCertificates";

		public const string RmExceptionNoDistributionPointUrlFound = "RmExceptionNoDistributionPointUrlFound";

		public const string RmExceptionAlreadyInProgress = "RmExceptionAlreadyInProgress";

		public const string RmExceptionGroupIdentityNotSet = "RmExceptionGroupIdentityNotSet";

		public const string RmExceptionRecordNotFound = "RmExceptionRecordNotFound";

		public const string RmExceptionNoConnect = "RmExceptionNoConnect";

		public const string RmExceptionNoLicense = "RmExceptionNoLicense";

		public const string RmExceptionNeedsMachineActivation = "RmExceptionNeedsMachineActivation";

		public const string RmExceptionNeedsGroupIdentityActivation = "RmExceptionNeedsGroupIdentityActivation";

		public const string RmExceptionActivationFailed = "RmExceptionActivationFailed";

		public const string RmExceptionAborted = "RmExceptionAborted";

		public const string RmExceptionOutOfQuota = "RmExceptionOutOfQuota";

		public const string RmExceptionAuthenticationFailed = "RmExceptionAuthenticationFailed";

		public const string RmExceptionServerError = "RmExceptionServerError";

		public const string RmExceptionInstallationFailed = "RmExceptionInstallationFailed";

		public const string RmExceptionHidCorrupted = "RmExceptionHidCorrupted";

		public const string RmExceptionInvalidServerResponse = "RmExceptionInvalidServerResponse";

		public const string RmExceptionServiceNotFound = "RmExceptionServiceNotFound";

		public const string RmExceptionUseDefault = "RmExceptionUseDefault";

		public const string RmExceptionServerNotFound = "RmExceptionServerNotFound";

		public const string RmExceptionInvalidEmail = "RmExceptionInvalidEmail";

		public const string RmExceptionValidityTimeViolation = "RmExceptionValidityTimeViolation";

		public const string RmExceptionOutdatedModule = "RmExceptionOutdatedModule";

		public const string RmExceptionServiceMoved = "RmExceptionServiceMoved";

		public const string RmExceptionServiceGone = "RmExceptionServiceGone";

		public const string RmExceptionAdEntryNotFound = "RmExceptionAdEntryNotFound";

		public const string RmExceptionNotAChain = "RmExceptionNotAChain";

		public const string RmExceptionRequestDenied = "RmExceptionRequestDenied";

		public const string RmExceptionNotSet = "RmExceptionNotSet";

		public const string RmExceptionMetadataNotSet = "RmExceptionMetadataNotSet";

		public const string RmExceptionRevocationInfoNotSet = "RmExceptionRevocationInfoNotSet";

		public const string RmExceptionInvalidTimeInfo = "RmExceptionInvalidTimeInfo";

		public const string RmExceptionRightNotSet = "RmExceptionRightNotSet";

		public const string RmExceptionLicenseBindingToWindowsIdentityFailed = "RmExceptionLicenseBindingToWindowsIdentityFailed";

		public const string RmExceptionInvalidIssuanceLicenseTemplate = "RmExceptionInvalidIssuanceLicenseTemplate";

		public const string RmExceptionInvalidKeyLength = "RmExceptionInvalidKeyLength";

		public const string RmExceptionExpiredOfficialIssuanceLicenseTemplate = "RmExceptionExpiredOfficialIssuanceLicenseTemplate";

		public const string RmExceptionInvalidClientLicensorCertificate = "RmExceptionInvalidClientLicensorCertificate";

		public const string RmExceptionHidInvalid = "RmExceptionHidInvalid";

		public const string RmExceptionEmailNotVerified = "RmExceptionEmailNotVerified";

		public const string RmExceptionDebuggerDetected = "RmExceptionDebuggerDetected";

		public const string RmExceptionInvalidLockboxType = "RmExceptionInvalidLockboxType";

		public const string RmExceptionInvalidLockboxPath = "RmExceptionInvalidLockboxPath";

		public const string RmExceptionInvalidRegistryPath = "RmExceptionInvalidRegistryPath";

		public const string RmExceptionNoAesCryptoProvider = "RmExceptionNoAesCryptoProvider";

		public const string RmExceptionGlobalOptionAlreadySet = "RmExceptionGlobalOptionAlreadySet";

		public const string RmExceptionOwnerLicenseNotFound = "RmExceptionOwnerLicenseNotFound";

		public const string ZipZeroSizeFileIsNotValidArchive = "ZipZeroSizeFileIsNotValidArchive";

		public const string CanNotWriteInReadOnlyMode = "CanNotWriteInReadOnlyMode";

		public const string CanNotReadInWriteOnlyMode = "CanNotReadInWriteOnlyMode";

		public const string CanNotReadWriteInReadOnlyWriteOnlyMode = "CanNotReadWriteInReadOnlyWriteOnlyMode";

		public const string AttemptedToCreateDuplicateFileName = "AttemptedToCreateDuplicateFileName";

		public const string FileDoesNotExists = "FileDoesNotExists";

		public const string TruncateAppendModesNotSupported = "TruncateAppendModesNotSupported";

		public const string OnlyFileShareReadAndFileShareNoneSupported = "OnlyFileShareReadAndFileShareNoneSupported";

		public const string CanNotReadDataFromStreamWhichDoesNotSupportReading = "CanNotReadDataFromStreamWhichDoesNotSupportReading";

		public const string CanNotWriteDataToStreamWhichDoesNotSupportWriting = "CanNotWriteDataToStreamWhichDoesNotSupportWriting";

		public const string CanNotOperateOnStreamWhichDoesNotSupportSeeking = "CanNotOperateOnStreamWhichDoesNotSupportSeeking";

		public const string UnsupportedCombinationOfModeAccessShareStreaming = "UnsupportedCombinationOfModeAccessShareStreaming";

		public const string CorruptedData = "CorruptedData";

		public const string NotSupportedMultiDisk = "NotSupportedMultiDisk";

		public const string ZipArchiveDisposed = "ZipArchiveDisposed";

		public const string ZipFileItemDisposed = "ZipFileItemDisposed";

		public const string NotSupportedVersionNeededToExtract = "NotSupportedVersionNeededToExtract";

		public const string Zip64StructuresTooLarge = "Zip64StructuresTooLarge";

		public const string ZipNotSupportedEncryptedArchive = "ZipNotSupportedEncryptedArchive";

		public const string ZipNotSupportedSignedArchive = "ZipNotSupportedSignedArchive";

		public const string ZipNotSupportedCompressionMethod = "ZipNotSupportedCompressionMethod";

		public const string CompressLengthMismatch = "CompressLengthMismatch";

		public const string CreateNewOnNonEmptyStream = "CreateNewOnNonEmptyStream";

		public const string PartDoesNotExist = "PartDoesNotExist";

		public const string PartAlreadyExists = "PartAlreadyExists";

		public const string PartNamePrefixExists = "PartNamePrefixExists";

		public const string IncompatibleModeOrAccess = "IncompatibleModeOrAccess";

		public const string URIShouldNotBeAbsolute = "URIShouldNotBeAbsolute";

		public const string UriShouldBeAbsolute = "UriShouldBeAbsolute";

		public const string ContainerAndPartModeIncompatible = "ContainerAndPartModeIncompatible";

		public const string UnsupportedCombinationOfModeAccess = "UnsupportedCombinationOfModeAccess";

		public const string NullStreamReturned = "NullStreamReturned";

		public const string ObjectDisposed = "ObjectDisposed";

		public const string ReadOnlyStream = "ReadOnlyStream";

		public const string WriteOnlyStream = "WriteOnlyStream";

		public const string ParentContainerClosed = "ParentContainerClosed";

		public const string PackagePartDeleted = "PackagePartDeleted";

		public const string RelationshipToRelationshipIllegal = "RelationshipToRelationshipIllegal";

		public const string RelationshipPartsCannotHaveRelationships = "RelationshipPartsCannotHaveRelationships";

		public const string RelationshipPartIncorrectContentType = "RelationshipPartIncorrectContentType";

		public const string PackageRelationshipDoesNotExist = "PackageRelationshipDoesNotExist";

		public const string PackagePartRelationshipDoesNotExist = "PackagePartRelationshipDoesNotExist";

		public const string RelationshipTargetMustBeRelative = "RelationshipTargetMustBeRelative";

		public const string RequiredRelationshipAttributeMissing = "RequiredRelationshipAttributeMissing";

		public const string RelationshipTagDoesntMatchSchema = "RelationshipTagDoesntMatchSchema";

		public const string RelationshipsTagHasExtraAttributes = "RelationshipsTagHasExtraAttributes";

		public const string UnknownTagEncountered = "UnknownTagEncountered";

		public const string ExpectedRelationshipsElementTag = "ExpectedRelationshipsElementTag";

		public const string InvalidXmlBaseAttributePresent = "InvalidXmlBaseAttributePresent";

		public const string NotAUniqueRelationshipId = "NotAUniqueRelationshipId";

		public const string NotAValidXmlIdString = "NotAValidXmlIdString";

		public const string InvalidValueForTheAttribute = "InvalidValueForTheAttribute";

		public const string InvalidRelationshipType = "InvalidRelationshipType";

		public const string PartUriShouldStartWithForwardSlash = "PartUriShouldStartWithForwardSlash";

		public const string PartUriShouldNotEndWithForwardSlash = "PartUriShouldNotEndWithForwardSlash";

		public const string UriShouldBePackScheme = "UriShouldBePackScheme";

		public const string PartUriIsEmpty = "PartUriIsEmpty";

		public const string InvalidPartUri = "InvalidPartUri";

		public const string RelationshipPartUriNotExpected = "RelationshipPartUriNotExpected";

		public const string RelationshipPartUriExpected = "RelationshipPartUriExpected";

		public const string NotAValidRelationshipPartUri = "NotAValidRelationshipPartUri";

		public const string FragmentMustStartWithHash = "FragmentMustStartWithHash";

		public const string PartUriCannotHaveAFragment = "PartUriCannotHaveAFragment";

		public const string PartUriShouldNotStartWithTwoForwardSlashes = "PartUriShouldNotStartWithTwoForwardSlashes";

		public const string InnerPackageUriHasFragment = "InnerPackageUriHasFragment";

		public const string StreamObjectDisposed = "StreamObjectDisposed";

		public const string NullContentTypeProvided = "NullContentTypeProvided";

		public const string GetContentTypeCoreNotImplemented = "GetContentTypeCoreNotImplemented";

		public const string RequiredAttributeMissing = "RequiredAttributeMissing";

		public const string RequiredAttributeEmpty = "RequiredAttributeEmpty";

		public const string TypesTagHasExtraAttributes = "TypesTagHasExtraAttributes";

		public const string TypesElementExpected = "TypesElementExpected";

		public const string TypesXmlDoesNotMatchSchema = "TypesXmlDoesNotMatchSchema";

		public const string DefaultTagDoesNotMatchSchema = "DefaultTagDoesNotMatchSchema";

		public const string OverrideTagDoesNotMatchSchema = "OverrideTagDoesNotMatchSchema";

		public const string ElementIsNotEmptyElement = "ElementIsNotEmptyElement";

		public const string BadPackageFormat = "BadPackageFormat";

		public const string StreamingModeNotSupportedForConsumption = "StreamingModeNotSupportedForConsumption";

		public const string StreamingPackageProductionImpliesWriteOnlyAccess = "StreamingPackageProductionImpliesWriteOnlyAccess";

		public const string StreamingPackageProductionRequiresSingleWriter = "StreamingPackageProductionRequiresSingleWriter";

		public const string MethodAvailableOnlyInStreamingCreation = "MethodAvailableOnlyInStreamingCreation";

		public const string OperationIsNotSupportedInStreamingProduction = "OperationIsNotSupportedInStreamingProduction";

		public const string OnlyWriteOperationsAreSupportedInStreamingCreation = "OnlyWriteOperationsAreSupportedInStreamingCreation";

		public const string OperationViolatesWriteOnceSemantics = "OperationViolatesWriteOnceSemantics";

		public const string OnlyStreamingProductionIsSupported = "OnlyStreamingProductionIsSupported";

		public const string IOBufferOverflow = "IOBufferOverflow";

		public const string StreamDoesNotSupportWrite = "StreamDoesNotSupportWrite";

		public const string MoreThanOneMetadataRelationships = "MoreThanOneMetadataRelationships";

		public const string NoExternalTargetForMetadataRelationship = "NoExternalTargetForMetadataRelationship";

		public const string CorePropertiesElementExpected = "CorePropertiesElementExpected";

		public const string NoStructuredContentInsideProperties = "NoStructuredContentInsideProperties";

		public const string UnknownNamespaceInCorePropertiesPart = "UnknownNamespaceInCorePropertiesPart";

		public const string InvalidPropertyNameInCorePropertiesPart = "InvalidPropertyNameInCorePropertiesPart";

		public const string PropertyStartTagExpected = "PropertyStartTagExpected";

		public const string XsdDateTimeExpected = "XsdDateTimeExpected";

		public const string DanglingMetadataRelationship = "DanglingMetadataRelationship";

		public const string WrongContentTypeForPropertyPart = "WrongContentTypeForPropertyPart";

		public const string PropertyWrongNumbOfAttribsDefinedOn = "PropertyWrongNumbOfAttribsDefinedOn";

		public const string UnknownDCDateTimeXsiType = "UnknownDCDateTimeXsiType";

		public const string DuplicateCorePropertyName = "DuplicateCorePropertyName";

		public const string StorageBasedPackagePropertiesDiposed = "StorageBasedPackagePropertiesDiposed";

		public const string EncodingNotSupported = "EncodingNotSupported";

		public const string DuplicatePiecesFound = "DuplicatePiecesFound";

		public const string PieceDoesNotExist = "PieceDoesNotExist";

		public const string ServiceTypeAlreadyAdded = "ServiceTypeAlreadyAdded";

		public const string QualifiedNameHasWrongFormat = "QualifiedNameHasWrongFormat";

		public const string ParserAttributeArgsHigh = "ParserAttributeArgsHigh";

		public const string ParserAttributeArgsLow = "ParserAttributeArgsLow";

		public const string ParserAssemblyLoadVersionMismatch = "ParserAssemblyLoadVersionMismatch";

		public const string ToStringNull = "ToStringNull";

		public const string ConvertToException = "ConvertToException";

		public const string ConvertFromException = "ConvertFromException";

		public const string SortDescriptionPropertyNameCannotBeEmpty = "SortDescriptionPropertyNameCannotBeEmpty";

		public const string CannotChangeAfterSealed = "CannotChangeAfterSealed";

		public const string BadPropertyForGroup = "BadPropertyForGroup";

		public const string CurrentChangingCannotBeCanceled = "CurrentChangingCannotBeCanceled";

		public const string NotSupported_ReadOnlyCollection = "NotSupported_ReadOnlyCollection";

		public const string Arg_RankMultiDimNotSupported = "Arg_RankMultiDimNotSupported";

		public const string Arg_NonZeroLowerBound = "Arg_NonZeroLowerBound";

		public const string ArgumentOutOfRange_NeedNonNegNum = "ArgumentOutOfRange_NeedNonNegNum";

		public const string Arg_ArrayPlusOffTooSmall = "Arg_ArrayPlusOffTooSmall";

		public const string Argument_InvalidArrayType = "Argument_InvalidArrayType";

		public const string ReachOutOfRange = "ReachOutOfRange";

		public const string InvalidPermissionState = "InvalidPermissionState";

		public const string TargetNotWebBrowserPermissionLevel = "TargetNotWebBrowserPermissionLevel";

		public const string TargetNotMediaPermissionLevel = "TargetNotMediaPermissionLevel";

		public const string BadXml = "BadXml";

		public const string InvalidPermissionLevel = "InvalidPermissionLevel";

		public const string XCRChoiceOnlyInAC = "XCRChoiceOnlyInAC";

		public const string XCRChoiceAfterFallback = "XCRChoiceAfterFallback";

		public const string XCRRequiresAttribNotFound = "XCRRequiresAttribNotFound";

		public const string XCRInvalidRequiresAttribute = "XCRInvalidRequiresAttribute";

		public const string XCRFallbackOnlyInAC = "XCRFallbackOnlyInAC";

		public const string XCRChoiceNotFound = "XCRChoiceNotFound";

		public const string XCRMultipleFallbackFound = "XCRMultipleFallbackFound";

		public const string XCRInvalidAttribInElement = "XCRInvalidAttribInElement";

		public const string XCRUnknownCompatElement = "XCRUnknownCompatElement";

		public const string XCRInvalidACChild = "XCRInvalidACChild";

		public const string XCRInvalidFormat = "XCRInvalidFormat";

		public const string XCRUndefinedPrefix = "XCRUndefinedPrefix";

		public const string XCRUnknownCompatAttrib = "XCRUnknownCompatAttrib";

		public const string XCRNSProcessContentNotIgnorable = "XCRNSProcessContentNotIgnorable";

		public const string XCRDuplicateProcessContent = "XCRDuplicateProcessContent";

		public const string XCRInvalidProcessContent = "XCRInvalidProcessContent";

		public const string XCRDuplicateWildcardProcessContent = "XCRDuplicateWildcardProcessContent";

		public const string XCRMustUnderstandFailed = "XCRMustUnderstandFailed";

		public const string XCRNSPreserveNotIgnorable = "XCRNSPreserveNotIgnorable";

		public const string XCRDuplicatePreserve = "XCRDuplicatePreserve";

		public const string XCRInvalidPreserve = "XCRInvalidPreserve";

		public const string XCRDuplicateWildcardPreserve = "XCRDuplicateWildcardPreserve";

		public const string XCRInvalidXMLName = "XCRInvalidXMLName";

		public const string XCRCompatCycle = "XCRCompatCycle";

		public const string EventNotFound = "EventNotFound";

		public const string ListenerDidNotHandleEvent = "ListenerDidNotHandleEvent";

		public const string ListenerDidNotHandleEventDetail = "ListenerDidNotHandleEventDetail";

		public const string NoMulticastHandlers = "NoMulticastHandlers";

		public const string InvariantFailure = "InvariantFailure";

		public const string ContentTypeCannotHaveLeadingTrailingLWS = "ContentTypeCannotHaveLeadingTrailingLWS";

		public const string InvalidTypeSubType = "InvalidTypeSubType";

		public const string ExpectingParameterValuePairs = "ExpectingParameterValuePairs";

		public const string InvalidParameterValuePair = "InvalidParameterValuePair";

		public const string InvalidToken = "InvalidToken";

		public const string InvalidParameterValue = "InvalidParameterValue";

		public const string InvalidLinearWhiteSpaceCharacter = "InvalidLinearWhiteSpaceCharacter";

		public const string ExpectingSemicolon = "ExpectingSemicolon";

		public const string HwndSubclassMultipleAttach = "HwndSubclassMultipleAttach";

		public const string UnableToLocateResource = "UnableToLocateResource";

		public const string SplashScreenIsLoading = "SplashScreenIsLoading";

		public const string NameScopeNameNotEmptyString = "NameScopeNameNotEmptyString";

		public const string NameScopeNameNotFound = "NameScopeNameNotFound";

		public const string NameScopeDuplicateNamesNotAllowed = "NameScopeDuplicateNamesNotAllowed";

		public const string NameScopeNotFound = "NameScopeNotFound";

		public const string NameScopeInvalidIdentifierName = "NameScopeInvalidIdentifierName";

		public const string NoDependencyProperty = "NoDependencyProperty";

		public const string MarkupExtensionArrayType = "MarkupExtensionArrayType";

		public const string MarkupExtensionArrayBadType = "MarkupExtensionArrayBadType";

		public const string MarkupExtensionNoContext = "MarkupExtensionNoContext";

		public const string MarkupExtensionBadStatic = "MarkupExtensionBadStatic";

		public const string MarkupExtensionStaticMember = "MarkupExtensionStaticMember";

		public const string MarkupExtensionTypeName = "MarkupExtensionTypeName";

		public const string MarkupExtensionTypeNameBad = "MarkupExtensionTypeNameBad";

		public const string MustBeOfType = "MustBeOfType";

		public const string Verify_ApartmentState = "Verify_ApartmentState";

		public const string Verify_NeitherNullNorEmpty = "Verify_NeitherNullNorEmpty";

		public const string Verify_AreNotEqual = "Verify_AreNotEqual";

		public const string Verify_FileExists = "Verify_FileExists";

		public const string InvalidEvent = "InvalidEvent";

		public const string CompatibilityPreferencesSealed = "CompatibilityPreferencesSealed";
	}
}
