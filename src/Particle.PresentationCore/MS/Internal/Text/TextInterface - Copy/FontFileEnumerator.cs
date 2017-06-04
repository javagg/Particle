using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using MS.Internal.Text.TextInterface.Interfaces;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface
{
	[ComVisible(true), SecurityCritical(SecurityCriticalScope.Everything), ClassInterface(ClassInterfaceType.None)]
	internal class FontFileEnumerator : IDWriteFontFileEnumeratorMirror
	{
		public unsafe FontFileEnumerator(IEnumerable<IFontSource> fontSourceCollection, FontFileLoader fontFileLoader, IDWriteFactory* factory)
		{
		}

		public FontFileEnumerator()
		{
		}

		[SecurityCritical, ComVisible(true)]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		public virtual int MoveNext(ref bool hasCurrentFile)
		{
		}

		[ComVisible(true)]
		public unsafe virtual int GetCurrentFontFile(IDWriteFontFile** fontFile)
		{
		}
	}
}
