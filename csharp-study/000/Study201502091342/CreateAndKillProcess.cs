using System.Diagnostics;
using System.Threading;

namespace CSLab.Study201502091342
{
    /// <summary>
    /// How to create and kill a process
    /// Reference by:
    ///   C# and .Net framework 2.0 platform, zh-cn
    ///   From chapter 5.2.3
    /// </summary>
    class CreateAndKillProcess
    {
        public static void Run()
        {
            var process = Process.Start("notepad.exe", "hello.txt");
            Thread.Sleep(1000);
            Debug.Assert(process != null, "process != null");
            process.Kill();
        }
    }
}
