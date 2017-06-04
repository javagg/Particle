using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MS.Internal.Text.TextInterface.Interfaces
{
	[Guid("6d4865fe-0ab8-4d91-8f62-5dd6be34a3e0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	internal interface IDWriteFontFileStreamMirror
	{
		[SecurityCritical]
		[PreserveSig]
		unsafe int ReadFileFragment([Out] void** fragmentStart, [MarshalAs(UnmanagedType.U8)] [In] ulong fileOffset, [MarshalAs(UnmanagedType.U8)] [In] ulong fragmentSize, [Out] void** fragmentContext);

		[SecurityCritical]
		[PreserveSig]
		unsafe void ReleaseFileFragment([In] void* fragmentContext);

		[SecurityCritical]
		[PreserveSig]
		unsafe int GetFileSize([Out] ulong* fileSize);

		[SecurityCritical]
		[PreserveSig]
		unsafe int GetLastWriteTime([Out] ulong* lastWriteTime);
	}
}
