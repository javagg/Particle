using System;
using MS.Internal.Automation;

namespace System.Windows.Automation
{
	public static class TextPatternIdentifiers
	{
		public static readonly object MixedAttributeValue = UiaCoreTypesApi.UiaGetReservedMixedAttributeValue();

		public static readonly AutomationTextAttribute AnimationStyleAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_AnimationStyle_Attribute, "TextPatternIdentifiers.AnimationStyleAttribute");

		public static readonly AutomationTextAttribute BackgroundColorAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_BackgroundColor_Attribute, "TextPatternIdentifiers.BackgroundColorAttribute");

		public static readonly AutomationTextAttribute BulletStyleAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_BulletStyle_Attribute, "TextPatternIdentifiers.BulletStyleAttribute");

		public static readonly AutomationTextAttribute CapStyleAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_CapStyle_Attribute, "TextPatternIdentifiers.CapStyleAttribute");

		public static readonly AutomationTextAttribute CultureAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_Culture_Attribute, "TextPatternIdentifiers.CultureAttribute");

		public static readonly AutomationTextAttribute FontNameAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_FontName_Attribute, "TextPatternIdentifiers.FontNameAttribute");

		public static readonly AutomationTextAttribute FontSizeAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_FontSize_Attribute, "TextPatternIdentifiers.FontSizeAttribute");

		public static readonly AutomationTextAttribute FontWeightAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_FontWeight_Attribute, "TextPatternIdentifiers.FontWeightAttribute");

		public static readonly AutomationTextAttribute ForegroundColorAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_ForegroundColor_Attribute, "TextPatternIdentifiers.ForegroundColorAttribute");

		public static readonly AutomationTextAttribute HorizontalTextAlignmentAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_HorizontalTextAlignment_Attribute, "TextPatternIdentifiers.HorizontalTextAlignmentAttribute");

		public static readonly AutomationTextAttribute IndentationFirstLineAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_IndentationFirstLine_Attribute, "TextPatternIdentifiers.IndentationFirstLineAttribute");

		public static readonly AutomationTextAttribute IndentationLeadingAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_IndentationLeading_Attribute, "TextPatternIdentifiers.IndentationLeadingAttribute");

		public static readonly AutomationTextAttribute IndentationTrailingAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_IndentationTrailing_Attribute, "TextPatternIdentifiers.IndentationTrailingAttribute");

		public static readonly AutomationTextAttribute IsHiddenAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_IsHidden_Attribute, "TextPatternIdentifiers.IsHiddenAttribute");

		public static readonly AutomationTextAttribute IsItalicAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_IsItalic_Attribute, "TextPatternIdentifiers.IsItalicAttribute");

		public static readonly AutomationTextAttribute IsReadOnlyAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_IsReadOnly_Attribute, "TextPatternIdentifiers.IsReadOnlyAttribute");

		public static readonly AutomationTextAttribute IsSubscriptAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_IsSubscript_Attribute, "TextPatternIdentifiers.IsSubscriptAttribute");

		public static readonly AutomationTextAttribute IsSuperscriptAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_IsSuperscript_Attribute, "TextPatternIdentifiers.IsSuperscriptAttribute");

		public static readonly AutomationTextAttribute MarginBottomAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_MarginBottom_Attribute, "TextPatternIdentifiers.MarginBottomAttribute");

		public static readonly AutomationTextAttribute MarginLeadingAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_MarginLeading_Attribute, "TextPatternIdentifiers.MarginLeadingAttribute");

		public static readonly AutomationTextAttribute MarginTopAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_MarginTop_Attribute, "TextPatternIdentifiers.MarginTopAttribute");

		public static readonly AutomationTextAttribute MarginTrailingAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_MarginTrailing_Attribute, "TextPatternIdentifiers.MarginTrailingAttribute");

		public static readonly AutomationTextAttribute OutlineStylesAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_OutlineStyles_Attribute, "TextPatternIdentifiers.OutlineStylesAttribute");

		public static readonly AutomationTextAttribute OverlineColorAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_OverlineColor_Attribute, "TextPatternIdentifiers.OverlineColorAttribute");

		public static readonly AutomationTextAttribute OverlineStyleAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_OverlineStyle_Attribute, "TextPatternIdentifiers.OverlineStyleAttribute");

		public static readonly AutomationTextAttribute StrikethroughColorAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_StrikethroughColor_Attribute, "TextPatternIdentifiers.StrikethroughColorAttribute");

		public static readonly AutomationTextAttribute StrikethroughStyleAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_StrikethroughStyle_Attribute, "TextPatternIdentifiers.StrikethroughStyleAttribute");

		public static readonly AutomationTextAttribute TabsAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_Tabs_Attribute, "TextPatternIdentifiers.TabsAttribute");

		public static readonly AutomationTextAttribute TextFlowDirectionsAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_FlowDirections_Attribute, "TextPatternIdentifiers.TextFlowDirectionsAttribute");

		public static readonly AutomationTextAttribute UnderlineColorAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_UnderlineColor_Attribute, "TextPatternIdentifiers.UnderlineColorAttribute");

		public static readonly AutomationTextAttribute UnderlineStyleAttribute = AutomationTextAttribute.Register(AutomationIdentifierGuids.Text_UnderlineStyle_Attribute, "TextPatternIdentifiers.UnderlineStyleAttribute");

		public static readonly AutomationPattern Pattern = AutomationPattern.Register(AutomationIdentifierGuids.Text_Pattern, "TextPatternIdentifiers.Pattern");

		public static readonly AutomationEvent TextSelectionChangedEvent = AutomationEvent.Register(AutomationIdentifierGuids.Text_TextSelectionChanged_Event, "TextPatternIdentifiers.TextSelectionChangedEvent");

		public static readonly AutomationEvent TextChangedEvent = AutomationEvent.Register(AutomationIdentifierGuids.Text_TextChanged_Event, "TextPatternIdentifiers.TextChangedEvent");
	}
}
