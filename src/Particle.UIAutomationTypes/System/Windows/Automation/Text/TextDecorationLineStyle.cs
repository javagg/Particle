using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Text
{
	[ComVisible(true), Guid("909D8633-2941-428e-A549-C752E2FC078C")]
	public enum TextDecorationLineStyle
	{
		None,
		Single,
		WordsOnly,
		Double,
		Dot,
		Dash,
		DashDot,
		DashDotDot,
		Wavy,
		ThickSingle,
		DoubleWavy = 11,
		ThickWavy,
		LongDash,
		ThickDash,
		ThickDashDot,
		ThickDashDotDot,
		ThickDot,
		ThickLongDash,
		Other = -1
	}
}
