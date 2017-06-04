using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("159bc72c-4ad3-485e-9637-d7052edf0146"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDockProvider
	{
		void SetDockPosition(DockPosition dockPosition);

		DockPosition DockPosition
		{
			get;
		}
	}
}
