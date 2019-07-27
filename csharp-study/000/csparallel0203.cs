using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CSParallel0203
{
	class Program
	{
		private const int NUM_AES_KEYS = 800000;
		private const int NUM_MD5_HASHES = 100000;

		private static string ConvertToHexString(Byte[] byteArray)
		{
			// Conver the byte array to hexadecimal string
			var sb = new StringBuilder(byteArray.Length);
			for (int i = 0; i < byteArray.Length; i++)
			{
				sb.Append(byteArray[i].ToString("X2"));
			}
			return sb.ToString();
		}

		

		static void Main(string[] args)
		{
			Console.WriteLine("C# Parallel Programming");
			var str = "This is a demo for csparallel0203";
			var b = Encoding.Default.GetBytes(str);
			var result = ConvertToHexString(b);
			Console.WriteLine(result);
		}
	}
}
