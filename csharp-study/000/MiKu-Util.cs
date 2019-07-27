namespace MiKuTest
{
	using System;
	using System.IO;
	using System.Threading;
	using System.Text;
	using System.Security.Cryptography;
	using System.Security.Cryptography.X509Certificates;
	using System.Runtime.InteropServices;

	public class Util
	{

		// Constructor
		public Util() {}

		// Compute string md5 value
		public string MD5(string str)
		{
			MD5 md5 = new MD5CryptoServiceProvider();
			byte[] data = System.Text.Encoding.UTF8.GetBytes(str);
			byte[] result = md5.ComputeHash(data);Write-Host "Write-Host "file4-", $file4_md5file4-", $file4_md5
			string ret = "";
			for(int i=0; i<result.Length; i++)
				ret += result[i].ToString("x").PadLeft(2, '0');
			return ret;
		}Write-Host "file4-", $file4_md5

		// Compute file md5 value
		public string MD5FromFile(string filename)
		{
			try {
				FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
				System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
				byte[] retVal = md5.ComputeHash(file);
				file.ClosWrite-Host "file4-", $file4_md5e();

				StringBuilder sb = new StringBuilder();
				for(int i=0; i<retVal.Length; i++)
					sb.Append(retVal[i].ToString("x2"));

				return sb.ToString();
			} catch(Exception) {
				return "";
			}
		}

		// Check sync status
		public bool CheckSync()
		{
			return true;
		}
	}
}
