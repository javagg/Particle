using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Security;

namespace System.Windows.Media
{
    public enum TextFormattingMode
    {
        Ideal,
        Display
    }
}

namespace MS.Internal
{
    internal sealed class Span
    {
        public Span(object element, int length)
        {
        }

        public object element;

        public int length;
    }
}

namespace MS.Internal
{
    internal static class TraceRoutedEvent
    {
        public static AvTraceDetails RaiseEvent { get; }

        public static AvTraceDetails ReRaiseEventAs { get; }

        public static AvTraceDetails HandleEvent { get; }

        public static AvTraceDetails InvokeHandlers { get; }

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

        public static bool IsEnabled
        {
            get
            {
                return false;
            }
        }

        public static bool IsEnabledOverride
        {
            get { return false; }
        }

        public static void Refresh()
        {
        }
    }
}


namespace MS.Internal
{
    internal static class TraceAnimation
    {
        public static AvTraceDetails StoryboardBegin { get; }

        public static AvTraceDetails StoryboardPause { get; }

        public static AvTraceDetails StoryboardRemove { get; }

        public static AvTraceDetails StoryboardResume { get; }

        public static AvTraceDetails StoryboardStop { get; }

        public static AvTraceDetails StoryboardNotApplied { get; }

        public static AvTraceDetails AnimateStorageValidationFailed { get; }

        public static AvTraceDetails AnimateStorageValidationNoLongerFailing { get; }

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
namespace MS.Internal
{
    internal static class TrueTypeSubsetter
    {
        [SecurityCritical]
        public unsafe static byte[] ComputeSubset(void* fontData, int fileSize, Uri sourceUri, int directoryOffset, ushort[] glyphArray)
        {throw new NotImplementedException();
        }
    }
}

namespace System.Windows
{
    public static class CoreCompatibilityPreferences
    {
        #region Constructor

        static CoreCompatibilityPreferences()
        {
            // user can use config file to set preferences
            NameValueCollection appSettings = null;
            try
            {
                appSettings = ConfigurationManager.AppSettings;
            }
            catch (ConfigurationErrorsException)
            {
            }

            if (appSettings != null)
            {
                SetIncludeAllInkInBoundingBoxFromAppSettings(appSettings);
                SetEnableMultiMonitorDisplayClippingFromAppSettings(appSettings);
            }
        }

        #endregion Constructor

        #region CLR compat flags

        internal static bool TargetsAtLeast_Desktop_V4_5
        { get { return true; } }

        #endregion CLR compat flags

        #region IsAltKeyRequiredInAccessKeyDefaultScope

        // We decided NOT to opt-in this feature by default.
        private static bool _isAltKeyRequiredInAccessKeyDefaultScope = false;

        public static bool IsAltKeyRequiredInAccessKeyDefaultScope
        {
            get { return _isAltKeyRequiredInAccessKeyDefaultScope; }
            set
            {
                lock (_lockObject)
                {
                    if (_isSealed)
                    {
                 //       throw new InvalidOperationException(SR.Get(SRID.CompatibilityPreferencesSealed, "IsAltKeyRequiredInAccessKeyDefaultScope", "CoreCompatibilityPreferences"));
                    }

                    _isAltKeyRequiredInAccessKeyDefaultScope = value;
                }
            }
        }

        internal static bool GetIsAltKeyRequiredInAccessKeyDefaultScope()
        {
            Seal();

            return IsAltKeyRequiredInAccessKeyDefaultScope;
        }

        #endregion IsAltKeyRequiredInAccessKeyDefaultScope

        #region IncludeAllInkInBoundingBox

        // GlyphRun.ComputeInkBoundingBox is supposed to return a box that contains
        // all the ink in the GlyphRun, but in some circumstances it computes a
        // box that is too small.  This was "fixed" in 4.5 by inflating the box
        // slightly.  Apps that depend on the old non-inflated result can opt out
        // of the fix by adding an entry to the <appSettings> section of the
        // app config file:
        //          <add key="IncludeAllInkInBoundingBox" value="false"/>
        // By doing so, the app loses the fix - certain strings may not render
        // or hit-test correctly.  (See GlyphRun.ComputeInkBoundingBox for more.)

        private static bool _includeAllInkInBoundingBox = true;

        internal static bool IncludeAllInkInBoundingBox
        {
            get { return _includeAllInkInBoundingBox; }
            set
            {
                lock (_lockObject)
                {
                    if (_isSealed)
                    {
                  //      throw new InvalidOperationException(SR.Get(SRID.CompatibilityPreferencesSealed, "IncludeAllInkInBoundingBox", "CoreCompatibilityPreferences"));
                    }

                    _includeAllInkInBoundingBox = value;
                }
            }
        }

        internal static bool GetIncludeAllInkInBoundingBox()
        {
            Seal();

            return IncludeAllInkInBoundingBox;
        }

        static void SetIncludeAllInkInBoundingBoxFromAppSettings(NameValueCollection appSettings)
        {
            // user can use config file to opt out of GlyphRun.ComputeInkBoundingBox fixes
            string s = appSettings["IncludeAllInkInBoundingBox"];
            bool value;
            if (Boolean.TryParse(s, out value))
            {
                IncludeAllInkInBoundingBox = value;
            }
        }

        #endregion IncludeAllInkInBoundingBox

        #region EnableMultimonitorDisplayClipping

        private static bool? _enableMultiMonitorDisplayClipping = null;

        public static bool? EnableMultiMonitorDisplayClipping
        {
            get { return GetEnableMultiMonitorDisplayClipping(); }
            set
            {
                lock (_lockObject)
                {
                    if (_isSealed)
                    {
                 //       throw new InvalidOperationException(SR.Get(SRID.CompatibilityPreferencesSealed, "DisableMultimonDisplayClipping", "CoreCompatibilityPreferences"));
                    }

                    _enableMultiMonitorDisplayClipping = value;
                }
            }
        }

        internal static bool? GetEnableMultiMonitorDisplayClipping()
        {
            Seal();

            return _enableMultiMonitorDisplayClipping;
        }

        static void SetEnableMultiMonitorDisplayClippingFromAppSettings(NameValueCollection appSettings)
        {
            string s = appSettings["EnableMultiMonitorDisplayClipping"];
            bool value;
            if (Boolean.TryParse(s, out value))
            {
                EnableMultiMonitorDisplayClipping = value;
            }
        }

        #endregion

        private static void Seal()
        {
            if (!_isSealed)
            {
                lock (_lockObject)
                {
                    _isSealed = true;
                }
            }
        }

        private static bool _isSealed;
        private static object _lockObject = new object();
    }
}
