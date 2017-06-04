using System;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System.Windows.Automation
{
	[Serializable]
	public class ElementNotAvailableException : SystemException
	{
		public ElementNotAvailableException() : base(SR.Get("ElementNotAvailable"))
		{
			base.HResult = -2147220991;
		}

		public ElementNotAvailableException(string message) : base(message)
		{
			base.HResult = -2147220991;
		}

		public ElementNotAvailableException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147220991;
		}

		public ElementNotAvailableException(Exception innerException) : base(SR.Get("ElementNotAvailable"), innerException)
		{
			base.HResult = -2147220991;
		}

		protected ElementNotAvailableException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			base.HResult = -2147220991;
		}

		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}
	}
}
