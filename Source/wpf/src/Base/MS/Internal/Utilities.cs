/**************************************************************************\
    Copyright Microsoft Corporation. All Rights Reserved.
\**************************************************************************/

namespace MS.Internal
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Security;
    using global::MS.Win32;

    /// <summary>
    /// General utility class for macro-type functions.
    /// </summary>
    internal static class Utilities
    {
        private static readonly Version _osVersion = Environment.OSVersion.Version;

        internal static bool IsOSVistaOrNewer
        {
            get { return _osVersion >= new Version(6, 0); }
        }

        internal static bool IsOSWindows7OrNewer
        {
            get { return _osVersion >= new Version(6, 1); }
        }

        internal static bool IsOSWindows8OrNewer
        {
            get { return _osVersion >= new Version(6, 2); }
        }
        
        /// <SecurityNote>
        /// Critical -- calls into an unsafe native method.
        /// TreatAsSafe -- the call to DwmIsCompositionEnabled simply returns a boolean
        ///                through an out parameter, it is safe information to expose
        /// </SecurityNote>
        internal static bool IsCompositionEnabled
        {
            [SecurityCritical, SecurityTreatAsSafe]
            get
            {
                if (!IsOSVistaOrNewer)
                {
                    return false;
                }

                Int32 isDesktopCompositionEnabled = 0;
                UnsafeNativeMethods.HRESULT.Check(UnsafeNativeMethods.DwmIsCompositionEnabled(out isDesktopCompositionEnabled));
                return isDesktopCompositionEnabled != 0;
            }
        }

        internal static void SafeDispose<T>(ref T disposable) where T : IDisposable
        {
            // Dispose can safely be called on an object multiple times.
            IDisposable t = disposable;
            disposable = default(T);
            if (null != t)
            {
                t.Dispose();
            }
        }
        
        /// <SecurityNote>
        /// Critical - Suppresses unmanaged code security.  Calls Marshal.ReleaseComObject which has a LinkDemand.
        /// </SecurityNote>
        [SuppressUnmanagedCodeSecurity, SecurityCritical]
        internal static void SafeRelease<T>(ref T comObject) where T : class
        {
            T t = comObject;
            comObject = default(T);
            if (null != t)
            {
                Debug.Assert(Marshal.IsComObject(t));
                Marshal.ReleaseComObject(t);
            }
        }
    }
}
