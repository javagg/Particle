using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation
{
	[ComVisible(true), Guid("e4cfef41-071d-472c-a65c-c14f59ea81eb")]
	public enum StructureChangeType
	{
		ChildAdded,
		ChildRemoved,
		ChildrenInvalidated,
		ChildrenBulkAdded,
		ChildrenBulkRemoved,
		ChildrenReordered
	}
}
