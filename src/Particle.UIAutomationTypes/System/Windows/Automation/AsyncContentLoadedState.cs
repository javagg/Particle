using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation
{
	[ComVisible(true), Guid("d8e55844-7043-4edc-979d-593cc6b4775e")]
	public enum AsyncContentLoadedState
	{
		Beginning,
		Progress,
		Completed
	}
}
