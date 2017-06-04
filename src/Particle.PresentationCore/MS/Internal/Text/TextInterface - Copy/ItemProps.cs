using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace MS.Internal.Text.TextInterface
{
	internal sealed class ItemProps
	{
		public unsafe void* NumberSubstitutionNoAddRef
		{
			[SecurityCritical]
			get
			{
			}
		}

		public unsafe void* ScriptAnalysis
		{
			[SecurityCritical]
			get
			{
			}
		}

		public CultureInfo DigitCulture
		{
			get
			{
			}
		}

		public bool HasExtendedCharacter
		{
			[return: MarshalAs(UnmanagedType.U1)]
			get
			{
			}
		}

		public bool NeedsCaretInfo
		{
			[return: MarshalAs(UnmanagedType.U1)]
			get
			{
			}
		}

		public bool IsIndic
		{
			[return: MarshalAs(UnmanagedType.U1)]
			get
			{
			}
		}

		public bool IsLatin
		{
			[return: MarshalAs(UnmanagedType.U1)]
			get
			{
			}
		}

		public bool HasCombiningMark
		{
			[return: MarshalAs(UnmanagedType.U1)]
			get
			{
			}
		}

		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		[return: MarshalAs(UnmanagedType.U1)]
		public bool CanShapeTogether(ItemProps other)
		{
		}

		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		public ItemProps()
		{
		}

		[SecurityCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		public unsafe static ItemProps Create(void* scriptAnalysis, void* numberSubstitution, CultureInfo digitCulture, [MarshalAs(UnmanagedType.U1)] bool hasCombiningMark, [MarshalAs(UnmanagedType.U1)] bool needsCaretInfo, [MarshalAs(UnmanagedType.U1)] bool hasExtendedCharacter, [MarshalAs(UnmanagedType.U1)] bool isIndic, [MarshalAs(UnmanagedType.U1)] bool isLatin)
		{
		}
	}
}
