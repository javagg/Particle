using System;

namespace System.Windows.Automation
{
	public sealed class AsyncContentLoadedEventArgs : AutomationEventArgs
	{
		public AsyncContentLoadedEventArgs(AsyncContentLoadedState asyncContentState, double percentComplete) : base(AutomationElementIdentifiers.AsyncContentLoadedEvent)
		{
			this._asyncContentState = asyncContentState;
			this._percentComplete = percentComplete;
		}

		public AsyncContentLoadedState AsyncContentLoadedState
		{
			get
			{
				return this._asyncContentState;
			}
		}

		public double PercentComplete
		{
			get
			{
				return this._percentComplete;
			}
		}

		private AsyncContentLoadedState _asyncContentState;

		private double _percentComplete;
	}
}
