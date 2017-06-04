using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public class AutomationTextAttribute : AutomationIdentifier
	{
		internal AutomationTextAttribute(int id, Guid guid, string programmaticName) : base(UiaCoreTypesApi.AutomationIdType.TextAttribute, id, guid, programmaticName)
		{
		}

		internal static AutomationTextAttribute Register(Guid guid, string programmaticName)
		{
			return (AutomationTextAttribute)AutomationIdentifier.Register(UiaCoreTypesApi.AutomationIdType.TextAttribute, guid, programmaticName);
		}

		public static AutomationTextAttribute LookupById(int id)
		{
			return (AutomationTextAttribute)AutomationIdentifier.LookupById(UiaCoreTypesApi.AutomationIdType.TextAttribute, id);
		}
	}
}
