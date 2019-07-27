using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPlugin;

namespace Plug
{
    public class Plugin : IPlugin.IPlugin
    {
        public void Run(string msg)
        {
            Console.WriteLine(@"Hello dynamic call, {0}", msg);
        }
    }
}
