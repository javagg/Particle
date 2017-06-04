using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("cb98b665-2d35-4fac-ad35-f3c60d0c0b8b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVirtualizedItemProvider
	{
		void Realize();
	}
}
