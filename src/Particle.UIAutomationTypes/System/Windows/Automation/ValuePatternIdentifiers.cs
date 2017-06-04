using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class ValuePatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.Value_Pattern, "ValuePatternIdentifiers.Pattern");

		public static readonly AutomationProperty ValueProperty = AutomationProperty.Register(AutomationIdentifierGuids.Value_Property, "ValuePatternIdentifiers.ValueProperty");

		public static readonly AutomationProperty IsReadOnlyProperty = AutomationProperty.Register(AutomationIdentifierGuids.Value_IsReadOnly_Property, "ValuePatternIdentifiers.IsReadOnlyProperty");
	}
}
