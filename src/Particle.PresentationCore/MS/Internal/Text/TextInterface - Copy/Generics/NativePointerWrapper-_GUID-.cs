using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace MS.Internal.Text.TextInterface.Generics
{
	internal class NativePointerWrapper<_GUID> : NativePointerCriticalHandle<_GUID>
	{
		[SecuritySafeCritical, ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[return: MarshalAs(UnmanagedType.U1)]
		protected override bool ReleaseHandle()
		{
		}

		[SecurityCritical]
		public unsafe NativePointerWrapper<_GUID>(_GUID* pNativePointer)
		{
		}
	}
}
