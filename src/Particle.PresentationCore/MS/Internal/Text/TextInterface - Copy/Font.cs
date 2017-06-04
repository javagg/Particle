using System;
using System.Runtime.InteropServices;
using System.Security;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface
{
	internal sealed class Font
	{
		[SecurityCritical]
		internal unsafe Font(IDWriteFont* font)
		{
		}

		internal IntPtr DWriteFontAddRef
		{
			[SecurityCritical]
			get
			{
			}
		}

		internal FontFamily Family
		{
			[SecuritySafeCritical]
			get
			{
			}
		}

		internal FontWeight Weight
		{
			[SecuritySafeCritical]
			get
			{
			}
		}

		internal FontStretch Stretch
		{
			[SecuritySafeCritical]
			get
			{
			}
		}

		internal FontStyle Style
		{
			[SecuritySafeCritical]
			get
			{
			}
		}

		internal bool IsSymbolFont
		{
			[SecuritySafeCritical]
			[return: MarshalAs(UnmanagedType.U1)]
			get
			{
			}
		}

		internal LocalizedStrings FaceNames
		{
			[SecuritySafeCritical]
			get
			{
			}
		}

		internal FontSimulations SimulationFlags
		{
			[SecuritySafeCritical]
			get
			{
			}
		}

		internal FontMetrics Metrics
		{
			[SecuritySafeCritical]
			get
			{
			}
		}

		internal double Version
		{
			get
			{
			}
		}

		[SecuritySafeCritical]
		internal FontMetrics DisplayMetrics(float emSize, float pixelsPerDip)
		{
		}

		internal static void ResetFontFaceCache()
		{
		}

		internal FontFace GetFontFace()
		{
		}

		[SecuritySafeCritical]
		[return: MarshalAs(UnmanagedType.U1)]
		internal bool GetInformationalStrings(InformationalStringID informationalStringID, out LocalizedStrings informationalStrings)
		{
		}

		[SecuritySafeCritical]
		[return: MarshalAs(UnmanagedType.U1)]
		internal bool HasCharacter(uint unicodeValue)
		{
		}
	}
}
