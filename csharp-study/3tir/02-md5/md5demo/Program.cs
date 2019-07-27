using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace md5demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // computer string md5 value
            //Console.WriteLine("Pls input some text");
            //var input = Console.ReadLine();
            //var md5 = GetMD5(input);
            Console.WriteLine(GetMD5("Jedi"));
            Console.WriteLine(GetMD5("Becky"));

            // computer file md5 value
            //var md5 = GetFileMD5(@"d:\1.txt");
            //Console.WriteLine(md5);
        }

        /// <summary>
        /// Get md5 value
        /// </summary>
        /// <param name="input">input</param>
        /// <returns>md5 result string</returns>
        private static string GetMD5(string input)
        {
            using (var md5 = MD5.Create())
            {
                var inputBuffer = Encoding.UTF8.GetBytes(input);
                var inputBufferMd5 = md5.ComputeHash(inputBuffer);
                var sbMD5 = new StringBuilder();
                for (int i = 0; i < inputBufferMd5.Length; i++)
                    sbMD5.Append(inputBufferMd5[i].ToString("x2"));

                return sbMD5.ToString();
            }
        }

        /// <summary>
        /// Get file md5
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private static string GetFileMD5(string path)
        {
            using (var md5 = MD5.Create())
            using (var fsRead = File.OpenRead(path))
            {
                var fileMd5Buffer = md5.ComputeHash(fsRead);
                var sbMD5 = new StringBuilder();
                for (int i = 0; i < fileMd5Buffer.Length; i++)
                    sbMD5.Append(fileMd5Buffer[i].ToString("x2"));

                return sbMD5.ToString();
            }
        }
    }
}
