using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace MS.Internal.Text.TextInterface.Generics
{
	internal abstract class NativePointerCriticalHandle<_GUID> : CriticalHandle
	{
		[SecurityCritical]
		public unsafe NativePointerCriticalHandle<_GUID>(void* pNativePointer)
		{
		}

		public override bool IsInvalid
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success), SecuritySafeCritical]
			[return: MarshalAs(UnmanagedType.U1)]
			get
			{
			}
		}

		public unsafe _GUID* Value
		{
			[SecurityCritical]
			get
			{
			}
		}
	}
}
