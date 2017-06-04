using System;

namespace MS.Internal.Text.TextInterface
{
	internal struct DWriteFontFeature
	{
		public DWriteFontFeature(DWriteFontFeatureTag dwriteNameTag, uint dwriteParameter)
		{
		}

		public DWriteFontFeatureTag nameTag;

		public uint parameter;
	}
}
