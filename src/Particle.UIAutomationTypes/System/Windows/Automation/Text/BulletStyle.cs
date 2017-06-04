using System;
using System.Runtime.InteropServices;

namespace System.Windows.Automation.Text
{
	[ComVisible(true), Guid("814FAC6C-F8DE-4682-AF5F-37C4F720990C")]
	public enum BulletStyle
	{
		None,
		HollowRoundBullet,
		FilledRoundBullet,
		HollowSquareBullet,
		FilledSquareBullet,
		DashBullet,
		Other = -1
	}
}
