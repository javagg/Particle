using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("f7063da8-8359-439c-9297-bbc5299a7d87"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IRawElementProviderFragment : IRawElementProviderSimple
	{
		IRawElementProviderFragment Navigate(NavigateDirection direction);

		int[] GetRuntimeId();

		Rect BoundingRectangle
		{
			get;
		}

		IRawElementProviderSimple[] GetEmbeddedFragmentRoots();

		void SetFocus();

		IRawElementProviderFragmentRoot FragmentRoot
		{
			get;
		}
	}
}
