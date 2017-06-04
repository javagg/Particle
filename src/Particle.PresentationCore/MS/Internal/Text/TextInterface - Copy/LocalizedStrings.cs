using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface
{
	internal sealed class LocalizedStrings : IDictionary<CultureInfo, string>
	{
		[SecuritySafeCritical]
		internal LocalizedStrings()
		{
		}

		[SecurityCritical]
		internal unsafe LocalizedStrings(IDWriteLocalizedStrings* localizedStrings)
		{
		}

		internal uint StringsCount
		{
			[SecuritySafeCritical]
			get
			{
			}
		}

		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		[return: MarshalAs(UnmanagedType.U1)]
		internal bool FindLocaleName(string localeName, out uint index)
		{
		}

		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		internal string GetLocaleName(uint index)
		{
		}

		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		internal string GetString(uint index)
		{
		}

		public void Add(KeyValuePair<CultureInfo, string> item)
		{
		}

		public void Add(CultureInfo key, string value)
		{
		}

		[return: MarshalAs(UnmanagedType.U1)]
		public bool ContainsKey(CultureInfo key)
		{
		}

		public virtual ICollection<CultureInfo> Keys
		{
			get
			{
			}
		}

		[return: MarshalAs(UnmanagedType.U1)]
		public bool Remove(KeyValuePair<CultureInfo, string> item)
		{
		}

		[return: MarshalAs(UnmanagedType.U1)]
		public bool Remove(CultureInfo key)
		{
		}

		[SecuritySafeCritical]
		[return: MarshalAs(UnmanagedType.U1)]
		public bool TryGetValue(CultureInfo key, out string value)
		{
		}

		public virtual ICollection<string> Values
		{
			get
			{
			}
		}

		public virtual string this[CultureInfo key]
		{
			get
			{
			}
			set
			{
			}
		}

		public void Clear()
		{
		}

		[return: MarshalAs(UnmanagedType.U1)]
		public bool Contains(KeyValuePair<CultureInfo, string> item)
		{
		}

		public void CopyTo(KeyValuePair<CultureInfo, string>[] arrayObj, int arrayIndex)
		{
		}

		public virtual int Count
		{
			get
			{
			}
		}

		public virtual bool IsReadOnly
		{
			[return: MarshalAs(UnmanagedType.U1)]
			get
			{
			}
		}

		public IEnumerator<KeyValuePair<CultureInfo, string>> GetEnumerator()
		{
		}

		public IEnumerator GetEnumerator2()
		{
		}

		public class LocalizedStringsEnumerator : IEnumerator<KeyValuePair<CultureInfo, string>>
		{
			public LocalizedStringsEnumerator(LocalizedStrings localizedStrings)
			{
			}

			[return: MarshalAs(UnmanagedType.U1)]
			public virtual bool MoveNext()
			{
			}

			public virtual KeyValuePair<CultureInfo, string> Current
			{
				[SecuritySafeCritical]
				get
				{
				}
			}

			public object Current2
			{
				get
				{
				}
			}

			public virtual void Reset()
			{
			}

			protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
			{
			}

			public sealed override void Dispose()
			{
			}

			public LocalizedStrings _localizedStrings;

			public long _currentIndex;
		}
	}
}
