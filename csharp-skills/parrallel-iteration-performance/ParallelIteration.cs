using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelIteration
{
    class MixObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        private const int Top = 20000000;

        static void Main()
        {
            // Define variables
            var stopWatch = new Stopwatch();
            var listMixObj = new List<MixObject>();
            
            // Prepare list
            for (var i = 0; i < Top; i++)
                listMixObj.Add(new MixObject{ Name = "Jedi", Age = 42});

            // check run time
            stopWatch.Start();

            // Normal iterate
            foreach (var elt in listMixObj)
                elt.Age = 43;

            //Parallel.ForEach(listMixObj, elt =>
            //{
            //    elt.Age += 20;
            //});

            stopWatch.Stop();

            // Output
            var ts = stopWatch.Elapsed;
            var elapsedTime = String.Format(
                "{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10
            );
            Console.WriteLine(elapsedTime);
        }
    }
}
