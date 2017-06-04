using System;
using MS.Internal.Automation;

namespace System.Windows.Automation.Provider
{
	public static class AutomationInteropProvider
	{
		public static IRawElementProviderSimple HostProviderFromHandle(IntPtr hwnd)
		{
			AutomationInteropProvider.ValidateArgument(hwnd != IntPtr.Zero, "HwndMustBeNonNULL");
			return UiaCoreProviderApi.UiaHostProviderFromHwnd(hwnd);
		}

		public static IntPtr ReturnRawElementProvider(IntPtr hwnd, IntPtr wParam, IntPtr lParam, IRawElementProviderSimple el)
		{
			AutomationInteropProvider.ValidateArgument(hwnd != IntPtr.Zero, "HwndMustBeNonNULL");
			AutomationInteropProvider.ValidateArgumentNonNull(el, "el");
			return UiaCoreProviderApi.UiaReturnRawElementProvider(hwnd, wParam, lParam, el);
		}

		public static bool ClientsAreListening
		{
			get
			{
				return UiaCoreProviderApi.UiaClientsAreListening();
			}
		}

		public static void RaiseAutomationPropertyChangedEvent(IRawElementProviderSimple element, AutomationPropertyChangedEventArgs e)
		{
			AutomationInteropProvider.ValidateArgumentNonNull(element, "element");
			AutomationInteropProvider.ValidateArgumentNonNull(e, "e");
			UiaCoreProviderApi.UiaRaiseAutomationPropertyChangedEvent(element, e.Property.Id, e.OldValue, e.NewValue);
		}

		public static void RaiseAutomationEvent(AutomationEvent eventId, IRawElementProviderSimple provider, AutomationEventArgs e)
		{
			AutomationInteropProvider.ValidateArgumentNonNull(eventId, "eventId");
			AutomationInteropProvider.ValidateArgumentNonNull(provider, "provider");
			AutomationInteropProvider.ValidateArgumentNonNull(e, "e");
			if (e.EventId == AutomationElementIdentifiers.AsyncContentLoadedEvent)
			{
				AsyncContentLoadedEventArgs asyncContentLoadedEventArgs = e as AsyncContentLoadedEventArgs;
				if (asyncContentLoadedEventArgs == null)
				{
					AutomationInteropProvider.ThrowInvalidArgument("e");
				}
				UiaCoreProviderApi.UiaRaiseAsyncContentLoadedEvent(provider, asyncContentLoadedEventArgs.AsyncContentLoadedState, asyncContentLoadedEventArgs.PercentComplete);
				return;
			}
			if (e.EventId == WindowPatternIdentifiers.WindowClosedEvent && !(e is WindowClosedEventArgs))
			{
				AutomationInteropProvider.ThrowInvalidArgument("e");
			}
			UiaCoreProviderApi.UiaRaiseAutomationEvent(provider, eventId.Id);
		}

		public static void RaiseStructureChangedEvent(IRawElementProviderSimple provider, StructureChangedEventArgs e)
		{
			AutomationInteropProvider.ValidateArgumentNonNull(provider, "provider");
			AutomationInteropProvider.ValidateArgumentNonNull(e, "e");
			UiaCoreProviderApi.UiaRaiseStructureChangedEvent(provider, e.StructureChangeType, e.GetRuntimeId());
		}

		private static void ValidateArgumentNonNull(object obj, string argName)
		{
			if (obj == null)
			{
				throw new ArgumentNullException(argName);
			}
		}

		private static void ThrowInvalidArgument(string argName)
		{
			throw new ArgumentException(SR.Get("GenericInvalidArgument", new object[]
			{
				argName
			}));
		}

		private static void ValidateArgument(bool cond, string reason)
		{
			if (!cond)
			{
				throw new ArgumentException(SR.Get(reason));
			}
		}

		public const int RootObjectId = -25;

		public const int InvalidateLimit = 20;

		public const int AppendRuntimeId = 3;

		public const int ItemsInvalidateLimit = 5;
	}
}
