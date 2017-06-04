using System;
using System.Security;

namespace MS.Internal.Text.TextInterface
{
	[SecurityCritical]
	internal unsafe delegate void* CreateTextAnalysisSink();
}
