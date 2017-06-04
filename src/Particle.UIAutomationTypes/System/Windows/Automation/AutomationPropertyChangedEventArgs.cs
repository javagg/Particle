using System;

namespace System.Windows.Automation
{
	public sealed class AutomationPropertyChangedEventArgs : AutomationEventArgs
	{
		public AutomationPropertyChangedEventArgs(AutomationProperty property, object oldValue, object newValue) : base(AutomationElementIdentifiers.AutomationPropertyChangedEvent)
		{
			this._oldValue = oldValue;
			this._newValue = newValue;
			this._property = property;
		}

		public AutomationProperty Property
		{
			get
			{
				return this._property;
			}
		}

		public object OldValue
		{
			get
			{
				return this._oldValue;
			}
		}

		public object NewValue
		{
			get
			{
				return this._newValue;
			}
		}

		private AutomationProperty _property;

		private object _oldValue;

		private object _newValue;
	}
}
