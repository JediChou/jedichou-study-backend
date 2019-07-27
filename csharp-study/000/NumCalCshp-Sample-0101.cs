/*
 * File name : NumCalCshp-Sample-0101.cs
 * Description : 精度不足導致違反代數結合律
 */
 
namespace CSharpAlgorithm.Sample
{
    using System;
    
    class Sample0101
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("精度不足導致違反加法結合律-Example\n");
            float a = 1.0f;
            float b = 7.842357E-10f;
            float c = 3.140808E-09f;
            
            Console.WriteLine(" a = " + a);
            Console.WriteLine(" b = " + b);
            Console.WriteLine(" c = " + c);
            Console.WriteLine(" (a+b)+c = " + (a+b)+c );	// Notice output
            Console.WriteLine(" a+(b+c) = " + a+(b+c) );	// Notice output
            
            if ( (a+b)+c == a+(b+c) )
                Console.WriteLine(" ===> 滿足結合律");
            else
                Console.WriteLine(" ===> 不滿足結合律");
			
			Console.WriteLine("\nPress any key to exit.");
			Console.ReadKey();
        }
    }
}

