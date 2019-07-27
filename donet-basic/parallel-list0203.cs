using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ParallelListing0203
{
	public class Program
	{
		private const int NUM_AES_KEYS = 800000;
		private const int NUM_MD5_HASHES = 100000;

		private static string ConverToHexString(Byte[] byteArray)
		{
			var sb = new StringBuilder(byteArray.Length);
			for (int i=0; i<byteArray.Length; i++)
			{
				sb.Append(byteArray[i].ToString("X2"));
			}
			return sb.ToString();
		}

		private static void GenerateAESKeys()
		{
			var sw = Stopwatch.StartNew();
			var aesM = new AesManaged();
			for (int i=1; i <= NUM_AES_KEYS; i++)
			{
				aesM.GenerateKey();
				byte[] result = aesM.Key;
				string hexString = ConverToHexString(result);
			}
			Console.WriteLine("AES: " + sw.Elapsed.ToString());
		}
		
		private static void GenerateMD5Hashes()
		{
			var sw = Stopwatch.StartNew();
			var md5M = MD5.Create();
			for (int i=1; i <= NUM_MD5_HASHES; i++)
			{
				byte[] data =
					Encoding.Unicode.GetBytes(
					Environment.UserName + i.ToString());
				byte[] result = md5M.ComputeHash(data);
				string hexString = ConverToHexString(result);
			}
			Console.WriteLine("MD5: " + sw.Elapsed.ToString());
		}

		static void Main()
		{
			var sw = Stopwatch.StartNew();
			
			GenerateAESKeys();
			GenerateMD5Hashes();
			Console.WriteLine(sw.Elapsed.ToString());
			Console.ReadLine();
		}
	}
}
