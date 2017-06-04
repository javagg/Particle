using System;
using System.IO;
using System.Runtime.InteropServices;

namespace MS.Internal.Text.TextInterface
{
	internal interface IFontSource
	{
		void TestFileOpenable();

		UnmanagedMemoryStream GetUnmanagedStream();

		DateTime GetLastWriteTimeUtc();

		Uri Uri
		{
			get;
		}

		bool IsComposite
		{
			[return: MarshalAs(UnmanagedType.U1)]
			get;
		}
	}
}
