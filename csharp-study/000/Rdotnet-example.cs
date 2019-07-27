using RDotNet;
using System;
using System.IO;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        public static void Main()
        {
            SetupPath();
            using (REngine engine = REngine.CreateInstance("RDotNet"))
            {
                engine.Initialize();
                CharacterVector charVec = engine.CreateCharacterVector(new[] {"Hello, R world!, .NET speaking" });
                engine.SetSymbol("greetings", charVec);
                engine.Evaluate("str(greetings)"); // print out in the console
                string[] a = engine.Evaluate("'Hi there .NET, from the R engine'").AsCharacter().ToArray();
                Console.WriteLine("R answered: '{0}'", a[0]);

                engine.Evaluate("x <- c(1,2,3,4,9)");
                var numeric2 = engine.GetSymbol("x").AsInteger();
                foreach (var num in numeric2)
                    Console.WriteLine(num);
            }
        }

        public static void SetupPath(string Rversion = "R-3.2.3")
        {
            var oldPath = Environment.GetEnvironmentVariable("PATH");
            var rPath = Environment.Is64BitProcess ? 
                string.Format(@"C:\R-3.2.3\bin\x64") : 
                string.Format(@"C:\R-3.2.3\bin\i386");

            if (!Directory.Exists(rPath))
                throw new DirectoryNotFoundException(
                  string.Format(" R.dll not found in : {0}", rPath));

            var newPath = string.Format("{0}{1}{2}", rPath, Path.PathSeparator, oldPath);
            Environment.SetEnvironmentVariable("PATH", newPath);
        }
    }
}