using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Text
{
	[ComVisible(true), Guid("4E33C74B-7848-4f1e-B819-A0D866C2EA1F")]
	public enum CapStyle
	{
		None,
		SmallCap,
		AllCap,
		AllPetiteCaps,
		PetiteCaps,
		Unicase,
		Titling,
		Other = -1
	}
}
