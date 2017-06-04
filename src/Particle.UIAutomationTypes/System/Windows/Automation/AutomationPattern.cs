using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public class AutomationPattern : AutomationIdentifier
	{
		internal AutomationPattern(int id, Guid guid, string programmaticName) : base(UiaCoreTypesApi.AutomationIdType.Pattern, id, guid, programmaticName)
		{
		}

		internal static AutomationPattern Register(Guid guid, string programmaticName)
		{
			return (AutomationPattern)AutomationIdentifier.Register(UiaCoreTypesApi.AutomationIdType.Pattern, guid, programmaticName);
		}

		public static AutomationPattern LookupById(int id)
		{
			return (AutomationPattern)AutomationIdentifier.LookupById(UiaCoreTypesApi.AutomationIdType.Pattern, id);
		}
	}
}
