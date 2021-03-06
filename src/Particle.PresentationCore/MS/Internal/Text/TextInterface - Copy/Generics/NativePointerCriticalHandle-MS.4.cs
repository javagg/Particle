﻿using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface.Generics
{
	internal abstract class NativePointerCriticalHandle<MS::Internal::Text::TextInterface::Native::IDWriteFontList> : CriticalHandle
	{
		[SecurityCritical]
		public unsafe NativePointerCriticalHandle<MS::Internal::Text::TextInterface::Native::IDWriteFontList>(void* pNativePointer)
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

		public unsafe IDWriteFontList* Value
		{
			[SecurityCritical]
			get
			{
			}
		}
	}
}
