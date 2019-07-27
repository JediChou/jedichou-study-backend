using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace pg_csc
{
    class Program
    {
        public static Dictionary<string, string> Paras; 

        static void Main(string[] args)
        {
            //if (args.Length == 0)
            //{
            //    CscHelp();
            //}
            //else
            //{
            //    Paras = new Dictionary<string, string>();
            //}

            ListAllDotNetFramwork();
        }

        static void CscHelp()
        {
            Console.WriteLine("pg-csc complie and run csharp snippet code.");
            Console.WriteLine("  Author: Jedi Chou");
            Console.WriteLine("  Mail: skyzhx@163.com");
            Console.WriteLine();
            Console.WriteLine("pg-csc [option] [csharp snippet file, *.cs]");
            Console.WriteLine("General option:");
            Console.WriteLine("  -c file.cs\tOnly Complie");
            Console.WriteLine("  -r file.cs\tComplie and run");
            Console.WriteLine("  -list\t\tList all .NET framework");
            Console.WriteLine("  -help\t\tPrint help information");
        }

        /// <summary>
        /// List all dot net framework at local computer
        /// </summary>
        static void ListAllDotNetFramwork()
        {

            // https://docs.microsoft.com/en-us/dotnet/framework/migration-guide/how-to-determine-which-versions-are-installed

             // Opens the registry key for the .NET Framework entry.
            using (var ndpKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "").OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
            {
                foreach (var versionKeyName in ndpKey.GetSubKeyNames())
                {
                    if (versionKeyName.StartsWith("v"))
                    {
                        RegistryKey versionKey = ndpKey.OpenSubKey(versionKeyName);
                        string name = (string) versionKey.GetValue("Version", "");
                        string sp = versionKey.GetValue("SP", "").ToString();
                        string install = versionKey.GetValue("Install", "").ToString();
                        
                        if (install == "") 
                        {
                            //no install info, must be later.
                            Console.WriteLine(versionKeyName + "  " + name);
                        }
                        else
                        {
                            if (sp != "" && install == "1")
                            {
                                Console.WriteLine(versionKeyName + "  " + name + "  SP" + sp);
                            }
                        }

                        if (name != "")
                        {
                            continue;
                        }

                        foreach (string subKeyName in versionKey.GetSubKeyNames())
                        {
                            RegistryKey subKey = versionKey.OpenSubKey(subKeyName);
                            name = (string) subKey.GetValue("Version", "");
                            if (name != "")
                                sp = subKey.GetValue("SP", "").ToString();
                            install = subKey.GetValue("Install", "").ToString();
                            if (install == "") //no install info, must be later.
                                Console.WriteLine(versionKeyName + "  " + name);
                            else
                            {
                                if (sp != "" && install == "1")
                                {
                                    Console.WriteLine("  " + subKeyName + "  " + name + "  SP" + sp);
                                }
                                else if (install == "1")
                                {
                                    Console.WriteLine("  " + subKeyName + "  " + name);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
