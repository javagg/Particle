using System;

namespace MS.Internal.Text.TextInterface
{
	internal struct DWriteFontFeature
	{
		public DWriteFontFeature(DWriteFontFeatureTag dwriteNameTag, uint dwriteParameter)
		{
		    parameter = dwriteParameter;
		    nameTag = dwriteNameTag;

		}

		public DWriteFontFeatureTag nameTag;

	    public uint parameter;
	}
}
