using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

class DefinedClass
{
	public string Name { get; set; }
	public int Age { get; set; }
}

class GetVariableMemorySize
{
	public static void Main()
	{
		var instance = new DefinedClass();
		var size = GetObjectSize(instance);
		Console.WriteLine(size);
	}

	/// <summary>
	/// Get Object memory size
	/// </summary>
	private static int GetObjectSize(object TestObject)
	{
		// Notice: The object should be serialize.
    	BinaryFormatter bf = new BinaryFormatter();
    	MemoryStream ms = new MemoryStream();
    	byte[] Array;
    	bf.Serialize(ms, TestObject);
    	Array = ms.ToArray();
    	return Array.Length;
	}
}
