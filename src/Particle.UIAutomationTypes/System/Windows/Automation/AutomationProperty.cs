using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public class AutomationProperty : AutomationIdentifier
	{
		internal AutomationProperty(int id, Guid guid, string programmaticName) : base(UiaCoreTypesApi.AutomationIdType.Property, id, guid, programmaticName)
		{
		}

		internal static AutomationProperty Register(Guid guid, string programmaticName)
		{
			return (AutomationProperty)AutomationIdentifier.Register(UiaCoreTypesApi.AutomationIdType.Property, guid, programmaticName);
		}

		public static AutomationProperty LookupById(int id)
		{
			return (AutomationProperty)AutomationIdentifier.LookupById(UiaCoreTypesApi.AutomationIdType.Property, id);
		}
	}
}
