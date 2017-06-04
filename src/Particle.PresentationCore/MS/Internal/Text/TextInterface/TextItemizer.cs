using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace MS.Internal.Text.TextInterface
{
	[ClassInterface(ClassInterfaceType.None), ComVisible(true), SecurityCritical(SecurityCriticalScope.Everything)]
	internal class TextItemizer
	{
		public unsafe TextItemizer(void* pScriptAnalysisListHead, void* pNumberSubstitutionListHead)
		{
		}

		[SecurityCritical]
		public unsafe IList<Span> Itemize(CultureInfo numberCulture, byte* pCharAttribute, uint textLength)
		{throw new NotImplementedException();
		}

		public void SetIsDigit(uint textPosition, uint textLength, [MarshalAs(UnmanagedType.U1)] bool isDigit)
		{
		}
	}
}
