using System;

namespace System.Windows
{
	internal struct STID
	{
		public string String
		{
			get
			{
				return this._string;
			}
		}

		private STID(string s)
		{
			this._string = s;
		}

		public static STID Default
		{
			get
			{
				return new STID("");
			}
		}

		public static STID LocalizedControlTypeButton
		{
			get
			{
				return new STID("LocalizedControlTypeButton");
			}
		}

		public static STID LocalizedControlTypeCalendar
		{
			get
			{
				return new STID("LocalizedControlTypeCalendar");
			}
		}

		public static STID LocalizedControlTypeCheckBox
		{
			get
			{
				return new STID("LocalizedControlTypeCheckBox");
			}
		}

		public static STID LocalizedControlTypeComboBox
		{
			get
			{
				return new STID("LocalizedControlTypeComboBox");
			}
		}

		public static STID LocalizedControlTypeEdit
		{
			get
			{
				return new STID("LocalizedControlTypeEdit");
			}
		}

		public static STID LocalizedControlTypeHyperlink
		{
			get
			{
				return new STID("LocalizedControlTypeHyperlink");
			}
		}

		public static STID LocalizedControlTypeImage
		{
			get
			{
				return new STID("LocalizedControlTypeImage");
			}
		}

		public static STID LocalizedControlTypeListItem
		{
			get
			{
				return new STID("LocalizedControlTypeListItem");
			}
		}

		public static STID LocalizedControlTypeListView
		{
			get
			{
				return new STID("LocalizedControlTypeListView");
			}
		}

		public static STID LocalizedControlTypeMenu
		{
			get
			{
				return new STID("LocalizedControlTypeMenu");
			}
		}

		public static STID LocalizedControlTypeMenuBar
		{
			get
			{
				return new STID("LocalizedControlTypeMenuBar");
			}
		}

		public static STID LocalizedControlTypeMenuItem
		{
			get
			{
				return new STID("LocalizedControlTypeMenuItem");
			}
		}

		public static STID LocalizedControlTypeProgressBar
		{
			get
			{
				return new STID("LocalizedControlTypeProgressBar");
			}
		}

		public static STID LocalizedControlTypeRadioButton
		{
			get
			{
				return new STID("LocalizedControlTypeRadioButton");
			}
		}

		public static STID LocalizedControlTypeScrollBar
		{
			get
			{
				return new STID("LocalizedControlTypeScrollBar");
			}
		}

		public static STID LocalizedControlTypeSlider
		{
			get
			{
				return new STID("LocalizedControlTypeSlider");
			}
		}

		public static STID LocalizedControlTypeSpinner
		{
			get
			{
				return new STID("LocalizedControlTypeSpinner");
			}
		}

		public static STID LocalizedControlTypeStatusBar
		{
			get
			{
				return new STID("LocalizedControlTypeStatusBar");
			}
		}

		public static STID LocalizedControlTypeTab
		{
			get
			{
				return new STID("LocalizedControlTypeTab");
			}
		}

		public static STID LocalizedControlTypeTabItem
		{
			get
			{
				return new STID("LocalizedControlTypeTabItem");
			}
		}

		public static STID LocalizedControlTypeText
		{
			get
			{
				return new STID("LocalizedControlTypeText");
			}
		}

		public static STID LocalizedControlTypeToolBar
		{
			get
			{
				return new STID("LocalizedControlTypeToolBar");
			}
		}

		public static STID LocalizedControlTypeToolTip
		{
			get
			{
				return new STID("LocalizedControlTypeToolTip");
			}
		}

		public static STID LocalizedControlTypeTreeView
		{
			get
			{
				return new STID("LocalizedControlTypeTreeView");
			}
		}

		public static STID LocalizedControlTypeTreeViewItem
		{
			get
			{
				return new STID("LocalizedControlTypeTreeViewItem");
			}
		}

		public static STID LocalizedControlTypeCustom
		{
			get
			{
				return new STID("LocalizedControlTypeCustom");
			}
		}

		public static STID LocalizedControlTypeGroup
		{
			get
			{
				return new STID("LocalizedControlTypeGroup");
			}
		}

		public static STID LocalizedControlTypeThumb
		{
			get
			{
				return new STID("LocalizedControlTypeThumb");
			}
		}

		public static STID LocalizedControlTypeDataGrid
		{
			get
			{
				return new STID("LocalizedControlTypeDataGrid");
			}
		}

		public static STID LocalizedControlTypeDataItem
		{
			get
			{
				return new STID("LocalizedControlTypeDataItem");
			}
		}

		public static STID LocalizedControlTypeDocument
		{
			get
			{
				return new STID("LocalizedControlTypeDocument");
			}
		}

		public static STID LocalizedControlTypeSplitButton
		{
			get
			{
				return new STID("LocalizedControlTypeSplitButton");
			}
		}

		public static STID LocalizedControlTypeWindow
		{
			get
			{
				return new STID("LocalizedControlTypeWindow");
			}
		}

		public static STID LocalizedControlTypePane
		{
			get
			{
				return new STID("LocalizedControlTypePane");
			}
		}

		public static STID LocalizedControlTypeHeader
		{
			get
			{
				return new STID("LocalizedControlTypeHeader");
			}
		}

		public static STID LocalizedControlTypeHeaderItem
		{
			get
			{
				return new STID("LocalizedControlTypeHeaderItem");
			}
		}

		public static STID LocalizedControlTypeTable
		{
			get
			{
				return new STID("LocalizedControlTypeTable");
			}
		}

		public static STID LocalizedControlTypeTitleBar
		{
			get
			{
				return new STID("LocalizedControlTypeTitleBar");
			}
		}

		public static STID LocalizedControlTypeSeparator
		{
			get
			{
				return new STID("LocalizedControlTypeSeparator");
			}
		}

		private string _string;
	}
}
