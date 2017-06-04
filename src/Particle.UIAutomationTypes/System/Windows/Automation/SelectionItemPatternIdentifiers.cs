using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class SelectionItemPatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.SelectionItem_Pattern, "SelectionItemPatternIdentifiers.Pattern");

		public static readonly AutomationProperty IsSelectedProperty = AutomationProperty.Register(AutomationIdentifierGuids.SelectionItem_IsSelected_Property, "SelectionItemPatternIdentifiers.IsSelectedProperty");

		public static readonly AutomationProperty SelectionContainerProperty = AutomationProperty.Register(AutomationIdentifierGuids.SelectionItem_SelectionContainer_Property, "SelectionItemPatternIdentifiers.SelectionContainerProperty");

		public static readonly AutomationEvent ElementAddedToSelectionEvent = AutomationEvent.Register(AutomationIdentifierGuids.SelectionItem_ElementAddedToSelection_Event, "SelectionItemPatternIdentifiers.ElementAddedToSelectionEvent");

		public static readonly AutomationEvent ElementRemovedFromSelectionEvent = AutomationEvent.Register(AutomationIdentifierGuids.SelectionItem_ElementRemovedFromSelection_Event, "SelectionItemPatternIdentifiers.ElementRemovedFromSelectionEvent");

		public static readonly AutomationEvent ElementSelectedEvent = AutomationEvent.Register(AutomationIdentifierGuids.SelectionItem_ElementSelected_Event, "SelectionItemPatternIdentifiers.ElementSelectedEvent");
	}
}
