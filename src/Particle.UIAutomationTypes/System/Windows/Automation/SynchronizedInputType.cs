using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation
{
	[ComVisible(true), Guid("fdc8f176-aed2-477a-8c89-5604c66f278d")]
	public enum SynchronizedInputType
	{
		KeyUp = 1,
		KeyDown,
		MouseLeftButtonUp = 4,
		MouseLeftButtonDown = 8,
		MouseRightButtonUp = 16,
		MouseRightButtonDown = 32
	}
}
