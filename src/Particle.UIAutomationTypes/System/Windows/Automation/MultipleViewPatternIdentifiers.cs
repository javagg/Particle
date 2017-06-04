using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class MultipleViewPatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.MultipleView_Pattern, "MultipleViewPatternIdentifiers.Pattern");

		public static readonly AutomationProperty CurrentViewProperty = AutomationProperty.Register(AutomationIdentifierGuids.MultipleView_CurrentView_Property, "MultipleViewPatternIdentifiers.CurrentViewProperty");

		public static readonly AutomationProperty SupportedViewsProperty = AutomationProperty.Register(AutomationIdentifierGuids.MultipleView_SupportedViews_Property, "MultipleViewPatternIdentifiers.SupportedViewsProperty");
	}
}
