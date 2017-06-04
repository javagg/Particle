using System;
using System.Globalization;
using System.Resources;

namespace System.Windows
{
	internal static class ST
	{
		internal static string Get(STID id)
		{
			string @string = ST._resourceManager.GetString(id.String);
			if (@string == null)
			{
				@string = ST._resourceManager.GetString("Unavailable");
			}
			return @string;
		}

		internal static string Get(STID id, params object[] args)
		{
			string text = ST._resourceManager.GetString(id.String);
			if (text == null)
			{
				text = ST._resourceManager.GetString("Unavailable");
			}
			else if (args != null && args.Length != 0)
			{
				text = string.Format(CultureInfo.CurrentCulture, text, args);
			}
			return text;
		}

		internal static ResourceManager ResourceManager
		{
			get
			{
				return ST._resourceManager;
			}
		}

		private static ResourceManager _resourceManager = new ResourceManager("StringTable", typeof(ST).Assembly);
	}
}
