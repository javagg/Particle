using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("d6dd68d1-86fd-4332-8666-9abedea2d24c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IRawElementProviderSimple
	{
		ProviderOptions ProviderOptions
		{
			get;
		}

		[return: MarshalAs(UnmanagedType.IUnknown)]
		object GetPatternProvider(int patternId);

		object GetPropertyValue(int propertyId);

		IRawElementProviderSimple HostRawElementProvider
		{
			get;
		}
	}
}
