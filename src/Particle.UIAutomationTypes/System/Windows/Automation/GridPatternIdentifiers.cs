using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class GridPatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.Grid_Pattern, "GridPatternIdentifiers.Pattern");

		public static readonly AutomationProperty RowCountProperty = AutomationProperty.Register(AutomationIdentifierGuids.Grid_RowCount_Property, "GridPatternIdentifiers.RowCountProperty");

		public static readonly AutomationProperty ColumnCountProperty = AutomationProperty.Register(AutomationIdentifierGuids.Grid_ColumnCount_Property, "GridPatternIdentifiers.ColumnCountProperty");
	}
}
