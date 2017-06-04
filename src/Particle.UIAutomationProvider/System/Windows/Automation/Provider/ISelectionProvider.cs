using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("fb8b03af-3bdf-48d4-bd36-1a65793be168"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ISelectionProvider
	{
		IRawElementProviderSimple[] GetSelection();

		bool CanSelectMultiple
		{
			[return: MarshalAs(UnmanagedType.Bool)]
			get;
		}

		bool IsSelectionRequired
		{
			[return: MarshalAs(UnmanagedType.Bool)]
			get;
		}
	}
}
