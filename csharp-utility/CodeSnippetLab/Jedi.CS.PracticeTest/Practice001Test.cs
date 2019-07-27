namespace Jedi.CS.PracticeTest
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using System.Diagnostics;
    using CodeSnippetLab.Practice001;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Practice001Test 的摘要描述
    /// </summary>
    [TestClass]
    public class Practice001Test
    {
        [TestMethod]
        public void Practice001_100IterationCompare()
        {
            var ts1 = new Stopwatch();
            var ts2 = new Stopwatch();

            ts1.Start();
            for (int i = 0; i < 1000; i++)
                Practice001.InBox();
            ts1.Stop();

            ts2.Start();
            for (int i = 0; i < 1000; i++)
                Practice001.NoBox();
            ts2.Stop();

            long ts1times = ts1.ElapsedMilliseconds;
            long ts2times = ts2.ElapsedMilliseconds;
            Assert.IsTrue(ts1times >= ts2times);
        }
    }
}
