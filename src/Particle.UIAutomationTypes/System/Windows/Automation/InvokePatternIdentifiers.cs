using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class InvokePatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.Invoke_Pattern, "InvokePatternIdentifiers.Pattern");

		public static readonly AutomationEvent InvokedEvent = AutomationEvent.Register(AutomationIdentifierGuids.Invoke_Invoked_Event, "InvokePatternIdentifiers.InvokedEvent");
	}
}
