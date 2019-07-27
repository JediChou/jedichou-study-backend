using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cslab.Study201502101401
{
    /// <summary>
    /// I'm forget how to use static field.
    /// So, let's make a code snippet to 
    /// </summary>
    class StaticFieldsDemo
    {
        private static int _counter = 0;

        public int GetCounter()
        {
            return _counter;
        }

        public void SetCounter(int a)
        {
            _counter = a;
        }

        public static void Run()
        {
            var a = new StaticFieldsDemo();
            var b = new StaticFieldsDemo();
          
            a.SetCounter(32);
            Console.WriteLine(b.GetCounter() == a.GetCounter());
        }
    }
}
