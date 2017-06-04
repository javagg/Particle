using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MS.Internal.Text.TextInterface.Interfaces
{
	[Guid("727cad4e-d6af-4c9e-8a08-d695b11caa49"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	internal interface IDWriteFontFileLoaderMirror
	{
		[SecurityCritical]
		[PreserveSig]
		unsafe int CreateStreamFromKey([In] void* fontFileReferenceKey, [MarshalAs(UnmanagedType.U4)] [In] uint fontFileReferenceKeySize, [Out] IntPtr* fontFileStream);
	}
}
