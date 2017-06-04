using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class SynchronizedInputPatternIdentifiers
	{
		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.SynchronizedInput_Pattern, "SynchronizedInputPatternIdentifiers.Pattern");

		public static readonly AutomationEvent InputReachedTargetEvent = AutomationEvent.Register(AutomationIdentifierGuids.InputReachedTarget_Event, "SynchronizedInputPatternIdentifiers.InputReachedTargetEvent");

		public static readonly AutomationEvent InputReachedOtherElementEvent = AutomationEvent.Register(AutomationIdentifierGuids.InputReachedOtherElement_Event, "SynchronizedInputPatternIdentifiers.InputReachedOtherElementEvent");

		public static readonly AutomationEvent InputDiscardedEvent = AutomationEvent.Register(AutomationIdentifierGuids.InputDiscarded_Event, "SynchronizedInputPatternIdentifiers.InputDiscardedEvent");
	}
}
