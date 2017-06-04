using System;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System.Windows.Automation
{
	[Serializable]
	public class ElementNotEnabledException : InvalidOperationException
	{
		public ElementNotEnabledException() : base(SR.Get("ElementNotEnabled"))
		{
			base.HResult = -2147220992;
		}

		public ElementNotEnabledException(string message) : base(message)
		{
			base.HResult = -2147220992;
		}

		public ElementNotEnabledException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147220992;
		}

		protected ElementNotEnabledException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			base.HResult = -2147220992;
		}

		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}
	}
}
