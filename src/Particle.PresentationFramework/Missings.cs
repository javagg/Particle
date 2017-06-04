using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MS.Internal
{
	internal static class TraceResourceDictionary
	{
		public static AvTraceDetails AddResource
		{
			get
			{
				if (TraceResourceDictionary._AddResource == null)
				{
					TraceResourceDictionary._AddResource = new AvTraceDetails(1, new string[]
					{
						"Resource has been added to ResourceDictionary",
						"Dictionary",
						"ResourceKey",
						"Value"
					});
				}
				return TraceResourceDictionary._AddResource;
			}
		}

		public static AvTraceDetails RealizeDeferContent
		{
			get
			{
				if (TraceResourceDictionary._RealizeDeferContent == null)
				{
					TraceResourceDictionary._RealizeDeferContent = new AvTraceDetails(2, new string[]
					{
						"Delayed creation of resource",
						"Dictionary",
						"ResourceKey",
						"Value"
					});
				}
				return TraceResourceDictionary._RealizeDeferContent;
			}
		}

		public static AvTraceDetails FoundResourceOnElement
		{
			get
			{
				if (TraceResourceDictionary._FoundResourceOnElement == null)
				{
					TraceResourceDictionary._FoundResourceOnElement = new AvTraceDetails(3, new string[]
					{
						"Found resource item on an element",
						"Element",
						"ResourceKey",
						"Value"
					});
				}
				return TraceResourceDictionary._FoundResourceOnElement;
			}
		}

		public static AvTraceDetails FoundResourceInStyle
		{
			get
			{
				if (TraceResourceDictionary._FoundResourceInStyle == null)
				{
					TraceResourceDictionary._FoundResourceInStyle = new AvTraceDetails(4, new string[]
					{
						"Found resource item in a style",
						"Dictionary",
						"ResourceKey",
						"Style",
						"Element",
						"Value"
					});
				}
				return TraceResourceDictionary._FoundResourceInStyle;
			}
		}

		public static AvTraceDetails FoundResourceInTemplate
		{
			get
			{
				if (TraceResourceDictionary._FoundResourceInTemplate == null)
				{
					TraceResourceDictionary._FoundResourceInTemplate = new AvTraceDetails(5, new string[]
					{
						"Found resource item in a template",
						"Dictionary",
						"ResourceKey",
						"Template",
						"Element",
						"Value"
					});
				}
				return TraceResourceDictionary._FoundResourceInTemplate;
			}
		}

		public static AvTraceDetails FoundResourceInThemeStyle
		{
			get
			{
				if (TraceResourceDictionary._FoundResourceInThemeStyle == null)
				{
					TraceResourceDictionary._FoundResourceInThemeStyle = new AvTraceDetails(6, new string[]
					{
						"Found resource item in a theme style",
						"Dictionary",
						"ResourceKey",
						"ThemeStyle",
						"Element",
						"Value"
					});
				}
				return TraceResourceDictionary._FoundResourceInThemeStyle;
			}
		}

		public static AvTraceDetails FoundResourceInApplication
		{
			get
			{
				if (TraceResourceDictionary._FoundResourceInApplication == null)
				{
					TraceResourceDictionary._FoundResourceInApplication = new AvTraceDetails(7, new string[]
					{
						"Found resource item in application",
						"ResourceKey",
						"Value"
					});
				}
				return TraceResourceDictionary._FoundResourceInApplication;
			}
		}

		public static AvTraceDetails FoundResourceInTheme
		{
			get
			{
				if (TraceResourceDictionary._FoundResourceInTheme == null)
				{
					TraceResourceDictionary._FoundResourceInTheme = new AvTraceDetails(8, new string[]
					{
						"Found resource item in theme",
						"Dictionary",
						"ResourceKey",
						"Value"
					});
				}
				return TraceResourceDictionary._FoundResourceInTheme;
			}
		}

		public static AvTraceDetails ResourceNotFound
		{
			get
			{
				if (TraceResourceDictionary._ResourceNotFound == null)
				{
					TraceResourceDictionary._ResourceNotFound = new AvTraceDetails(9, new string[]
					{
						"Resource not found",
						"ResourceKey"
					});
				}
				return TraceResourceDictionary._ResourceNotFound;
			}
		}

		public static AvTraceDetails NewResourceDictionary
		{
			get
			{
				if (TraceResourceDictionary._NewResourceDictionary == null)
				{
					TraceResourceDictionary._NewResourceDictionary = new AvTraceDetails(10, new string[]
					{
						"New resource dictionary set",
						"Owner",
						"OldDictionary",
						"NewDictionary"
					});
				}
				return TraceResourceDictionary._NewResourceDictionary;
			}
		}

		public static AvTraceDetails FindResource
		{
			get
			{
				if (TraceResourceDictionary._FindResource == null)
				{
					TraceResourceDictionary._FindResource = new AvTraceDetails(11, new string[]
					{
						"Searching for resource",
						"Element",
						"ResourceKey"
					});
				}
				return TraceResourceDictionary._FindResource;
			}
		}

		public static AvTraceDetails SetKey
		{
			get
			{
				if (TraceResourceDictionary._SetKey == null)
				{
					TraceResourceDictionary._SetKey = new AvTraceDetails(12, new string[]
					{
						"Deferred resource has been added to ResourceDictionary",
						"Dictionary",
						"ResourceKey"
					});
				}
				return TraceResourceDictionary._SetKey;
			}
		}

		public static void Trace(TraceEventType type, AvTraceDetails traceDetails, params object[] parameters)
		{
			TraceResourceDictionary._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, parameters);
		}

		public static void Trace(TraceEventType type, AvTraceDetails traceDetails)
		{
			TraceResourceDictionary._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[0]);
		}

		public static void Trace(TraceEventType type, AvTraceDetails traceDetails, object p1)
		{
			TraceResourceDictionary._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
			{
				p1
			});
		}

		public static void Trace(TraceEventType type, AvTraceDetails traceDetails, object p1, object p2)
		{
			TraceResourceDictionary._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
			{
				p1,
				p2
			});
		}

		public static void Trace(TraceEventType type, AvTraceDetails traceDetails, object p1, object p2, object p3)
		{
			TraceResourceDictionary._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
			{
				p1,
				p2,
				p3
			});
		}

		public static void TraceActivityItem(AvTraceDetails traceDetails, params object[] parameters)
		{
			TraceResourceDictionary._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, parameters);
		}

		public static void TraceActivityItem(AvTraceDetails traceDetails)
		{
			TraceResourceDictionary._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[0]);
		}

		public static void TraceActivityItem(AvTraceDetails traceDetails, object p1)
		{
			TraceResourceDictionary._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
			{
				p1
			});
		}

		public static void TraceActivityItem(AvTraceDetails traceDetails, object p1, object p2)
		{
			TraceResourceDictionary._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
			{
				p1,
				p2
			});
		}

		public static void TraceActivityItem(AvTraceDetails traceDetails, object p1, object p2, object p3)
		{
			TraceResourceDictionary._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
			{
				p1,
				p2,
				p3
			});
		}

		public static bool IsEnabled
		{
			get
			{
				return TraceResourceDictionary._avTrace != null && TraceResourceDictionary._avTrace.IsEnabled;
			}
		}

		public static bool IsEnabledOverride
		{
			get
			{
				return TraceResourceDictionary._avTrace.IsEnabledOverride;
			}
		}

		public static void Refresh()
		{
			TraceResourceDictionary._avTrace.Refresh();
		}

		private static AvTrace _avTrace;

		private static AvTraceDetails _AddResource;

		private static AvTraceDetails _RealizeDeferContent;

		private static AvTraceDetails _FoundResourceOnElement;

		private static AvTraceDetails _FoundResourceInStyle;

		private static AvTraceDetails _FoundResourceInTemplate;

		private static AvTraceDetails _FoundResourceInThemeStyle;

		private static AvTraceDetails _FoundResourceInApplication;

		private static AvTraceDetails _FoundResourceInTheme;

		private static AvTraceDetails _ResourceNotFound;

		private static AvTraceDetails _NewResourceDictionary;

		private static AvTraceDetails _FindResource;

		private static AvTraceDetails _SetKey;
	}
}
