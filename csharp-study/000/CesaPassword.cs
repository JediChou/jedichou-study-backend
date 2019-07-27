using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //先截断后获得密文
            string[] myobj = { "1234", "abcd", "Warden", "Jedi"};
            foreach (string a in myobj)
                Console.WriteLine(
                    "原始信息:" + a + "  " +
                    "加密信息:" + getCaesar(delLastChr(a))
                );

            Console.ReadKey();
        }

        /// <summary>
        /// 字符串有Substring方法,可实现截断字符串
        /// 例1: ("abcd").Substring(0, 2), 结果是"abc"
        /// 例2: a.Substring(0, a.length), 结果还是a
        /// 例3: a.Substring(0, a.length - 1), 当然是删除最后一个字符了
        /// </summary>
        public static string delLastChr(string str)
        {
            return str.Substring(0, (str.Length - 1));
        }

        /// <summary>
        /// Reference: http://zh.wikipedia.org/wiki/凯撒密码
        /// Reference: http://en.wikipedia.org/wiki/Caesar_cipher
        /// Description: 获得密文, 即加密.
        /// </summary>
        public static string getCaesar(string plain)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char chrt in plain)
                sb.Append((char)(getASC(chrt) + 3));

            return sb.ToString();
        }

        /// <summary>
        /// 对于字符类型来说,可以用(int)直接获得ASCII编码.
        /// 1. (int)'A' 获得A的ASCII值
        /// 2. (char)97 获得97的字符
        /// </summary>
        public static int getASC(char chr)
        {
            return (int)chr;
        }
    }
}
