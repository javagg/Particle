using System;
using System.Runtime.InteropServices;
using System.Security;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface.Interfaces
{
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("72755049-5ff7-435d-8348-4be97cfa6c7c")]
	[ComImport]
	internal interface IDWriteFontFileEnumeratorMirror
	{
		[PreserveSig]
		int MoveNext([MarshalAs(UnmanagedType.Bool)] out bool hasCurrentFile);

		[SecurityCritical]
		[PreserveSig]
		unsafe int GetCurrentFontFile(IDWriteFontFile** fontFile);
	}
}
