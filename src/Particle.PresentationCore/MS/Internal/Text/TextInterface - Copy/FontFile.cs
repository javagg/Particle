using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface
{
	internal sealed class FontFile : IDisposable
	{
		[SecurityCritical]
		internal unsafe FontFile(IDWriteFontFile* fontFile)
		{
		}

		internal unsafe IDWriteFontFile* DWriteFontFileNoAddRef
		{
			[SecurityCritical]
			get
			{
			}
		}

		[SecuritySafeCritical]
		[return: MarshalAs(UnmanagedType.U1)]
		internal unsafe bool Analyze(out DWRITE_FONT_FILE_TYPE dwriteFontFileType, out DWRITE_FONT_FACE_TYPE dwriteFontFaceType, out uint numberOfFaces, int* hr)
		{
		}

		[SecurityCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		internal string GetUriPath()
		{
		}

		protected void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
		{
		}

		public sealed override void Dispose()
		{
		}
	}
}
