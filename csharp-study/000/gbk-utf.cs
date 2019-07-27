using System;
using System.Text;

public class TransChar
{
	static void Main()
	{
		var mystr = "\u90b1\u66c9\u840d";
		
		string cd = mystr;
        string[] b5 = cd.Split(' ');
        byte[] bs = new byte[2];
        bs[0] = (byte)Convert.ToByte(b5[0], 16);
        bs[1] = (byte)Convert.ToByte(b5[1], 16);
         
		var o = Encoding.GetEncoding("Unicode").GetString(bs);

		Console.WriteLine(o);
	}
}
