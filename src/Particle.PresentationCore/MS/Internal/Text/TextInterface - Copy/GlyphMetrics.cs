using System;
using System.Runtime.InteropServices;

namespace MS.Internal.Text.TextInterface
{
	[StructLayout(LayoutKind.Explicit, Pack = 8)]
	internal struct GlyphMetrics
	{
		[FieldOffset(0)]
		public int LeftSideBearing;

		[FieldOffset(4)]
		public uint AdvanceWidth;

		[FieldOffset(8)]
		public int RightSideBearing;

		[FieldOffset(12)]
		public int TopSideBearing;

		[FieldOffset(16)]
		public uint AdvanceHeight;

		[FieldOffset(20)]
		public int BottomSideBearing;

		[FieldOffset(24)]
		public int VerticalOriginY;
	}
}
