using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class TransformPatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.Transform_Pattern, "TransformPatternIdentifiers.Pattern");

		public static readonly AutomationProperty CanMoveProperty = AutomationProperty.Register(AutomationIdentifierGuids.Transform_CanMove_Property, "TransformPatternIdentifiers.CanMoveProperty");

		public static readonly AutomationProperty CanResizeProperty = AutomationProperty.Register(AutomationIdentifierGuids.Transform_CanResize_Property, "TransformPatternIdentifiers.CanResizeProperty");

		public static readonly AutomationProperty CanRotateProperty = AutomationProperty.Register(AutomationIdentifierGuids.Transform_CanRotate_Property, "TransformPatternIdentifiers.CanRotateProperty");
	}
}
