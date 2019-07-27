using System;
using System.Threading;
using System.Threading.Tasks;

namespace cslab.Study201502101401
{
    /// <summary>
    /// Description: How to use Barrier class
    /// Reference url: http://blog.csdn.net/zhoucong1020/article/details/6825734
    /// </summary>
    class BarrierClassDemo
    {
        /// <summary>
        /// Create a Barrier reference field
        /// </summary>
        private static Barrier _sync;

        /// <summary>
        /// Sample execute at here. 
        /// </summary>
        public static void Run()
        {
            // Instanced Barrier filed.
            _sync = new Barrier(3);

            // Create three task;
            for (int i = 0; i < 3; i++)
            {
                // Bad idea !
                // var t = new Thread(new ParameterizedThreadStart(Download)) {Name = "Song_" + i};
                var t = new Thread(Download) {Name = "Song_" + i};
                t.Start(i+1);
            }
        }

        /// <summary>
        /// Simulate a download action (and copy action)
        /// </summary>
        /// <param name="time">time value</param>
        static void Download(object time)
        {
            string name = Thread.CurrentThread.Name;
            Console.WriteLine("[{0}] start downloading...", name);

            Thread.Sleep((int)time * 1000);
            Console.WriteLine("[{0}] finished", name);

            _sync.SignalAndWait();
            Console.WriteLine("[{0}] copy to device", name);
        }
    }

    // TODO: Need to complete
    ///// <summary>
    ///// Description: Use Barrier class implement a algorithms.
    ///// Reference url: http://blog.csdn.net/zhoucong1020/article/details/6825734   
    ///// </summary>
    //class BarrierClassDemo2
    //{
    //    static void Action(object i)
    //    {
    //        int index = (int) i;
    //        int k = 1;
    //        while (index%k == 0 && k <= thread_num)
    //        {
                
    //        }
    //    }
    //}

    /// <summary>
    /// A Barrier demo program from MSDN
    /// Reference url: https://msdn.microsoft.com/zh-cn/library/system.threading.barrier(v=vs.110).aspx
    /// </summary>
    class BarrierDemoFromMsdn
    {
        // Demonstreates:
        //   Barrier constructor with post-phase action
        //   Barrier.AddParticipants()
        //   Barrier.RemoveParticipants()
        //   Barrier.SignalAndWait(), incl. a BarrierPostPhaseException beging thrown
        public static void BarrierSample()
        {
            int count = 0;

            // Create a barrier with three participants
            // Provide a post-phase action that will print out certain information
            // And the third time through, it will throw an exception
            var barrier = new Barrier(3, (b) =>
            {
                Console.WriteLine("Post-Phase action: count={0}, phase={1}", count, b.CurrentPhaseNumber);
                if (b.CurrentPhaseNumber == 2) throw new Exception("D'oh!");
            });

            // Nope -- changed my mind. Let's make it five participants.
            barrier.AddParticipants(2);

            // Nope -- let's settle on four participants.
            barrier.RemoveParticipant();

            // This is the logic Run by all participants
            Action action = () =>
            {
                Interlocked.Increment(ref count);
                barrier.SignalAndWait();  // during the post-phase action, count should be 4 and phase should be 0
                Interlocked.Increment(ref count);
                barrier.SignalAndWait();  // during the post-phase action, count should be 8 and phase shouble be 1

                // The third time, SignalAndWait() will throw an exception and all participants will see it
                Interlocked.Increment(ref count);
                try
                {
                    barrier.SignalAndWait();
                }
                catch (BarrierPostPhaseException bppe)
                {
                    Console.WriteLine("Caught BarrierPostPhaseException:{0}", bppe.Message);
                }

                // The fourth time should be hunky-dory
                Interlocked.Increment(ref count);
                barrier.SignalAndWait();  // during the post-phase, count should be 16 and phase should be 3
            };

            // Now launch 4 parallel actions to serve as 4 participants
            Parallel.Invoke(action, action, action, action);

            // This (5 participants) would cause an exception:
            // Parallel.Invoke(action, action, action, action);
            barrier.Dispose();
        }
    }
}
