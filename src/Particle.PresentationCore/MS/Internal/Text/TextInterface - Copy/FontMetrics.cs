using System;
using System.Runtime.InteropServices;

namespace MS.Internal.Text.TextInterface
{
	[StructLayout(LayoutKind.Explicit, Pack = 8)]
	internal sealed class FontMetrics
	{
		public double Baseline
		{
			get
			{
			}
		}

		public double LineSpacing
		{
			get
			{
			}
		}

		[FieldOffset(0)]
		public ushort DesignUnitsPerEm;

		[FieldOffset(2)]
		public ushort Ascent;

		[FieldOffset(4)]
		public ushort Descent;

		[FieldOffset(8)]
		public short LineGap;

		[FieldOffset(10)]
		public ushort CapHeight;

		[FieldOffset(12)]
		public ushort XHeight;

		[FieldOffset(14)]
		public short UnderlinePosition;

		[FieldOffset(16)]
		public ushort UnderlineThickness;

		[FieldOffset(18)]
		public short StrikethroughPosition;

		[FieldOffset(20)]
		public ushort StrikethroughThickness;
	}
}
