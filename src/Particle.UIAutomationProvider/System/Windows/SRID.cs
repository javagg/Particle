using System;
using System.Runtime.InteropServices;

namespace System.Windows
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	internal struct SRID
	{
		public const string Default = "Default";

		public const string HwndMustBeNonNULL = "HwndMustBeNonNULL";

		public const string GenericInvalidArgument = "GenericInvalidArgument";
	}
}
