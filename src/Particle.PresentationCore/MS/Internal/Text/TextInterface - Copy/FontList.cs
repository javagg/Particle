using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using MS.Internal.Text.TextInterface.Generics;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface
{
	[SecurityCritical(SecurityCriticalScope.Everything)]
	internal class FontList : IEnumerable<Font>
	{
		protected NativeIUnknownWrapper<MS::Internal::Text::TextInterface::Native::IDWriteFontList> FontListObject
		{
			get
			{
			}
		}

		internal unsafe FontList(IDWriteFontList* fontList)
		{
		}

		internal Font this[uint A_0]
		{
			get
			{
			}
		}

		internal uint Count
		{
			get
			{
			}
		}

		internal FontCollection FontsCollection
		{
			get
			{
			}
		}

		public virtual IEnumerator<Font> GetEnumerator()
		{
		}

		public IEnumerator GetEnumerator2()
		{
		}

		public class FontsEnumerator : IEnumerator<Font>
		{
			public FontsEnumerator(FontList fontList)
			{
			}

			[return: MarshalAs(UnmanagedType.U1)]
			public virtual bool MoveNext()
			{
			}

			public virtual Font Current
			{
				get
				{
				}
			}

			public object Current2
			{
				get
				{
				}
			}

			public virtual void Reset()
			{
			}

			protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
			{
			}

			public sealed override void Dispose()
			{
			}

			public FontList _fontList;

			public long _currentIndex;
		}
	}
}
