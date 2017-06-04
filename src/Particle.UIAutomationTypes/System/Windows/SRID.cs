using System;
using System.Runtime.InteropServices;

namespace System.Windows
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	internal struct SRID
	{
		public const string Default = "Default";

		public const string ElementNotEnabled = "ElementNotEnabled";

		public const string ElementNotAvailable = "ElementNotAvailable";
	}
}
