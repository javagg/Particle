using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Text
{
	[Flags, ComVisible(true), Guid("1F57B37D-CB59-43f4-95E0-7C9E40DB427E")]
	public enum OutlineStyles
	{
		None = 0,
		Outline = 1,
		Shadow = 2,
		Engraved = 4,
		Embossed = 8
	}
}
