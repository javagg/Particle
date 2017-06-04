using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("620ce2a5-ab8f-40a9-86cb-de3c75599b58"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IRawElementProviderFragmentRoot : IRawElementProviderFragment, IRawElementProviderSimple
	{
		IRawElementProviderFragment ElementProviderFromPoint(double x, double y);

		IRawElementProviderFragment GetFocus();
	}
}
