using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
//using MS.Internal.Text.TextInterface.Generics;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface
{
	[SecurityCritical(SecurityCriticalScope.Everything)]
	internal class FontList : IEnumerable<Font>
	{
//		protected NativeIUnknownWrapper<MS::Internal::Text::TextInterface::Native::IDWriteFontList> FontListObject
//		{
//			get
//			{
//			}
//		}

		internal unsafe FontList(IDWriteFontList* fontList)
		{
		}

		internal Font this[uint A_0]
		{
			get { return null; }
		}

		internal uint Count
		{
			get
			{return 0;
			}
		}

		internal FontCollection FontsCollection
		{
			get
			{
			    return null;
            }
		}

		public virtual IEnumerator<Font> GetEnumerator()
		{
		    return null;
        }

		public IEnumerator GetEnumerator2()
		{
		    return null;
        }

		public class FontsEnumerator : IEnumerator<Font>
		{
			public FontsEnumerator(FontList fontList)
			{
			}

			[return: MarshalAs(UnmanagedType.U1)]
			public virtual bool MoveNext()
			{
			    return false;
            }

			public virtual Font Current
			{
				get
				{
				    return null;
                }
			}

			public object Current2
			{
				get
				{
				    return null;
                }
			}

			public virtual void Reset()
			{
			}

		    object IEnumerator.Current
		    {
		        get { return Current; }
		    }

		    protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
			{
			}

//			public sealed override void Dispose()
//			{
//			}

			public FontList _fontList;

			public long _currentIndex;
		    public void Dispose()
		    {
		        throw new NotImplementedException();
		    }
		}

	    IEnumerator IEnumerable.GetEnumerator()
	    {
	        return GetEnumerator();
	    }
	}
}
