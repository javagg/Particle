using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MS.Internal.Text.TextInterface
{
	[SecurityCritical]
	internal unsafe delegate int CreateTextAnalysisSource(ushort* text, uint length, ushort* culture, void* factory, [MarshalAs(UnmanagedType.U1)] bool isRightToLeft, ushort* numberCulture, [MarshalAs(UnmanagedType.U1)] bool ignoreUserOverride, uint numberSubstitutionMethod, void** ppTextAnalysisSource);
}
