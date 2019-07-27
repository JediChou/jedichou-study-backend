/////////////////////////////////////////////////////////////////////
/// File name   : P3C_List0203.cs
/// File create : 2013-9-30 14:07 AM
/// File modify : 2013-9-30 16:36 PM
/////////////////////////////////////////////////////////////////////
/// Description: Listing 2-3s
/// Simple serial AES keys and MD5 hash generators
/////////////////////////////////////////////////////////////////////
/// From	- Professional Parallel Programming with C#, Page 40
/// Target	- study parallel program skill of rewrite code.
/// Auther	- Gaston C. Hillar
/// Student	- Jedi Chou
/////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Listing0203 {
	class Program {
		private const int NUM_AES_KEYS = 800000;
		private const int NUM_MD5_HASHES = 100000;

		/// Method: ConvertToHexString
		private static string ConvertToHexString(Byte[] byteArray) {
			// Convert the byte array to hexadecimal string
			var sb = new StringBuilder(byteArray.Length);
			for(int i = 0; i < byteArray.Length; i++) {
				sb.Append(byteArray[i].ToString("X2"));
			}
			return sb.ToString();
		}

		/// Method: GenerateAESKeys
		private static void GenerateAESKeys() {
			var sw = Stopwatch.StartNew();
			var aesM = new AesManaged();
			for(int i = 1; i <= NUM_AES_KEYS; i++) {
				aesM.GenerateKey();
				byte[] result = aesM.Key;
				String hexString = ConvertToHexString(result);
			}
			Debug.WriteLine("AES: " + sw.Elapsed.ToString());
			Console.WriteLine("AES: " + sw.Elapsed.ToString());
		}
		
		/// Method: GenerateMD5Hashes
		private static void GenerateMD5Hashes() {
			var sw = Stopwatch.StartNew();
			var md5M = MD5.Create();
			for(int i = 1; i <= NUM_MD5_HASHES; i++) {
				byte[] data = 
					Encoding.Unicode.GetBytes(
					Environment.UserName + i.ToString());
				byte[] result = md5M.ComputeHash(data);
				string hexString = ConvertToHexString(result);
				// Console.WriteLine("MD5 HASH: {0}", hexString);
			}
			Debug.WriteLine("MD5: " + sw.Elapsed.ToString());
			Console.WriteLine("MD5: " + sw.Elapsed.ToString());
		}

		static void Main(string[] args) {
			var sw = Stopwatch.StartNew();

			GenerateAESKeys();
			GenerateMD5Hashes();
			Debug.WriteLine(sw.Elapsed.ToString());
			// Display the results and wait for the user to press a key
		}

	}
}
