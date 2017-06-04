using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("d02541f1-fb81-4d64-ae32-f520f8a6dbd1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IGridItemProvider
	{
		int Row
		{
			get;
		}

		int Column
		{
			get;
		}

		int RowSpan
		{
			get;
		}

		int ColumnSpan
		{
			get;
		}

		IRawElementProviderSimple ContainingGrid
		{
			get;
		}
	}
}
