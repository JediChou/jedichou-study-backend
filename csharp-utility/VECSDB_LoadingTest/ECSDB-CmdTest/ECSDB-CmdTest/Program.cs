using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECSDB_CmdTest
{
    /// <summary>
    /// ECS-DB测试主程序
    /// </summary>
    class Program
    {
        static void Main()
        {
            var task1 = new Task(() => { TaskForTest("H", "5", "月份5"); });
            var task2 = new Task(() => { TaskForTest("H", "6", "月份6"); });
            var task3 = new Task(() => { TaskForTest("H", "7", "月份7"); });
            var task4 = new Task(() => { TaskForTest("H", "8", "月份8"); });
            var task5 = new Task(() => { TaskForTest("H", "9", "月份9"); });
            var task6 = new Task(() => { TaskForTest("H", "A", "月份10"); });
            var task7 = new Task(() => { TaskForTest("H", "B", "月份11"); });
            var task8 = new Task(() => { TaskForTest("H", "C", "月份11"); });

            var task21 = new Task(() => { TaskForTest("I", "5", "月份5"); });
            var task22 = new Task(() => { TaskForTest("I", "6", "月份6"); });
            var task23 = new Task(() => { TaskForTest("I", "7", "月份7"); });
            var task24 = new Task(() => { TaskForTest("I", "8", "月份8"); });
            var task25 = new Task(() => { TaskForTest("I", "9", "月份9"); });
            var task26 = new Task(() => { TaskForTest("I", "A", "月份10"); });
            var task27 = new Task(() => { TaskForTest("I", "B", "月份11"); });
            var task28 = new Task(() => { TaskForTest("I", "C", "月份11"); });

            var task = new Task(() => { IdleQuery(); });
            var bigquery1 = new Task(() => { BigQuery(); });
            var bigquery2 = new Task(() => { BigQuery(); });
            var bigquery3 = new Task(() => { BigQuery(); });

            task1.Start(); task2.Start(); task3.Start(); task4.Start();
            task5.Start(); task6.Start(); task7.Start(); task8.Start();

            task21.Start(); task22.Start(); task23.Start(); task24.Start();
            task25.Start(); task26.Start(); task27.Start(); task28.Start();

            task.Start();
            bigquery1.Start(); bigquery2.Start(); bigquery3.Start();

            Task.WaitAny(
                task1, task2, task3, task4, task5, task6, task7, task8,
                task21, task22, task23, task24, task25, task26, task27, task28,
                task, bigquery1, bigquery2, bigquery3
            );
            Console.WriteLine("Main method complete. Press any key.");
            Console.WriteLine("Main method complete. Press any key.");
        }

        private static void printMessage()
        {
            Console.WriteLine("printMessage method.");
        }

        private static void TaskForTest(string prefix, string month, string taskname)
        {
            List<int> OrderID = new List<int>();
            // int testCounter = 0;

            for (int i = 0; i <= ECStaicVar.MAX; i++)
                OrderID.Add(i);

            // Define varialbes
            // var watch = System.Diagnostics.Stopwatch.StartNew();

            // Process 2: Generate test data
            Parallel.For(0, OrderID.Count, id => { ECS.GenerateData(OrderID[id], prefix, month); });
            // testCounter++;

            // Stop watch and output 
            // watch.Stop();
            // Console.WriteLine("{2}: 第{0}轮数据生成时间为[ {1} ] 毫秒", testCounter, watch.ElapsedMilliseconds, taskname);

            // Delete Ouput
            ECS.DeleteData();
            // Console.WriteLine("{1}: 第{0}数据已删除", testCounter, taskname);
        }

        /// <summary>
        /// H5号码段的测试
        /// </summary>
        private static void TestH5()
        {
            
            List<int> OrderID = new List<int>();
            int testCounter = 0;

            for (int i = 0; i <= ECStaicVar.MAX; i++)
                OrderID.Add(i);

            while (true)
            {
                // Define varialbes
                var watch = System.Diagnostics.Stopwatch.StartNew();

                // Process 2: Generate test data
                Parallel.For(0, OrderID.Count, id => { ECS.GenerateData(OrderID[id]); });
                testCounter++;

                // Stop watch and output 
                watch.Stop();
                Console.WriteLine("第{0}轮数据生成时间为[ {1} ] 毫秒", testCounter, watch.ElapsedMilliseconds);

                // Delete Ouput
                ECS.DeleteData();
                Console.WriteLine("第{0}数据已删除", testCounter);
            }
        }

        private static void IdleQuery()
        {
            for (int i = 0; i < 999999; i++)
                ECS.ExecuteMoreCPUQuery();
            // Console.WriteLine("IdleQuery查询完毕");
        }

        private static void BigQuery()
        {
            for (int i = 0; i < 99999; i++)
                ECS.ExecuteBigQuery();
        }
    }
}
