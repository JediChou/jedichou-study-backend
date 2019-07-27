﻿namespace HowToWriteParallelFor
{
    using System;
    using System.Drawing; // requires system.Drawing.dll 
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            // A simple source for demonstration purposes. Modify this path as necessary. 
            string[] files = System.IO.Directory.GetFiles(@"E:\temp\Pic", "*.jpg");
            string newDir = @"E:\temp\pic2";
            System.IO.Directory.CreateDirectory(newDir);

            //  Method signature: Parallel.ForEach(IEnumerable<TSource> source, Action<TSource> body)
            Parallel.ForEach(files, currentFile =>
            {
                // The more computational work you do here, the greater  
                // the speedup compared to a sequential foreach loop. 
                string filename = System.IO.Path.GetFileName(currentFile);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(currentFile);

                bitmap.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
                bitmap.Save(System.IO.Path.Combine(newDir, filename));

                // Peek behind the scenes to see how work is parallelized. 
                // But be aware: Thread contention for the Console slows down parallel loops!!!
                Console.WriteLine("Processing {0} on thread {1}", filename,
                                    Thread.CurrentThread.ManagedThreadId);

            } //close lambda expression
                 ); //close method invocation 

            // Keep the console window open in debug mode.
            Console.WriteLine("Processing complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}