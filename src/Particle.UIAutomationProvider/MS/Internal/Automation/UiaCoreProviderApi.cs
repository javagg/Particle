using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Automation;
using System.Windows.Automation.Provider;

namespace MS.Internal.Automation
{
	internal static class UiaCoreProviderApi
	{
		[SecurityCritical, SecurityTreatAsSafe]
		internal static IntPtr UiaReturnRawElementProvider(IntPtr hwnd, IntPtr wParam, IntPtr lParam, IRawElementProviderSimple el)
		{
			return UiaCoreProviderApi.RawUiaReturnRawElementProvider(hwnd, wParam, lParam, el);
		}

		[SecurityCritical, SecurityTreatAsSafe]
		internal static IRawElementProviderSimple UiaHostProviderFromHwnd(IntPtr hwnd)
		{
			IRawElementProviderSimple result;
			UiaCoreProviderApi.CheckError(UiaCoreProviderApi.RawUiaHostProviderFromHwnd(hwnd, out result));
			return result;
		}

		[SecurityCritical, SecurityTreatAsSafe]
		internal static void UiaRaiseAutomationPropertyChangedEvent(IRawElementProviderSimple provider, int propertyId, object oldValue, object newValue)
		{
			UiaCoreProviderApi.CheckError(UiaCoreProviderApi.RawUiaRaiseAutomationPropertyChangedEvent(provider, propertyId, oldValue, newValue));
		}

		[SecurityCritical, SecurityTreatAsSafe]
		internal static void UiaRaiseAutomationEvent(IRawElementProviderSimple provider, int eventId)
		{
			UiaCoreProviderApi.CheckError(UiaCoreProviderApi.RawUiaRaiseAutomationEvent(provider, eventId));
		}

		[SecurityCritical, SecurityTreatAsSafe]
		internal static void UiaRaiseStructureChangedEvent(IRawElementProviderSimple provider, StructureChangeType structureChangeType, int[] runtimeId)
		{
			UiaCoreProviderApi.CheckError(UiaCoreProviderApi.RawUiaRaiseStructureChangedEvent(provider, structureChangeType, runtimeId, (runtimeId == null) ? 0 : runtimeId.Length));
		}

		[SecurityCritical, SecurityTreatAsSafe]
		internal static void UiaRaiseAsyncContentLoadedEvent(IRawElementProviderSimple provider, AsyncContentLoadedState asyncContentLoadedState, double PercentComplete)
		{
			UiaCoreProviderApi.CheckError(UiaCoreProviderApi.RawUiaRaiseAsyncContentLoadedEvent(provider, asyncContentLoadedState, PercentComplete));
		}

		[SecurityCritical, SecurityTreatAsSafe]
		internal static bool UiaClientsAreListening()
		{
			return UiaCoreProviderApi.RawUiaClientsAreListening();
		}

		[SecurityCritical, SecurityTreatAsSafe]
		private static void CheckError(int hr)
		{
			if (hr >= 0 || hr == -2147220991)
			{
				return;
			}
			Marshal.ThrowExceptionForHR(hr, (IntPtr)(-1));
		}

		[SecurityCritical, SuppressUnmanagedCodeSecurity]
		[DllImport("UIAutomationCore.dll", CharSet = CharSet.Unicode, EntryPoint = "UiaReturnRawElementProvider")]
		private static extern IntPtr RawUiaReturnRawElementProvider(IntPtr hwnd, IntPtr wParam, IntPtr lParam, IRawElementProviderSimple el);

		[SecurityCritical, SuppressUnmanagedCodeSecurity]
		[DllImport("UIAutomationCore.dll", CharSet = CharSet.Unicode, EntryPoint = "UiaHostProviderFromHwnd")]
		private static extern int RawUiaHostProviderFromHwnd(IntPtr hwnd, [MarshalAs(UnmanagedType.Interface)] out IRawElementProviderSimple provider);

		[SecurityCritical, SuppressUnmanagedCodeSecurity]
		[DllImport("UIAutomationCore.dll", CharSet = CharSet.Unicode, EntryPoint = "UiaRaiseAutomationPropertyChangedEvent")]
		private static extern int RawUiaRaiseAutomationPropertyChangedEvent(IRawElementProviderSimple provider, int id, object oldValue, object newValue);

		[SecurityCritical, SuppressUnmanagedCodeSecurity]
		[DllImport("UIAutomationCore.dll", CharSet = CharSet.Unicode, EntryPoint = "UiaRaiseAutomationEvent")]
		private static extern int RawUiaRaiseAutomationEvent(IRawElementProviderSimple provider, int id);

		[SecurityCritical, SuppressUnmanagedCodeSecurity]
		[DllImport("UIAutomationCore.dll", CharSet = CharSet.Unicode, EntryPoint = "UiaRaiseStructureChangedEvent")]
		private static extern int RawUiaRaiseStructureChangedEvent(IRawElementProviderSimple provider, StructureChangeType structureChangeType, int[] runtimeId, int runtimeIdLen);

		[SecurityCritical, SuppressUnmanagedCodeSecurity]
		[DllImport("UIAutomationCore.dll", CharSet = CharSet.Unicode, EntryPoint = "UiaRaiseAsyncContentLoadedEvent")]
		private static extern int RawUiaRaiseAsyncContentLoadedEvent(IRawElementProviderSimple provider, AsyncContentLoadedState asyncContentLoadedState, double PercentComplete);

		[SecurityCritical, SuppressUnmanagedCodeSecurity]
		[DllImport("UIAutomationCore.dll", CharSet = CharSet.Unicode, EntryPoint = "UiaClientsAreListening")]
		private static extern bool RawUiaClientsAreListening();

		private const int UIA_E_ELEMENTNOTAVAILABLE = -2147220991;
	}
}
