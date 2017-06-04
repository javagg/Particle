using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Text
{
	[Flags, ComVisible(true), Guid("2E22CC6B-7C34-4002-91AA-E103A09D1027")]
	public enum FlowDirections
	{
		Default = 0,
		RightToLeft = 1,
		BottomToTop = 2,
		Vertical = 4
	}
}
