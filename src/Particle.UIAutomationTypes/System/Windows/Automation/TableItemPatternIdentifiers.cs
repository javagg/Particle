using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class TableItemPatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.TableItem_Pattern, "TableItemPatternIdentifiers.Pattern");

		public static readonly AutomationProperty RowHeaderItemsProperty = AutomationProperty.Register(AutomationIdentifierGuids.TableItem_RowHeaderItems_Property, "TableItemPatternIdentifiers.RowHeaderItemsProperty");

		public static readonly AutomationProperty ColumnHeaderItemsProperty = AutomationProperty.Register(AutomationIdentifierGuids.TableItem_ColumnHeaderItems_Property, "TableItemPatternIdentifiers.ColumnHeaderItemsProperty");
	}
}
