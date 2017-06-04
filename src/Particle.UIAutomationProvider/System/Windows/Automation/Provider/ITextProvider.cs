using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("3589c92c-63f3-4367-99bb-ada653b77cf2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ITextProvider
	{
		ITextRangeProvider[] GetSelection();

		ITextRangeProvider[] GetVisibleRanges();

		ITextRangeProvider RangeFromChild(IRawElementProviderSimple childElement);

		ITextRangeProvider RangeFromPoint(Point screenLocation);

		ITextRangeProvider DocumentRange
		{
			get;
		}

		SupportedTextSelection SupportedTextSelection
		{
			get;
		}
	}
}
