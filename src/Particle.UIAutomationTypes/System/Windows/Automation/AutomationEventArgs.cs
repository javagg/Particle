using System;

namespace System.Windows.Automation
{
	public class AutomationEventArgs : EventArgs
	{
		public AutomationEventArgs(AutomationEvent eventId)
		{
			this._eventId = eventId;
		}

		public AutomationEvent EventId
		{
			get
			{
				return this._eventId;
			}
		}

		private AutomationEvent _eventId;
	}
}
