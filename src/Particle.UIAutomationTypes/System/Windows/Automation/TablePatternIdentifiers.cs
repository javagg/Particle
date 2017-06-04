using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class TablePatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.Table_Pattern, "TablePatternIdentifiers.Pattern");

		public static readonly AutomationProperty RowHeadersProperty = AutomationProperty.Register(AutomationIdentifierGuids.Table_RowHeaders_Property, "TablePatternIdentifiers.RowHeadersProperty");

		public static readonly AutomationProperty ColumnHeadersProperty = AutomationProperty.Register(AutomationIdentifierGuids.Table_ColumnHeaders_Property, "TablePatternIdentifiers.ColumnHeadersProperty");

		public static readonly AutomationProperty RowOrColumnMajorProperty = AutomationProperty.Register(AutomationIdentifierGuids.Table_RowOrColumnMajor_Property, "TablePatternIdentifiers.RowOrColumnMajorProperty");
	}
}
