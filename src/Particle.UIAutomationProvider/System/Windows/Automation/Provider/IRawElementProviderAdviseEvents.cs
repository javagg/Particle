using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("a407b27b-0f6d-4427-9292-473c7bf93258"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IRawElementProviderAdviseEvents : IRawElementProviderSimple
	{
		void AdviseEventAdded(int eventId, int[] properties);

		void AdviseEventRemoved(int eventId, int[] properties);
	}
}
