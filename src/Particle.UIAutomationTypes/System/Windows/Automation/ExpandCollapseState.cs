using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation
{
	[ComVisible(true), Guid("76d12d7e-b227-4417-9ce2-42642ffa896a")]
	public enum ExpandCollapseState
	{
		Collapsed,
		Expanded,
		PartiallyExpanded,
		LeafNode
	}
}
