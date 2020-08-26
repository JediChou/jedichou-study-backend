// Ref: https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/serialize-object-xml
// Desc: C#的对象的XML序列化

using System;
using System.IO;
using System.Xml;

namespace XmlSerializeDemo01
{
	public class clsPerson
	{
		public string FirstName;
		public string MI;
		public string LastName;
	}

	public class SerializeDemo01
	{
		public static void Main(string[] args)
		{
			var p = new clsPerson();
			p.FirstName = "Jeff";
			p.MI = "A";
			p.LastName = "Price";
			var x = new System.Xml.Serialization.XmlSerializer(p.GetType());
			x.Serialize(Console.Out, p);
			Console.WriteLine();
		}
	}
}
