using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("670c3006-bf4c-428b-8534-e1848f645122")]
	public enum NavigateDirection
	{
		Parent,
		NextSibling,
		PreviousSibling,
		FirstChild,
		LastChild
	}
}
