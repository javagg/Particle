using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class DockPatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.Dock_Pattern, "DockPatternIdentifiers.Pattern");

		public static readonly AutomationProperty DockPositionProperty = AutomationProperty.Register(AutomationIdentifierGuids.Dock_Position_Property, "DockPatternIdentifiers.DockPositionProperty");
	}
}
