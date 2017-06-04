using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MS.Internal.Automation
{
	internal static class UiaCoreTypesApi
	{
		[SecurityCritical, SecurityTreatAsSafe]
		internal static int UiaLookupId(UiaCoreTypesApi.AutomationIdType type, ref Guid guid)
		{
			return UiaCoreTypesApi.RawUiaLookupId(type, ref guid);
		}

		[SecurityCritical, SecurityTreatAsSafe]
		internal static object UiaGetReservedNotSupportedValue()
		{
			object result;
			UiaCoreTypesApi.CheckError(UiaCoreTypesApi.RawUiaGetReservedNotSupportedValue(out result));
			return result;
		}

		[SecurityCritical, SecurityTreatAsSafe]
		internal static object UiaGetReservedMixedAttributeValue()
		{
			object result;
			UiaCoreTypesApi.CheckError(UiaCoreTypesApi.RawUiaGetReservedMixedAttributeValue(out result));
			return result;
		}

		[SecurityCritical, SecurityTreatAsSafe]
		private static void CheckError(int hr)
		{
			if (hr >= 0)
			{
				return;
			}
			Marshal.ThrowExceptionForHR(hr, (IntPtr)(-1));
		}

		[SecurityCritical, SuppressUnmanagedCodeSecurity]
		[DllImport("UIAutomationCore.dll", CharSet = CharSet.Unicode, EntryPoint = "UiaLookupId")]
		private static extern int RawUiaLookupId(UiaCoreTypesApi.AutomationIdType type, ref Guid guid);

		[SecurityCritical, SuppressUnmanagedCodeSecurity]
		[DllImport("UIAutomationCore.dll", CharSet = CharSet.Unicode, EntryPoint = "UiaGetReservedNotSupportedValue")]
		private static extern int RawUiaGetReservedNotSupportedValue([MarshalAs(UnmanagedType.IUnknown)] out object notSupportedValue);

		[SecurityCritical, SuppressUnmanagedCodeSecurity]
		[DllImport("UIAutomationCore.dll", CharSet = CharSet.Unicode, EntryPoint = "UiaGetReservedMixedAttributeValue")]
		private static extern int RawUiaGetReservedMixedAttributeValue([MarshalAs(UnmanagedType.IUnknown)] out object mixedAttributeValue);

		internal const int UIA_E_ELEMENTNOTENABLED = -2147220992;

		internal const int UIA_E_ELEMENTNOTAVAILABLE = -2147220991;

		internal const int UIA_E_NOCLICKABLEPOINT = -2147220990;

		internal const int UIA_E_PROXYASSEMBLYNOTLOADED = -2147220989;

		internal enum AutomationIdType
		{
			Property,
			Pattern,
			Event,
			ControlType,
			TextAttribute
		}
	}
}
