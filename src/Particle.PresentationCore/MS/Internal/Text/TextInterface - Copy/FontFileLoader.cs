using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using MS.Internal.Text.TextInterface.Interfaces;

namespace MS.Internal.Text.TextInterface
{
	[ComVisible(true), SecurityCritical(SecurityCriticalScope.Everything), ClassInterface(ClassInterfaceType.None)]
	internal class FontFileLoader : IDWriteFontFileLoaderMirror
	{
		public FontFileLoader(IFontSourceFactory fontSourceFactory)
		{
		}

		public FontFileLoader()
		{
		}

		[SecurityCritical, ComVisible(true)]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		public unsafe virtual int CreateStreamFromKey(void* fontFileReferenceKey, uint fontFileReferenceKeySize, IntPtr* fontFileStream)
		{
		}
	}
}
