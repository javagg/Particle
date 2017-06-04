using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("54fcb24b-e18e-47a2-b4d3-eccbe77599a2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IInvokeProvider
	{
		void Invoke();
	}
}
