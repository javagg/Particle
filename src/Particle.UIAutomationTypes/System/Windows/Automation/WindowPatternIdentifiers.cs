using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class WindowPatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.Window_Pattern, "WindowPatternIdentifiers.Pattern");

		public static readonly AutomationProperty CanMaximizeProperty = AutomationProperty.Register(AutomationIdentifierGuids.Window_CanMaximize_Property, "WindowPatternIdentifiers.CanMaximizeProperty");

		public static readonly AutomationProperty CanMinimizeProperty = AutomationProperty.Register(AutomationIdentifierGuids.Window_CanMinimize_Property, "WindowPatternIdentifiers.CanMinimizeProperty");

		public static readonly AutomationProperty IsModalProperty = AutomationProperty.Register(AutomationIdentifierGuids.Window_IsModal_Property, "WindowPatternIdentifiers.IsModalProperty");

		public static readonly AutomationProperty WindowVisualStateProperty = AutomationProperty.Register(AutomationIdentifierGuids.Window_VisualState_Property, "WindowPatternIdentifiers.WindowVisualStateProperty");

		public static readonly AutomationProperty WindowInteractionStateProperty = AutomationProperty.Register(AutomationIdentifierGuids.Window_InteractionState_Property, "WindowPatternIdentifiers.WindowInteractionStateProperty");

		public static readonly AutomationProperty IsTopmostProperty = AutomationProperty.Register(AutomationIdentifierGuids.Window_IsTopmost_Property, "WindowPatternIdentifiers.IsTopmostProperty");

		public static readonly AutomationEvent WindowOpenedEvent = AutomationEvent.Register(AutomationIdentifierGuids.Window_Opened_Event, "WindowPatternIdentifiers.WindowOpenedProperty");

		public static readonly AutomationEvent WindowClosedEvent = AutomationEvent.Register(AutomationIdentifierGuids.Window_Closed_Event, "WindowPatternIdentifiers.WindowClosedProperty");
	}
}
