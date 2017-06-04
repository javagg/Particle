using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using MS.Internal.Text.TextInterface.Interfaces;

namespace MS.Internal.Text.TextInterface
{
	[ComVisible(true), SecurityCritical(SecurityCriticalScope.Everything), ClassInterface(ClassInterfaceType.None)]
	internal class FontCollectionLoader : IDWriteFontCollectionLoaderMirror
	{
		public FontCollectionLoader(IFontSourceCollectionFactory fontSourceCollectionFactory, FontFileLoader fontFileLoader)
		{
		}

		public FontCollectionLoader()
		{
		}

		[SecurityCritical, ComVisible(true)]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		public unsafe virtual int CreateEnumeratorFromKey(IntPtr factory, void* collectionKey, uint collectionKeySize, IntPtr* fontFileEnumerator)
		{
		}
	}
}
