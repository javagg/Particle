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
		}

		internal unsafe IDWriteFactory* DWriteFactoryAddRef
		{
			[SecurityCritical]
			get
			{
			}
		}

		[SecurityCritical]
		internal static Factory Create(FactoryType factoryType, IFontSourceCollectionFactory fontSourceCollectionFactory, IFontSourceFactory fontSourceFactory)
		{
		}

		[SecurityCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		internal unsafe static int CreateFontFile(IDWriteFactory* factory, FontFileLoader fontFileLoader, Uri filePathUri, IDWriteFontFile** dwriteFontFile)
		{
		}

		[SecurityCritical]
		internal FontFile CreateFontFile(Uri filePathUri)
		{
		}

		[SecurityCritical]
		internal FontFace CreateFontFace(Uri filePathUri, uint faceIndex)
		{
		}

		[SecurityCritical]
		internal FontFace CreateFontFace(Uri filePathUri, uint faceIndex, FontSimulations fontSimulationFlags)
		{
		}

		[SecuritySafeCritical]
		internal FontCollection GetSystemFontCollection([MarshalAs(UnmanagedType.U1)] bool checkForUpdates)
		{
		}

		internal FontCollection GetSystemFontCollection()
		{
		}

		[SecurityCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		internal FontCollection GetFontCollection(Uri uri)
		{
		}

		[return: MarshalAs(UnmanagedType.U1)]
		internal static bool IsLocalUri(Uri uri)
		{
		}

		[SecuritySafeCritical]
		internal static DWRITE_MATRIX GetIdentityTransform()
		{
		}

		[SecuritySafeCritical]
		internal TextAnalyzer CreateTextAnalyzer()
		{
		}

		public override bool IsInvalid
		{
			[SecuritySafeCritical, ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			[return: MarshalAs(UnmanagedType.U1)]
			get
			{
			}
		}

		private new void ctor()
		{
		}
	}
}
