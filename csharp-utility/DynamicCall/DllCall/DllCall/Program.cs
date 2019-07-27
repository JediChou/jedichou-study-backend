using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPlugin;

namespace DllCall
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = Environment.CurrentDirectory + "\\Plug.dll";
            var ass = System.Reflection.Assembly.LoadFrom(filePath);

            foreach (var t in ass.GetTypes())
            {
                if (t.GetInterface("IPlugin") != null)
                {
                    var plugin = (IPlugin.IPlugin)Activator.CreateInstance(t);
                    plugin.Run("HI");
                }
            }
        }
    }
}
