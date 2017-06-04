using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MS.Internal
{
	internal static class TraceDependencyProperty
	{
		public static AvTraceDetails ApplyTemplateContent
		{
			get
			{
				if (TraceDependencyProperty._ApplyTemplateContent == null)
				{
					TraceDependencyProperty._ApplyTemplateContent = new AvTraceDetails(1, new string[]
					{
						"Apply template",
						"Element",
						"Template"
					});
				}
				return TraceDependencyProperty._ApplyTemplateContent;
			}
		}

		public static AvTraceDetails Register
		{
			get
			{
				if (TraceDependencyProperty._Register == null)
				{
					TraceDependencyProperty._Register = new AvTraceDetails(2, new string[]
					{
						"Registered DependencyProperty",
						"DP",
						"OwnerType"
					});
				}
				return TraceDependencyProperty._Register;
			}
		}

		public static AvTraceDetails UpdateEffectiveValueStart
		{
			get
			{
				if (TraceDependencyProperty._UpdateEffectiveValueStart == null)
				{
					TraceDependencyProperty._UpdateEffectiveValueStart = new AvTraceDetails(3, new string[]
					{
						"Update effective DP value (Start)",
						"DependencyObject",
						"DP",
						"DpOwnerType",
						"Value",
						"ValueSource"
					});
				}
				return TraceDependencyProperty._UpdateEffectiveValueStart;
			}
		}

		public static AvTraceDetails UpdateEffectiveValueStop
		{
			get
			{
				if (TraceDependencyProperty._UpdateEffectiveValueStop == null)
				{
					TraceDependencyProperty._UpdateEffectiveValueStop = new AvTraceDetails(4, new string[]
					{
						"Update effective DP value (Stop)",
						"DependencyObject",
						"DP",
						"DpOwnerType",
						"Value",
						"ValueSource"
					});
				}
				return TraceDependencyProperty._UpdateEffectiveValueStop;
			}
		}

		public static void Trace(TraceEventType type, AvTraceDetails traceDetails, params object[] parameters)
		{
			TraceDependencyProperty._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, parameters);
		}

		public static void Trace(TraceEventType type, AvTraceDetails traceDetails)
		{
			TraceDependencyProperty._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[0]);
		}

		public static void Trace(TraceEventType type, AvTraceDetails traceDetails, object p1)
		{
			TraceDependencyProperty._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
			{
				p1
			});
		}

		public static void Trace(TraceEventType type, AvTraceDetails traceDetails, object p1, object p2)
		{
			TraceDependencyProperty._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
			{
				p1,
				p2
			});
		}

		public static void Trace(TraceEventType type, AvTraceDetails traceDetails, object p1, object p2, object p3)
		{
			TraceDependencyProperty._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
			{
				p1,
				p2,
				p3
			});
		}

		public static void TraceActivityItem(AvTraceDetails traceDetails, params object[] parameters)
		{
			TraceDependencyProperty._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, parameters);
		}

		public static void TraceActivityItem(AvTraceDetails traceDetails)
		{
			TraceDependencyProperty._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[0]);
		}

		public static void TraceActivityItem(AvTraceDetails traceDetails, object p1)
		{
			TraceDependencyProperty._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
			{
				p1
			});
		}

		public static void TraceActivityItem(AvTraceDetails traceDetails, object p1, object p2)
		{
			TraceDependencyProperty._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
			{
				p1,
				p2
			});
		}

		public static void TraceActivityItem(AvTraceDetails traceDetails, object p1, object p2, object p3)
		{
			TraceDependencyProperty._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
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
				return TraceDependencyProperty._avTrace != null && TraceDependencyProperty._avTrace.IsEnabled;
			}
		}

		public static bool IsEnabledOverride
		{
			get
			{
				return TraceDependencyProperty._avTrace.IsEnabledOverride;
			}
		}

		public static void Refresh()
		{
			TraceDependencyProperty._avTrace.Refresh();
		}

		private static AvTrace _avTrace = new AvTrace(delegate { return null; }, delegate { });

		private static AvTraceDetails _ApplyTemplateContent;

		private static AvTraceDetails _Register;

		private static AvTraceDetails _UpdateEffectiveValueStart;

		private static AvTraceDetails _UpdateEffectiveValueStop;

	}

}


namespace MS.Internal
{
    internal static class TraceNameScope
    {
        public static AvTraceDetails RegisterName
        {
            get
            {
                if (TraceNameScope._RegisterName == null)
                {
                    TraceNameScope._RegisterName = new AvTraceDetails(1, new string[]
                    {
                        "Name has been registered on INameScope",
                        "NameScope",
                        "Name",
                        "Object"
                    });
                }
                return TraceNameScope._RegisterName;
            }
        }

        public static AvTraceDetails UnregisterName
        {
            get
            {
                if (TraceNameScope._UnregisterName == null)
                {
                    TraceNameScope._UnregisterName = new AvTraceDetails(2, new string[]
                    {
                        "Name has been un-registered on INameScope",
                        "NameScope",
                        "Name"
                    });
                }
                return TraceNameScope._UnregisterName;
            }
        }

        public static void Trace(TraceEventType type, AvTraceDetails traceDetails, params object[] parameters)
        {
            TraceNameScope._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, parameters);
        }

        public static void Trace(TraceEventType type, AvTraceDetails traceDetails)
        {
            TraceNameScope._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[0]);
        }

        public static void Trace(TraceEventType type, AvTraceDetails traceDetails, object p1)
        {
            TraceNameScope._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
            {
                p1
            });
        }

        public static void Trace(TraceEventType type, AvTraceDetails traceDetails, object p1, object p2)
        {
            TraceNameScope._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
            {
                p1,
                p2
            });
        }

        public static void Trace(TraceEventType type, AvTraceDetails traceDetails, object p1, object p2, object p3)
        {
            TraceNameScope._avTrace.Trace(type, traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
            {
                p1,
                p2,
                p3
            });
        }

        public static void TraceActivityItem(AvTraceDetails traceDetails, params object[] parameters)
        {
            TraceNameScope._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, parameters);
        }

        public static void TraceActivityItem(AvTraceDetails traceDetails)
        {
            TraceNameScope._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[0]);
        }

        public static void TraceActivityItem(AvTraceDetails traceDetails, object p1)
        {
            TraceNameScope._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
            {
                p1
            });
        }

        public static void TraceActivityItem(AvTraceDetails traceDetails, object p1, object p2)
        {
            TraceNameScope._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
            {
                p1,
                p2
            });
        }

        public static void TraceActivityItem(AvTraceDetails traceDetails, object p1, object p2, object p3)
        {
            TraceNameScope._avTrace.TraceStartStop(traceDetails.Id, traceDetails.Message, traceDetails.Labels, new object[]
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
                return TraceNameScope._avTrace != null && TraceNameScope._avTrace.IsEnabled;
            }
        }

        public static bool IsEnabledOverride
        {
            get
            {
                return TraceNameScope._avTrace.IsEnabledOverride;
            }
        }

        public static void Refresh()
        {
            TraceNameScope._avTrace.Refresh();
        }

        //  private static AvTrace _avTrace = new AvTrace(new GetTraceSourceDelegate(TraceNameScope.<> c.<> 9.<.cctor > b__22_0), new ClearTraceSourceDelegate(TraceNameScope.<> c.<> 9.<.cctor > b__22_1));
        private static AvTrace _avTrace = new AvTrace(delegate { return null; }, delegate { });
        //<> 9.<.cctor > b__22_0), new ClearTraceSourceDelegate(TraceNameScope.<> c.<> 9.<.cctor > b__22_1));

        private static AvTraceDetails _RegisterName;

        private static AvTraceDetails _UnregisterName;
        //
        //            [CompilerGenerated]
        //            [Serializable]
        //            private sealed class <>c
        //            {
        //            internal TraceSource<.cctor> b__22_0()
        //            {
        //                return PresentationTraceSources.NameScopeSource;
        //            }
        //
        //            internal void <.cctor>b__22_1()
        //            {
        //                PresentationTraceSources._NameScopeSource = null;
        //            }
        //
        //            public static readonly TraceNameScope.<>c<>9 = new TraceNameScope.<>c();
    }
}

namespace MS.Internal
{
    internal static class TraceFreezable
    {
        public static AvTraceDetails UnableToFreezeExpression { get; }

        public static AvTraceDetails UnableToFreezeDispatcherObjectWithThreadAffinity { get; }

        public static AvTraceDetails UnableToFreezeFreezableSubProperty { get; }

        public static AvTraceDetails UnableToFreezeAnimatedProperties { get; }

        public static void Trace(TraceEventType type, AvTraceDetails traceDetails, params object[] parameters)
        {
        }

        public static void Trace(TraceEventType type, AvTraceDetails traceDetails)
        {
        }

        public static void Trace(TraceEventType type, AvTraceDetails traceDetails, object p1)
        {
        }

        public static void Trace(TraceEventType type, AvTraceDetails traceDetails, object p1, object p2)
        {
        }

        public static void Trace(TraceEventType type, AvTraceDetails traceDetails, object p1, object p2, object p3)
        {
        }

        public static void TraceActivityItem(AvTraceDetails traceDetails, params object[] parameters)
        {
        }

        public static void TraceActivityItem(AvTraceDetails traceDetails)
        {
        }

        public static void TraceActivityItem(AvTraceDetails traceDetails, object p1)
        {
        }

        public static void TraceActivityItem(AvTraceDetails traceDetails, object p1, object p2)
        {
        }

        public static void TraceActivityItem(AvTraceDetails traceDetails, object p1, object p2, object p3)
        {
        }

        public static bool IsEnabled { get; }

        public static bool IsEnabledOverride { get; }

        public static void Refresh()
        {
        }
    }
}
