using System;

namespace MS.Internal.Text.TextInterface
{
	internal interface IClassification
	{
		void GetCharAttribute(int unicodeScalar, out bool isCombining, out bool needsCaretInfo, out bool isIndic, out bool isDigit, out bool isLatin, out bool isStrong);
	}
}
