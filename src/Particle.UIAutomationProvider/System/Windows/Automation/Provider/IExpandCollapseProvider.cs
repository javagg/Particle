﻿using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("d847d3a5-cab0-4a98-8c32-ecb45c59ad24"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IExpandCollapseProvider
	{
		void Expand();

		void Collapse();

		ExpandCollapseState ExpandCollapseState
		{
			get;
		}
	}
}
