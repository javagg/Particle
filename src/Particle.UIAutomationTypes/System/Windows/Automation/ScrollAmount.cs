using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation
{
	[ComVisible(true), Guid("bd52d3c7-f990-4c52-9ae3-5c377e9eb772")]
	public enum ScrollAmount
	{
		LargeDecrement,
		SmallDecrement,
		NoAmount,
		LargeIncrement,
		SmallIncrement
	}
}
