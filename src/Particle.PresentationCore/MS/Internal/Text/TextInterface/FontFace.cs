using System;
using System.Runtime.InteropServices;
using System.Security;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface
{
	internal sealed class FontFace : IDisposable
	{
		[SecurityCritical]
		internal unsafe FontFace(IDWriteFontFace* fontFace)
		{
		}

		internal unsafe IDWriteFontFace* DWriteFontFaceNoAddRef { [SecurityCritical] get; }

		internal IntPtr DWriteFontFaceAddRef { [SecurityCritical] get; }

		internal FontFaceType Type { [SecuritySafeCritical] get; }

		internal uint Index { [SecuritySafeCritical] get; }

		internal FontSimulations SimulationFlags { [SecuritySafeCritical] get; }

		internal bool IsSymbolFont { [SecuritySafeCritical] [return: MarshalAs(UnmanagedType.U1)] get; }

		internal FontMetrics Metrics { [SecuritySafeCritical] get; }

		internal ushort GlyphCount { [SecuritySafeCritical] get; }

		[SecuritySafeCritical]
		internal FontFile GetFileZero()
		{
		    throw new NotImplementedException();
		}

		internal void AddRef()
		{
		}

		internal void Release()
		{
		}

		[SecurityCritical]
		internal unsafe void GetDesignGlyphMetrics(ushort* pGlyphIndices, uint glyphCount, GlyphMetrics* pGlyphMetrics)
		{
		}

		[SecurityCritical]
		internal unsafe void GetDisplayGlyphMetrics(ushort* pGlyphIndices, uint glyphCount, GlyphMetrics* pGlyphMetrics, float emSize, [MarshalAs(UnmanagedType.U1)] bool useDisplayNatural, [MarshalAs(UnmanagedType.U1)] bool isSideways, float pixelsPerDip)
		{
		}

		[SecurityCritical]
		internal unsafe void GetArrayOfGlyphIndices(uint* pCodePoints, uint glyphCount, ushort* pGlyphIndices)
		{
		}

		[SecurityCritical]
		[return: MarshalAs(UnmanagedType.U1)]
		internal bool TryGetFontTable(OpenTypeTableTag openTypeTableTag, out byte[] tableData)
		{
		    throw new NotImplementedException();
        }

		[SecuritySafeCritical]
		[return: MarshalAs(UnmanagedType.U1)]
		internal bool ReadFontEmbeddingRights(out ushort fsType)
		{
		    throw new NotImplementedException();
		}


	    public void Dispose()
	    {
	        throw new NotImplementedException();
	    }
	}
}
