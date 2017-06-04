using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("e747770b-39ce-4382-ab30-d8fb3f336f24"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IItemContainerProvider
	{
		IRawElementProviderSimple FindItemByProperty(IRawElementProviderSimple startAfter, int propertyId, object value);
	}
}
