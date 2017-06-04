using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface
{
	internal sealed class Factory : CriticalHandle
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success), SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		[return: MarshalAs(UnmanagedType.U1)]
		protected sealed override bool ReleaseHandle()
		{
            throw new NotImplementedException();
		}

		internal unsafe IDWriteFactory* DWriteFactoryAddRef { [SecurityCritical] get; }

		[SecurityCritical]
		internal static Factory Create(FactoryType factoryType, IFontSourceCollectionFactory fontSourceCollectionFactory, IFontSourceFactory fontSourceFactory)
		{
		    throw new NotImplementedException();
        }

		[SecurityCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		internal unsafe static int CreateFontFile(IDWriteFactory* factory, FontFileLoader fontFileLoader, Uri filePathUri, IDWriteFontFile** dwriteFontFile)
		{
		    throw new NotImplementedException();
        }

		[SecurityCritical]
		internal FontFile CreateFontFile(Uri filePathUri)
		{
		    throw new NotImplementedException();
        }

		[SecurityCritical]
		internal FontFace CreateFontFace(Uri filePathUri, uint faceIndex)
		{
		    throw new NotImplementedException();
        }

		[SecurityCritical]
		internal FontFace CreateFontFace(Uri filePathUri, uint faceIndex, FontSimulations fontSimulationFlags)
		{
		    throw new NotImplementedException();
        }

		[SecuritySafeCritical]
		internal FontCollection GetSystemFontCollection([MarshalAs(UnmanagedType.U1)] bool checkForUpdates)
		{
		    throw new NotImplementedException();
        }

		internal FontCollection GetSystemFontCollection()
		{
		    throw new NotImplementedException();
        }

		[SecurityCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		internal FontCollection GetFontCollection(Uri uri)
		{
		    throw new NotImplementedException();
        }

		[return: MarshalAs(UnmanagedType.U1)]
		internal static bool IsLocalUri(Uri uri)
		{
		    throw new NotImplementedException();
        }

		[SecuritySafeCritical]
		internal static DWRITE_MATRIX GetIdentityTransform()
		{
		    throw new NotImplementedException();
        }

		[SecuritySafeCritical]
		internal TextAnalyzer CreateTextAnalyzer()
		{
		    throw new NotImplementedException();
        }

		public override bool IsInvalid
		{
		    [SecuritySafeCritical, ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		    [return: MarshalAs(UnmanagedType.U1)]
		    get;
		}

	    public Factory(IntPtr invalidHandleValue) : base(invalidHandleValue)
	    {
	    }
	}
}
