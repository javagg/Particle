using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("29db1a06-02ce-4cf7-9b42-565d4fab20ee"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ISynchronizedInputProvider
	{
		void StartListening(SynchronizedInputType inputType);

		void Cancel();
	}
}
