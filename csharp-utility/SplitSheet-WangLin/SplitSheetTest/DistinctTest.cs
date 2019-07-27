using SplitSheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SplitSheetTest
{
    [TestClass()]
    public class DistinctTest
    {
        /// <summary>
        /// 处理一个正常的List
        /// </summary>
        [TestMethod()]
        [DeploymentItem("SplitSheet.exe")]
        public void DistinctTest_Normal()
        {
            frmMain_Accessor target = new frmMain_Accessor();
            var expected = new List<string> { "a", "b", "c" };
            var actual = target.Distinct(new List<string> { "a", "b", "c", "c" });
            for (int i = 0; i < actual.Count; i++)
                Assert.AreEqual(expected[i], actual[i]);
        }

        /// <summary>
        /// 处理一个空的List
        /// </summary>
        [TestMethod()]
        [DeploymentItem("SplitSheet.exe")]
        public void DistinctTest_Null()
        {
            frmMain_Accessor target = new frmMain_Accessor();
            var expected = new List<string>();
            var actual = target.Distinct(expected);
            Assert.IsNull(actual);
        }
    }
}
