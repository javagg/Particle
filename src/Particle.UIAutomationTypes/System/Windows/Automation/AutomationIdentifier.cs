using System;
using System.Collections;
using System.Threading;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public class AutomationIdentifier : IComparable
	{
		internal AutomationIdentifier(UiaCoreTypesApi.AutomationIdType type, int id, Guid guid, string programmaticName)
		{
			this._id = id;
			this._type = type;
			this._guid = guid;
			this._programmaticName = programmaticName;
		}

		public int Id
		{
			get
			{
				return this._id;
			}
		}

		public string ProgrammaticName
		{
			get
			{
				return this._programmaticName;
			}
		}

		public override bool Equals(object obj)
		{
			return obj == this;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			return this.GetHashCode() - obj.GetHashCode();
		}

		internal static AutomationIdentifier Register(UiaCoreTypesApi.AutomationIdType type, Guid guid, string programmaticName)
		{
			int num = UiaCoreTypesApi.UiaLookupId(type, ref guid);
			if (num == 0)
			{
				if ((!AutomationIdentifier.IsWin7OnlyPatternGuid(guid) && Environment.OSVersion.Version.Major <= 6) || Environment.OSVersion.Version.Major >= 7)
				{
					int num2 = 1;
					while (num == 0 && num2 < 1000)
					{
						Thread.Sleep(num2);
						num = UiaCoreTypesApi.UiaLookupId(type, ref guid);
						num2 *= 2;
					}
				}
				if (num == 0)
				{
					return null;
				}
			}
			Hashtable idTable = AutomationIdentifier._idTable;
			AutomationIdentifier result;
			lock (idTable)
			{
				AutomationIdentifier automationIdentifier = (AutomationIdentifier)AutomationIdentifier._idTable[guid];
				if (automationIdentifier != null)
				{
					result = automationIdentifier;
				}
				else
				{
					switch (type)
					{
					case UiaCoreTypesApi.AutomationIdType.Property:
						automationIdentifier = new AutomationProperty(num, guid, programmaticName);
						break;
					case UiaCoreTypesApi.AutomationIdType.Pattern:
						automationIdentifier = new AutomationPattern(num, guid, programmaticName);
						break;
					case UiaCoreTypesApi.AutomationIdType.Event:
						automationIdentifier = new AutomationEvent(num, guid, programmaticName);
						break;
					case UiaCoreTypesApi.AutomationIdType.ControlType:
						automationIdentifier = new ControlType(num, guid, programmaticName);
						break;
					case UiaCoreTypesApi.AutomationIdType.TextAttribute:
						automationIdentifier = new AutomationTextAttribute(num, guid, programmaticName);
						break;
					default:
						throw new InvalidOperationException("Invalid type specified for AutomationIdentifier");
					}
					AutomationIdentifier._idTable[num] = automationIdentifier;
					result = automationIdentifier;
				}
			}
			return result;
		}

		internal static AutomationIdentifier LookupById(UiaCoreTypesApi.AutomationIdType type, int id)
		{
			Hashtable idTable = AutomationIdentifier._idTable;
			AutomationIdentifier automationIdentifier;
			lock (idTable)
			{
				automationIdentifier = (AutomationIdentifier)AutomationIdentifier._idTable[id];
			}
			if (automationIdentifier == null)
			{
				return null;
			}
			if (automationIdentifier._type != type)
			{
				return null;
			}
			return automationIdentifier;
		}

		private static bool IsWin7OnlyPatternGuid(Guid guid)
		{
			return guid == AutomationIdentifierGuids.IsSynchronizedInputPatternAvailable_Property || guid == AutomationIdentifierGuids.SynchronizedInput_Pattern || guid == AutomationIdentifierGuids.InputReachedTarget_Event || guid == AutomationIdentifierGuids.InputReachedOtherElement_Event || guid == AutomationIdentifierGuids.InputDiscarded_Event || guid == AutomationIdentifierGuids.IsVirtualizedItemPatternAvailable_Property || guid == AutomationIdentifierGuids.IsItemContainerPatternAvailable_Property || guid == AutomationIdentifierGuids.VirtualizedItem_Pattern || guid == AutomationIdentifierGuids.ItemContainer_Pattern;
		}

		private Guid _guid;

		private UiaCoreTypesApi.AutomationIdType _type;

		private int _id;

		private string _programmaticName;

		private static Hashtable _idTable = new Hashtable(200, 1f);
	}
}
