using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class GridItemPatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.GridItem_Pattern, "GridItemPatternIdentifiers.Pattern");

		public static readonly AutomationProperty RowProperty = AutomationProperty.Register(AutomationIdentifierGuids.GridItem_Row_Property, "GridItemPatternIdentifiers.RowProperty");

		public static readonly AutomationProperty ColumnProperty = AutomationProperty.Register(AutomationIdentifierGuids.GridItem_Column_Property, "GridItemPatternIdentifiers.ColumnProperty");

		public static readonly AutomationProperty RowSpanProperty = AutomationProperty.Register(AutomationIdentifierGuids.GridItem_RowSpan_Property, "GridItemPatternIdentifiers.RowSpanProperty");

		public static readonly AutomationProperty ColumnSpanProperty = AutomationProperty.Register(AutomationIdentifierGuids.GridItem_ColumnSpan_Property, "GridItemPatternIdentifiers.ColumnSpanProperty");

		public static readonly AutomationProperty ContainingGridProperty = AutomationProperty.Register(AutomationIdentifierGuids.GridItem_Parent_Property, "GridItemPatternIdentifiers.ContainingGridProperty");
	}
}
