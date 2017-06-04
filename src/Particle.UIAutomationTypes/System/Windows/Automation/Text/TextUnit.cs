using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Text
{
	[ComVisible(true), Guid("A044E5C8-FC20-4747-8CC8-1487F9CBB680")]
	public enum TextUnit
	{
		Character,
		Format,
		Word,
		Line,
		Paragraph,
		Page,
		Document
	}
}
