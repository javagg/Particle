using System;

namespace System.Windows.Automation
{
	public sealed class StructureChangedEventArgs : AutomationEventArgs
	{
		public StructureChangedEventArgs(StructureChangeType structureChangeType, int[] runtimeId) : base(AutomationElementIdentifiers.StructureChangedEvent)
		{
			if (runtimeId == null)
			{
				throw new ArgumentNullException("runtimeId");
			}
			this._structureChangeType = structureChangeType;
			this._runtimeID = (int[])runtimeId.Clone();
		}

		public int[] GetRuntimeId()
		{
			return (int[])this._runtimeID.Clone();
		}

		public StructureChangeType StructureChangeType
		{
			get
			{
				return this._structureChangeType;
			}
		}

		private StructureChangeType _structureChangeType;

		private int[] _runtimeID;
	}
}
