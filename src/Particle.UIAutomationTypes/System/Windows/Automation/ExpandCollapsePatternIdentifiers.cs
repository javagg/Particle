using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class ExpandCollapsePatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.ExpandCollapse_Pattern, "ExpandCollapsePatternIdentifiers.Pattern");

		public static readonly AutomationProperty ExpandCollapseStateProperty = AutomationProperty.Register(AutomationIdentifierGuids.ExpandCollapse_State_Property, "ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty");
	}
}
