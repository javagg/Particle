using System;
using System.Runtime.InteropServices;
using System.Security;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface
{
	internal sealed class FontCollection
	{
//		[SecurityCritical]
//		internal unsafe FontCollection(IDWriteFontCollection* fontCollection)
//		{
//		}

		internal uint FamilyCount { [SecuritySafeCritical] get; }

		internal FontFamily this[string familyName] { get { return null; }}

	    internal FontFamily this[uint familyIndex]
	    {
	        [SecuritySafeCritical] get { return null; }
	    }
		[SecuritySafeCritical]
		[return: MarshalAs(UnmanagedType.U1)]
		internal bool FindFamilyName(string familyName, out uint index)
		{
		    index = 0;
		    return false;
		}

		[SecuritySafeCritical]
		internal Font GetFontFromFontFace(FontFace fontFace)
		{
		    return null;
		}
	}
}
