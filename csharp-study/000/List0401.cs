using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace List0401
{
    public class Program
    {
        const int NUM_AES_KEYS = 5;
        private static List<string> _keysList;

        private static void ParallelPartitionGenerateAESKyes()
        {
            var sw = Stopwatch.StartNew();
            Parallel.ForEach(Partitioner.Create(1, NUM_AES_KEYS + 1), range => 
            {
                var aesM = new AesManged();
                Debug.WriteLine(
                    "AES Range ({0}, {1}. Time: {2})",
                    range.Item1, range.Item2,
                    DataTime.Now.TimeOfDay
                );

                for (int i = range.Item1; i < range.Item2; i++)
                {
                    aseM.GenerateKey();
                    byte[] result = aesM.Key;
                    string hexString = ConvertToHexString(result);

                    lock (_keysList)
                    {
                        // Critical code section
                        // It is safe to add elements to the List
                        _keysList.Add(hexString);
                    }
                }

            });
            Debug.WriteLine("AES: " + sw.Elapsed.ToString());
        }

        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();
            
            _keysList = new List<string>(NUM_AES_KEYS);

            Console.WriteLine("Number of keys in the list: {0}", _keysList.Count);
            Debug.WriteLine(sw.Elapsed.ToString());

            Console.WriteLine("Finished!");
            Console.ReadLine();
        }
    }
}
