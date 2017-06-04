using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("9c860395-97b3-490a-b52a-858cc22af166"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ITableProvider : IGridProvider
	{
		IRawElementProviderSimple[] GetRowHeaders();

		IRawElementProviderSimple[] GetColumnHeaders();

		RowOrColumnMajor RowOrColumnMajor
		{
			get;
		}
	}
}
