using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class RangeValuePatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.RangeValue_Pattern, "RangeValuePatternIdentifiers.Pattern");

		public static readonly AutomationProperty ValueProperty = AutomationProperty.Register(AutomationIdentifierGuids.RangeValue_Value_Property, "RangeValuePatternIdentifiers.ValueProperty");

		public static readonly AutomationProperty IsReadOnlyProperty = AutomationProperty.Register(AutomationIdentifierGuids.RangeValue_IsReadOnly_Property, "RangeValuePatternIdentifiers.IsReadOnlyProperty");

		public static readonly AutomationProperty MinimumProperty = AutomationProperty.Register(AutomationIdentifierGuids.RangeValue_Minimum_Property, "RangeValuePatternIdentifiers.MinimumProperty");

		public static readonly AutomationProperty MaximumProperty = AutomationProperty.Register(AutomationIdentifierGuids.RangeValue_Maximum_Property, "RangeValuePatternIdentifiers.MaximumProperty");

		public static readonly AutomationProperty LargeChangeProperty = AutomationProperty.Register(AutomationIdentifierGuids.RangeValue_LargeChange_Property, "RangeValuePatternIdentifiers.LargeChangeProperty");

		public static readonly AutomationProperty SmallChangeProperty = AutomationProperty.Register(AutomationIdentifierGuids.RangeValue_SmallChange_Property, "RangeValuePatternIdentifiers.SmallChangeProperty");
	}
}
