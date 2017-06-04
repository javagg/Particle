using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class ScrollPatternIdentifiers
	{
		public const double NoScroll = -1.0;

		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.Scroll_Pattern, "ScrollPatternIdentifiers.Pattern");

		public static readonly AutomationProperty HorizontalScrollPercentProperty = AutomationProperty.Register(AutomationIdentifierGuids.Scroll_HorizontalScrollPercent_Property, "ScrollPatternIdentifiers.HorizontalScrollPercentProperty");

		public static readonly AutomationProperty HorizontalViewSizeProperty = AutomationProperty.Register(AutomationIdentifierGuids.Scroll_HorizontalViewSize_Property, "ScrollPatternIdentifiers.HorizontalViewSizeProperty");

		public static readonly AutomationProperty VerticalScrollPercentProperty = AutomationProperty.Register(AutomationIdentifierGuids.Scroll_VerticalScrollPercent_Property, "ScrollPatternIdentifiers.VerticalScrollPercentProperty");

		public static readonly AutomationProperty VerticalViewSizeProperty = AutomationProperty.Register(AutomationIdentifierGuids.Scroll_VerticalViewSize_Property, "ScrollPatternIdentifiers.VerticalViewSizeProperty");

		public static readonly AutomationProperty HorizontallyScrollableProperty = AutomationProperty.Register(AutomationIdentifierGuids.Scroll_HorizontallyScrollable_Property, "ScrollPatternIdentifiers.HorizontallyScrollableProperty");

		public static readonly AutomationProperty VerticallyScrollableProperty = AutomationProperty.Register(AutomationIdentifierGuids.Scroll_VerticallyScrollable_Property, "ScrollPatternIdentifiers.VerticallyScrollableProperty");
	}
}
