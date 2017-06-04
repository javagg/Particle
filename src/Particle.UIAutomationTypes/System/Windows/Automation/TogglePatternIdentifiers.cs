using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class TogglePatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.Toggle_Pattern, "TogglePatternIdentifiers.Pattern");

		public static readonly AutomationProperty ToggleStateProperty = AutomationProperty.Register(AutomationIdentifierGuids.Toggle_State_Property, "TogglePatternIdentifiers.ToggleStateProperty");
	}
}
