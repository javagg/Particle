using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface.Generics
{
	internal class NativePointerWrapper<MS::Internal::Text::TextInterface::Native::DWRITE_SCRIPT_ANALYSIS> : NativePointerCriticalHandle<MS::Internal::Text::TextInterface::Native::DWRITE_SCRIPT_ANALYSIS>
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success), SecuritySafeCritical]
		[return: MarshalAs(UnmanagedType.U1)]
		protected override bool ReleaseHandle()
		{
		}

		[SecurityCritical]
		public unsafe NativePointerWrapper<MS::Internal::Text::TextInterface::Native::DWRITE_SCRIPT_ANALYSIS>(DWRITE_SCRIPT_ANALYSIS* pNativePointer)
		{
		}
	}
}
