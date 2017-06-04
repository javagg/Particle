using System;
using System.Xml;

namespace MS.Internal.IO.Packaging
{
	internal static class PackageXmlStringTable
	{
		static PackageXmlStringTable()
		{
			object nameString = PackageXmlStringTable._nameTable.Add("http://www.w3.org/2001/XMLSchema-instance");
			PackageXmlStringTable._xmlstringtable[1] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.NotDefined, null);
			nameString = PackageXmlStringTable._nameTable.Add("xsi");
			PackageXmlStringTable._xmlstringtable[2] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.NotDefined, null);
			nameString = PackageXmlStringTable._nameTable.Add("xmlns");
			PackageXmlStringTable._xmlstringtable[3] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.NotDefined, null);
			nameString = PackageXmlStringTable._nameTable.Add("http://schemas.openxmlformats.org/package/2006/metadata/core-properties");
			PackageXmlStringTable._xmlstringtable[4] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.NotDefined, null);
			nameString = PackageXmlStringTable._nameTable.Add("http://purl.org/dc/elements/1.1/");
			PackageXmlStringTable._xmlstringtable[5] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.NotDefined, null);
			nameString = PackageXmlStringTable._nameTable.Add("http://purl.org/dc/terms/");
			PackageXmlStringTable._xmlstringtable[6] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.NotDefined, null);
			nameString = PackageXmlStringTable._nameTable.Add("dc");
			PackageXmlStringTable._xmlstringtable[7] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.NotDefined, null);
			nameString = PackageXmlStringTable._nameTable.Add("dcterms");
			PackageXmlStringTable._xmlstringtable[8] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.NotDefined, null);
			nameString = PackageXmlStringTable._nameTable.Add("coreProperties");
			PackageXmlStringTable._xmlstringtable[9] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.PackageCorePropertiesNamespace, "NotSpecified");
			nameString = PackageXmlStringTable._nameTable.Add("type");
			PackageXmlStringTable._xmlstringtable[10] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.NotDefined, "NotSpecified");
			nameString = PackageXmlStringTable._nameTable.Add("creator");
			PackageXmlStringTable._xmlstringtable[11] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.DublinCorePropertiesNamespace, "String");
			nameString = PackageXmlStringTable._nameTable.Add("identifier");
			PackageXmlStringTable._xmlstringtable[12] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.DublinCorePropertiesNamespace, "String");
			nameString = PackageXmlStringTable._nameTable.Add("title");
			PackageXmlStringTable._xmlstringtable[13] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.DublinCorePropertiesNamespace, "String");
			nameString = PackageXmlStringTable._nameTable.Add("subject");
			PackageXmlStringTable._xmlstringtable[14] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.DublinCorePropertiesNamespace, "String");
			nameString = PackageXmlStringTable._nameTable.Add("description");
			PackageXmlStringTable._xmlstringtable[15] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.DublinCorePropertiesNamespace, "String");
			nameString = PackageXmlStringTable._nameTable.Add("language");
			PackageXmlStringTable._xmlstringtable[16] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.DublinCorePropertiesNamespace, "String");
			nameString = PackageXmlStringTable._nameTable.Add("created");
			PackageXmlStringTable._xmlstringtable[17] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.DublinCoreTermsNamespace, "DateTime");
			nameString = PackageXmlStringTable._nameTable.Add("modified");
			PackageXmlStringTable._xmlstringtable[18] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.DublinCoreTermsNamespace, "DateTime");
			nameString = PackageXmlStringTable._nameTable.Add("contentType");
			PackageXmlStringTable._xmlstringtable[19] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.PackageCorePropertiesNamespace, "String");
			nameString = PackageXmlStringTable._nameTable.Add("keywords");
			PackageXmlStringTable._xmlstringtable[20] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.PackageCorePropertiesNamespace, "String");
			nameString = PackageXmlStringTable._nameTable.Add("category");
			PackageXmlStringTable._xmlstringtable[21] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.PackageCorePropertiesNamespace, "String");
			nameString = PackageXmlStringTable._nameTable.Add("version");
			PackageXmlStringTable._xmlstringtable[22] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.PackageCorePropertiesNamespace, "String");
			nameString = PackageXmlStringTable._nameTable.Add("lastModifiedBy");
			PackageXmlStringTable._xmlstringtable[23] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.PackageCorePropertiesNamespace, "String");
			nameString = PackageXmlStringTable._nameTable.Add("contentStatus");
			PackageXmlStringTable._xmlstringtable[24] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.PackageCorePropertiesNamespace, "String");
			nameString = PackageXmlStringTable._nameTable.Add("revision");
			PackageXmlStringTable._xmlstringtable[25] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.PackageCorePropertiesNamespace, "String");
			nameString = PackageXmlStringTable._nameTable.Add("lastPrinted");
			PackageXmlStringTable._xmlstringtable[26] = new PackageXmlStringTable.XmlStringTableStruct(nameString, PackageXmlEnum.PackageCorePropertiesNamespace, "DateTime");
		}

		internal static PackageXmlEnum GetEnumOf(object xmlString)
		{
			for (int i = 1; i < PackageXmlStringTable._xmlstringtable.GetLength(0); i++)
			{
				if (PackageXmlStringTable._xmlstringtable[i].Name == xmlString)
				{
					return (PackageXmlEnum)i;
				}
			}
			return PackageXmlEnum.NotDefined;
		}

		internal static string GetXmlString(PackageXmlEnum id)
		{
			PackageXmlStringTable.CheckIdRange(id);
			return (string)PackageXmlStringTable._xmlstringtable[(int)id].Name;
		}

		internal static object GetXmlStringAsObject(PackageXmlEnum id)
		{
			PackageXmlStringTable.CheckIdRange(id);
			return PackageXmlStringTable._xmlstringtable[(int)id].Name;
		}

		internal static PackageXmlEnum GetXmlNamespace(PackageXmlEnum id)
		{
			PackageXmlStringTable.CheckIdRange(id);
			return PackageXmlStringTable._xmlstringtable[(int)id].Namespace;
		}

		internal static string GetValueType(PackageXmlEnum id)
		{
			PackageXmlStringTable.CheckIdRange(id);
			return PackageXmlStringTable._xmlstringtable[(int)id].ValueType;
		}

		internal static NameTable NameTable
		{
			get
			{
				return PackageXmlStringTable._nameTable;
			}
		}

		private static void CheckIdRange(PackageXmlEnum id)
		{
			if (id <= PackageXmlEnum.NotDefined || id >= (PackageXmlEnum)27)
			{
				throw new ArgumentOutOfRangeException("id");
			}
		}

		internal static NameTable CloneNameTable()
		{
			NameTable nameTable = new NameTable();
			for (int i = 1; i < 27; i++)
			{
				nameTable.Add((string)PackageXmlStringTable._xmlstringtable[i].Name);
			}
			return nameTable;
		}

		private static PackageXmlStringTable.XmlStringTableStruct[] _xmlstringtable = new PackageXmlStringTable.XmlStringTableStruct[27];

		private static NameTable _nameTable = new NameTable();

		private struct XmlStringTableStruct
		{
			internal XmlStringTableStruct(object nameString, PackageXmlEnum ns, string valueType)
			{
				this._nameString = nameString;
				this._namespace = ns;
				this._valueType = valueType;
			}

			internal object Name
			{
				get
				{
					return (string)this._nameString;
				}
			}

			internal PackageXmlEnum Namespace
			{
				get
				{
					return this._namespace;
				}
			}

			internal string ValueType
			{
				get
				{
					return this._valueType;
				}
			}

			private object _nameString;

			private PackageXmlEnum _namespace;

			private string _valueType;
		}
	}
}
