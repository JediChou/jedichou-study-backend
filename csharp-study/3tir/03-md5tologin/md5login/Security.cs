using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace md5login
{
    /// <summary>
    /// A security lib
    /// </summary>
    public static class Security
    {
        /// <summary>
        /// Get md5 value for string
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>md5 value</returns>
        public static string GetStringMD5(string str)
        {
            using (var md5 = MD5.Create())
            {
                var strBuf = Encoding.UTF8.GetBytes(str);
                var strMD5 = md5.ComputeHash(strBuf);
                var strResult = new StringBuilder();
                for (int i = 0; i < strMD5.Length; i++)
                    strResult.Append(strMD5[i].ToString("x2"));

                return strResult.ToString();
            }
        }

        /// <summary>
        /// Get md5 value for file
        /// </summary>
        /// <param name="path">file path</param>
        /// <returns>md5 value</returns>
        public static string GetFileMD5(string path)
        {
            using (var md5 = MD5.Create())
            using (var fsr = File.OpenRead(path))
            {
                var fileMD5 = md5.ComputeHash(fsr);
                var strResult = new StringBuilder();
                for (int i = 0; i < fileMD5.Length; i++)
                    strResult.Append(fileMD5[i].ToString("x2"));

                return strResult.ToString();
            }
        }
    }
}
