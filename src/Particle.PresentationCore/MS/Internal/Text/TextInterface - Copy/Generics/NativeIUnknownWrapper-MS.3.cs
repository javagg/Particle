using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface.Generics
{
	internal class NativeIUnknownWrapper<MS::Internal::Text::TextInterface::Native::IDWriteFontFace> : NativePointerCriticalHandle<MS::Internal::Text::TextInterface::Native::IDWriteFontFace>
	{
		[SecuritySafeCritical, ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[return: MarshalAs(UnmanagedType.U1)]
		protected override bool ReleaseHandle()
		{
		}

		[SecurityCritical]
		public unsafe NativeIUnknownWrapper<MS::Internal::Text::TextInterface::Native::IDWriteFontFace>(IUnknown* pNativePointer)
		{
		}
	}
}
