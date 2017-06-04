using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface.Generics
{
	internal abstract class NativePointerCriticalHandle<MS::Internal::Text::TextInterface::Native::IDWriteNumberSubstitution> : CriticalHandle
	{
		[SecurityCritical]
		public unsafe NativePointerCriticalHandle<MS::Internal::Text::TextInterface::Native::IDWriteNumberSubstitution>(void* pNativePointer)
		{
		}

		public override bool IsInvalid
		{
			[SecuritySafeCritical, ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			[return: MarshalAs(UnmanagedType.U1)]
			get
			{
			}
		}

		public unsafe IDWriteNumberSubstitution* Value
		{
			[SecurityCritical]
			get
			{
			}
		}
	}
}
