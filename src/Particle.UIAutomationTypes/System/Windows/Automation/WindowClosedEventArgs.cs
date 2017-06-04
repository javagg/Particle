using System;

namespace System.Windows.Automation
{
	public sealed class WindowClosedEventArgs : AutomationEventArgs
	{
		public WindowClosedEventArgs(int[] runtimeId) : base(WindowPatternIdentifiers.WindowClosedEvent)
		{
			if (runtimeId == null)
			{
				throw new ArgumentNullException("runtimeId");
			}
			this._runtimeId = (int[])runtimeId.Clone();
		}

		public int[] GetRuntimeId()
		{
			return (int[])this._runtimeId.Clone();
		}

		private int[] _runtimeId;
	}
}
