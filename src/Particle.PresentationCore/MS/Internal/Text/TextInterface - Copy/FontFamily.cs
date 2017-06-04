using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface
{
	[DefaultMember("Item")]
	internal sealed class FontFamily : FontList
	{
		[SecurityCritical]
		internal unsafe FontFamily(IDWriteFontFamily* fontFamily)
		{
		}

		internal LocalizedStrings FamilyNames
		{
			[SecuritySafeCritical]
			get
			{
			}
		}

		internal bool IsPhysical
		{
			[return: MarshalAs(UnmanagedType.U1)]
			get
			{
			}
		}

		internal bool IsComposite
		{
			[return: MarshalAs(UnmanagedType.U1)]
			get
			{
			}
		}

		internal string OrdinalName
		{
			get
			{
			}
		}

		internal FontMetrics Metrics
		{
			get
			{
			}
		}

		internal FontMetrics DisplayMetrics(float emSize, float pixelsPerDip)
		{
		}

		[SecuritySafeCritical]
		internal Font GetFirstMatchingFont(FontWeight weight, FontStretch stretch, FontStyle style)
		{
		}

		[SecuritySafeCritical]
		internal FontList GetMatchingFonts(FontWeight weight, FontStretch stretch, FontStyle style)
		{
		}
	}
}
