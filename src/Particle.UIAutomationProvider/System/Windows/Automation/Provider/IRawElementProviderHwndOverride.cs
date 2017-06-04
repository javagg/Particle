using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("1d5df27c-8947-4425-b8d9-79787bb460b8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IRawElementProviderHwndOverride : IRawElementProviderSimple
	{
		IRawElementProviderSimple GetOverrideProviderForHwnd(IntPtr hwnd);
	}
}
