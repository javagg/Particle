using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public class AutomationEvent : AutomationIdentifier
	{
		internal AutomationEvent(int id, Guid guid, string programmaticName) : base(UiaCoreTypesApi.AutomationIdType.Event, id, guid, programmaticName)
		{
		}

		internal static AutomationEvent Register(Guid guid, string programmaticName)
		{
			return (AutomationEvent)AutomationIdentifier.Register(UiaCoreTypesApi.AutomationIdType.Event, guid, programmaticName);
		}

		public static AutomationEvent LookupById(int id)
		{
			return (AutomationEvent)AutomationIdentifier.LookupById(UiaCoreTypesApi.AutomationIdType.Event, id);
		}
	}
}
