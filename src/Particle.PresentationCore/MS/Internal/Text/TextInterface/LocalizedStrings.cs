using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
//using MS.Internal.Text.TextInterface.Native;

namespace MS.Internal.Text.TextInterface
{
	internal sealed class LocalizedStrings : IDictionary<CultureInfo, string>
	{
		[SecuritySafeCritical]
		internal LocalizedStrings()
		{
		}

//		[SecurityCritical]
//		internal unsafe LocalizedStrings(IDWriteLocalizedStrings* localizedStrings)
//		{
//		}

		internal uint StringsCount { [SecuritySafeCritical] get; }

		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		[return: MarshalAs(UnmanagedType.U1)]
		internal bool FindLocaleName(string localeName, out uint index)
		{
		    index = 0;

            return false;
		}

		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		internal string GetLocaleName(uint index)
		{
		    return "";
        }

		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		internal string GetString(uint index)
		{
		    return "";
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
		    return false;
        }

		public ICollection<CultureInfo> Keys { get; }

		[return: MarshalAs(UnmanagedType.U1)]
		public bool Remove(KeyValuePair<CultureInfo, string> item)
		{
		    return false;
        }

		[return: MarshalAs(UnmanagedType.U1)]
		public bool Remove(CultureInfo key)
		{
		    return false;
        }

		[SecuritySafeCritical]
		[return: MarshalAs(UnmanagedType.U1)]
		public bool TryGetValue(CultureInfo key, out string value)
		{
		    value = "";

            return false;
        }

	    public  ICollection<string> Values
	    {
	        get { return null; }
	    }

	    public  string this[CultureInfo key]
		{
			get { return ""; }
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
		    return false;
		}

		public void CopyTo(KeyValuePair<CultureInfo, string>[] arrayObj, int arrayIndex)
		{
		}

		public  int Count
		{
			get { return 0; }
		}

		public  bool IsReadOnly
		{
			[return: MarshalAs(UnmanagedType.U1)]
			get { return false; }
		}

	    public IEnumerator<KeyValuePair<CultureInfo, string>> GetEnumerator()
	    {
	        throw new NotImplementedException();
	    }

	    IEnumerator IEnumerable.GetEnumerator()
	    {
	        return GetEnumerator();
	    }
	}
}
