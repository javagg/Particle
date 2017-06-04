using System;
using System.Security;
using System.Security.Permissions;

namespace MS.Internal.Text.TextInterface.Native
{
	internal sealed class Util
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		public static void ConvertHresultToException(int hr)
		{
		}

		[SecurityCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		public unsafe static char* GetPtrToStringChars(string s)
		{
		}

		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		public unsafe static _GUID ToGUID(Guid* guid)
		{
		}
	}
}
