using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MS.Internal.Text.TextInterface.Interfaces
{
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("cca920e4-52f0-492b-bfa8-29c72ee0a468")]
	[ComImport]
	internal interface IDWriteFontCollectionLoaderMirror
	{
		[SecurityCritical]
		[PreserveSig]
		unsafe int CreateEnumeratorFromKey(IntPtr factory, [In] void* collectionKey, [MarshalAs(UnmanagedType.U4)] [In] uint collectionKeySize, IntPtr* fontFileEnumerator);
	}
}
