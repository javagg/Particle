using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class SelectionPatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.Selection_Pattern, "SelectionPatternIdentifiers.Pattern");

		public static readonly AutomationProperty SelectionProperty = AutomationProperty.Register(AutomationIdentifierGuids.Selection_Selection_Property, "SelectionPatternIdentifiers.SelectionProperty");

		public static readonly AutomationProperty CanSelectMultipleProperty = AutomationProperty.Register(AutomationIdentifierGuids.Selection_CanSelectMultiple_Property, "SelectionPatternIdentifiers.CanSelectMultipleProperty");

		public static readonly AutomationProperty IsSelectionRequiredProperty = AutomationProperty.Register(AutomationIdentifierGuids.Selection_IsSelectionRequired_Property, "SelectionPatternIdentifiers.IsSelectionRequiredProperty");

		public static readonly AutomationEvent InvalidatedEvent = AutomationEvent.Register(AutomationIdentifierGuids.Selection_Invalidated_Event, "SelectionPatternIdentifiers.InvalidatedEvent");
	}
}
