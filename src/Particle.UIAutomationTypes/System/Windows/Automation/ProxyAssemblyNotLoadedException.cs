using System;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System.Windows.Automation
{
	[Serializable]
	public class ProxyAssemblyNotLoadedException : Exception
	{
		public ProxyAssemblyNotLoadedException()
		{
		}

		public ProxyAssemblyNotLoadedException(string message) : base(message)
		{
		}

		public ProxyAssemblyNotLoadedException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected ProxyAssemblyNotLoadedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}
	}
}
