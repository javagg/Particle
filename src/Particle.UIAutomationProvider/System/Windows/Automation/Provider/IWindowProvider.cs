using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Provider
{
	[ComVisible(true), Guid("987df77b-db06-4d77-8f8a-86a9c3bb90b9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWindowProvider
	{
		void SetVisualState(WindowVisualState state);

		void Close();

		[return: MarshalAs(UnmanagedType.Bool)]
		bool WaitForInputIdle(int milliseconds);

		bool Maximizable
		{
			[return: MarshalAs(UnmanagedType.Bool)]
			get;
		}

		bool Minimizable
		{
			[return: MarshalAs(UnmanagedType.Bool)]
			get;
		}

		bool IsModal
		{
			[return: MarshalAs(UnmanagedType.Bool)]
			get;
		}

		WindowVisualState VisualState
		{
			get;
		}

		WindowInteractionState InteractionState
		{
			get;
		}

		bool IsTopmost
		{
			[return: MarshalAs(UnmanagedType.Bool)]
			get;
		}
	}
}
