using System;
using System.Threading;

namespace cslab.Study201502091425
{
    class CreateThreadAndRunIt
    {
        static void Function1() { Console.WriteLine("Function1"); }
        void Function2() { Console.WriteLine("Function2"); }
        static void Function3(object obj) { Console.WriteLine("Function3 obj = {0}", obj); }

        public static void Run()
        {
            // Explicitly specify the delegate class 'ThreadStart'
            var t1 = new Thread(Function1);

            // Here, we use the C#2 facility to infer the delegate class
            // 'ThreadStart' from the definition of the 'Thread' class
            // constructor without argument.
            var program = new CreateThreadAndRunIt();
            var t2 = new Thread(program.Function2);
            
            // Here, the C#2 compiler infer the delegate class
            // 'ParametrizedThreadStart' since the 'Function3()' method
            // accept an 'objct' parameter
            var t3 = new Thread(Function3);

            t1.Start(); t2.Start(); t3.Start("Hello");
            t1.Join(); t2.Join(); t3.Join();
        }
    }
}
