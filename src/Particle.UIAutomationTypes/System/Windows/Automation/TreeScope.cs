using System;

namespace System.Windows.Automation
{
	[Flags]
	public enum TreeScope
	{
		Element = 1,
		Children = 2,
		Descendants = 4,
		Parent = 8,
		Ancestors = 16,
		Subtree = 7
	}
}
