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

		private string _string;
	}
}
