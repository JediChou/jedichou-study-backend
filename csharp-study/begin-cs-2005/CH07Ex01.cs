using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace CH07Ex01
{
    /// <summary>
    /// Summary description for class1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray={4,7,4,2,3,7,8,3,9,1,9};
            int[] maxValIndices;
            int maxVal = Maxima(testArray, out maxValIndices);

            Console.WriteLine("Maximum value {0} found at element indices: maxVal");
            foreach(int index in maxValIndices)
            {
                    Console.WriteLine(index);
            }
            
            Console.ReadKey();
        }

        static int Maxima(int[] integers,out int[] indices)
        {
            Debug.WriteLine("Maximum value search started.");
            indices = new int[1];
            int maxVal = integers[0];
            indices[0] = 0;
            int count = 1;
            Debug.WriteLine("Maximum value initialized to"+maxVal+",at element index 0.");

            for (int i = 0; i < integers.Length; i++)
             {
                 Debug.WriteLine("Now looking at element at index"+i+".");
                 if (integers[i] > maxVal)
                 {
                     maxVal = integers[i];
                     count = 1;
                     indices=new int[1];
                     indices[0] = i;
                     Debug.WriteLine("New maximum found.New value is"+maxVal+",at element index"+i+".");
                 }
                     else
                     {
                         if(integers[i]==maxVal)
                         {
                             count++;
                             int[] oldIndices=indices;
                             indices=new int[count];
                             oldIndices.CopyTo(indices,0);
                             indices[count-1]=i;
                             Debug.WriteLine("Duplicate maximum found at element index"+i+".");
                         }

                     }
                 }
            
               Trace.WriteLine("Maximum value"+maxVal+"found,with"+count+"occurrences.");
                Debug.WriteLine("Maximum value search completed.");
                return maxVal;
             }
        }
    }

