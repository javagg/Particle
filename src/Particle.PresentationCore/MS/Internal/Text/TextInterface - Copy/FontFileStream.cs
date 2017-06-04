using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using MS.Internal.Text.TextInterface.Interfaces;

namespace MS.Internal.Text.TextInterface
{
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), SecurityCritical(SecurityCriticalScope.Everything)]
	internal class FontFileStream : IDWriteFontFileStreamMirror, IDisposable
	{
		public FontFileStream(IFontSource fontSource)
		{
		}

		public FontFileStream()
		{
		}

		[SecurityCritical, ComVisible(true)]
		public unsafe virtual int ReadFileFragment(void** fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext)
		{
		}

		[SecurityCritical, ComVisible(true)]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		public unsafe virtual void ReleaseFileFragment(void* fragmentContext)
		{
		}

		[SecurityCritical, ComVisible(true)]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		public unsafe virtual int GetFileSize(ulong* fileSize)
		{
		}

		[ComVisible(true)]
		public unsafe virtual int GetLastWriteTime(ulong* lastWriteTime)
		{
		}

		protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
		{
		}

		public sealed override void Dispose()
		{
		}
	}
}
