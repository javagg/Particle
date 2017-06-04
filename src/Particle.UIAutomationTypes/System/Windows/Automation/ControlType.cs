using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public class ControlType : AutomationIdentifier
	{
		internal ControlType(int id, Guid guid, string programmaticName) : base(UiaCoreTypesApi.AutomationIdType.ControlType, id, guid, programmaticName)
		{
		}

		internal static ControlType Register(Guid guid, string programmaticName)
		{
			return (ControlType)AutomationIdentifier.Register(UiaCoreTypesApi.AutomationIdType.ControlType, guid, programmaticName);
		}

		public static ControlType LookupById(int id)
		{
			return (ControlType)AutomationIdentifier.LookupById(UiaCoreTypesApi.AutomationIdType.ControlType, id);
		}

		internal static ControlType Register(Guid guid, string programmaticName, STID stId, AutomationProperty[] requiredProperties, AutomationPattern[] neverSupportedPatterns, AutomationPattern[][] requiredPatternsSets)
		{
			ControlType controlType = (ControlType)AutomationIdentifier.Register(UiaCoreTypesApi.AutomationIdType.ControlType, guid, programmaticName);
			controlType._stId = stId;
			controlType._requiredPatternsSets = requiredPatternsSets;
			controlType._neverSupportedPatterns = neverSupportedPatterns;
			controlType._requiredProperties = requiredProperties;
			return controlType;
		}

		internal static ControlType Register(Guid guid, string programmaticName, STID stId, AutomationPattern[][] requiredPatternsSets)
		{
			return ControlType.Register(guid, programmaticName, stId, new AutomationProperty[0], new AutomationPattern[0], requiredPatternsSets);
		}

		internal static ControlType Register(Guid guid, string programmaticName, STID stId, AutomationProperty[] requiredProperties)
		{
			return ControlType.Register(guid, programmaticName, stId, requiredProperties, new AutomationPattern[0], new AutomationPattern[0][]);
		}

		internal static ControlType Register(Guid guid, string programmaticName, STID stId)
		{
			return ControlType.Register(guid, programmaticName, stId, new AutomationProperty[0], new AutomationPattern[0], new AutomationPattern[0][]);
		}

		public AutomationPattern[][] GetRequiredPatternSets()
		{
			int num = this._requiredPatternsSets.Length;
			AutomationPattern[][] array = new AutomationPattern[num][];
			for (int i = 0; i < num; i++)
			{
				array[i] = (AutomationPattern[])this._requiredPatternsSets[i].Clone();
			}
			return array;
		}

		public AutomationPattern[] GetNeverSupportedPatterns()
		{
			return (AutomationPattern[])this._neverSupportedPatterns.Clone();
		}

		public AutomationProperty[] GetRequiredProperties()
		{
			return (AutomationProperty[])this._requiredProperties.Clone();
		}

		public string LocalizedControlType
		{
			get
			{
				return ST.Get(this._stId);
			}
		}

		public static readonly ControlType Button = ControlType.Register(AutomationIdentifierGuids.Button_Control, "ControlType.Button", STID.LocalizedControlTypeButton, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				InvokePatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType Calendar = ControlType.Register(AutomationIdentifierGuids.Calendar_Control, "ControlType.Calendar", STID.LocalizedControlTypeCalendar, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				GridPatternIdentifiers.Pattern,
				ValuePatternIdentifiers.Pattern,
				SelectionPatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType CheckBox = ControlType.Register(AutomationIdentifierGuids.CheckBox_Control, "ControlType.CheckBox", STID.LocalizedControlTypeCheckBox, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				TogglePatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType ComboBox = ControlType.Register(AutomationIdentifierGuids.ComboBox_Control, "ControlType.ComboBox", STID.LocalizedControlTypeComboBox, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				SelectionPatternIdentifiers.Pattern,
				ExpandCollapsePatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType Edit = ControlType.Register(AutomationIdentifierGuids.Edit_Control, "ControlType.Edit", STID.LocalizedControlTypeEdit, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				ValuePatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType Hyperlink = ControlType.Register(AutomationIdentifierGuids.Hyperlink_Control, "ControlType.Hyperlink", STID.LocalizedControlTypeHyperlink, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				InvokePatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType Image = ControlType.Register(AutomationIdentifierGuids.Image_Control, "ControlType.Image", STID.LocalizedControlTypeImage);

		public static readonly ControlType ListItem = ControlType.Register(AutomationIdentifierGuids.ListItem_Control, "ControlType.ListItem", STID.LocalizedControlTypeListItem, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				SelectionItemPatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType List = ControlType.Register(AutomationIdentifierGuids.List_Control, "ControlType.List", STID.LocalizedControlTypeListView, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				SelectionPatternIdentifiers.Pattern,
				TablePatternIdentifiers.Pattern,
				GridPatternIdentifiers.Pattern,
				MultipleViewPatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType Menu = ControlType.Register(AutomationIdentifierGuids.Menu_Control, "ControlType.Menu", STID.LocalizedControlTypeMenu);

		public static readonly ControlType MenuBar = ControlType.Register(AutomationIdentifierGuids.MenuBar_Control, "ControlType.MenuBar", STID.LocalizedControlTypeMenuBar);

		public static readonly ControlType MenuItem = ControlType.Register(AutomationIdentifierGuids.MenuItem_Control, "ControlType.MenuItem", STID.LocalizedControlTypeMenuItem, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				InvokePatternIdentifiers.Pattern
			},
			new AutomationPattern[]
			{
				ExpandCollapsePatternIdentifiers.Pattern
			},
			new AutomationPattern[]
			{
				TogglePatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType ProgressBar = ControlType.Register(AutomationIdentifierGuids.ProgressBar_Control, "ControlType.ProgressBar", STID.LocalizedControlTypeProgressBar, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				ValuePatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType RadioButton = ControlType.Register(AutomationIdentifierGuids.RadioButton_Control, "ControlType.RadioButton", STID.LocalizedControlTypeRadioButton);

		public static readonly ControlType ScrollBar = ControlType.Register(AutomationIdentifierGuids.ScrollBar_Control, "ControlType.ScrollBar", STID.LocalizedControlTypeScrollBar);

		public static readonly ControlType Slider = ControlType.Register(AutomationIdentifierGuids.Slider_Control, "ControlType.Slider", STID.LocalizedControlTypeSlider, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				RangeValuePatternIdentifiers.Pattern
			},
			new AutomationPattern[]
			{
				SelectionPatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType Spinner = ControlType.Register(AutomationIdentifierGuids.Spinner_Control, "ControlType.Spinner", STID.LocalizedControlTypeSpinner, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				RangeValuePatternIdentifiers.Pattern
			},
			new AutomationPattern[]
			{
				SelectionPatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType StatusBar = ControlType.Register(AutomationIdentifierGuids.StatusBar_Control, "ControlType.StatusBar", STID.LocalizedControlTypeStatusBar);

		public static readonly ControlType Tab = ControlType.Register(AutomationIdentifierGuids.Tab_Control, "ControlType.Tab", STID.LocalizedControlTypeTab);

		public static readonly ControlType TabItem = ControlType.Register(AutomationIdentifierGuids.TabItem_Control, "ControlType.TabItem", STID.LocalizedControlTypeTabItem);

		public static readonly ControlType Text = ControlType.Register(AutomationIdentifierGuids.Text_Control, "ControlType.Text", STID.LocalizedControlTypeText);

		public static readonly ControlType ToolBar = ControlType.Register(AutomationIdentifierGuids.ToolBar_Control, "ControlType.ToolBar", STID.LocalizedControlTypeToolBar);

		public static readonly ControlType ToolTip = ControlType.Register(AutomationIdentifierGuids.ToolTip_Control, "ControlType.ToolTip", STID.LocalizedControlTypeToolTip);

		public static readonly ControlType Tree = ControlType.Register(AutomationIdentifierGuids.Tree_Control, "ControlType.Tree", STID.LocalizedControlTypeTreeView);

		public static readonly ControlType TreeItem = ControlType.Register(AutomationIdentifierGuids.TreeItem_Control, "ControlType.TreeItem", STID.LocalizedControlTypeTreeViewItem);

		public static readonly ControlType Custom = ControlType.Register(AutomationIdentifierGuids.Custom_Control, "ControlType.Custom", STID.LocalizedControlTypeCustom);

		public static readonly ControlType Group = ControlType.Register(AutomationIdentifierGuids.Group_Control, "ControlType.Group", STID.LocalizedControlTypeGroup);

		public static readonly ControlType Thumb = ControlType.Register(AutomationIdentifierGuids.Thumb_Control, "ControlType.Thumb", STID.LocalizedControlTypeThumb);

		public static readonly ControlType DataGrid = ControlType.Register(AutomationIdentifierGuids.DataGrid_Control, "ControlType.DataGrid", STID.LocalizedControlTypeDataGrid, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				GridPatternIdentifiers.Pattern
			},
			new AutomationPattern[]
			{
				SelectionPatternIdentifiers.Pattern
			},
			new AutomationPattern[]
			{
				TablePatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType DataItem = ControlType.Register(AutomationIdentifierGuids.DataItem_Control, "ControlType.DataItem", STID.LocalizedControlTypeDataItem, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				SelectionItemPatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType Document = ControlType.Register(AutomationIdentifierGuids.Document_Control, "ControlType.Document", STID.LocalizedControlTypeDocument, new AutomationProperty[0], new AutomationPattern[]
		{
			ValuePatternIdentifiers.Pattern
		}, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				ScrollPatternIdentifiers.Pattern
			},
			new AutomationPattern[]
			{
				TextPatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType SplitButton = ControlType.Register(AutomationIdentifierGuids.SplitButton_Control, "ControlType.SplitButton", STID.LocalizedControlTypeSplitButton, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				InvokePatternIdentifiers.Pattern
			},
			new AutomationPattern[]
			{
				ExpandCollapsePatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType Window = ControlType.Register(AutomationIdentifierGuids.Window_Control, "ControlType.Window", STID.LocalizedControlTypeWindow, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				TransformPatternIdentifiers.Pattern
			},
			new AutomationPattern[]
			{
				WindowPatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType Pane = ControlType.Register(AutomationIdentifierGuids.Pane_Control, "ControlType.Pane", STID.LocalizedControlTypePane, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				TransformPatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType Header = ControlType.Register(AutomationIdentifierGuids.Header_Control, "ControlType.Header", STID.LocalizedControlTypeHeader);

		public static readonly ControlType HeaderItem = ControlType.Register(AutomationIdentifierGuids.HeaderItem_Control, "ControlType.HeaderItem", STID.LocalizedControlTypeHeaderItem);

		public static readonly ControlType Table = ControlType.Register(AutomationIdentifierGuids.Table_Control, "ControlType.Table", STID.LocalizedControlTypeTable, new AutomationPattern[][]
		{
			new AutomationPattern[]
			{
				GridPatternIdentifiers.Pattern
			},
			new AutomationPattern[]
			{
				SelectionPatternIdentifiers.Pattern
			},
			new AutomationPattern[]
			{
				TablePatternIdentifiers.Pattern
			}
		});

		public static readonly ControlType TitleBar = ControlType.Register(AutomationIdentifierGuids.TitleBar_Control, "ControlType.TitleBar", STID.LocalizedControlTypeTitleBar);

		public static readonly ControlType Separator = ControlType.Register(AutomationIdentifierGuids.Separator_Control, "ControlType.Separator", STID.LocalizedControlTypeSeparator);

		private AutomationPattern[][] _requiredPatternsSets;

		private AutomationPattern[] _neverSupportedPatterns;

		private AutomationProperty[] _requiredProperties;

		private STID _stId;
	}
}
