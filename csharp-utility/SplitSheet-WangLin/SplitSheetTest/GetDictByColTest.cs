using SplitSheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SplitSheetTest
{

    [TestClass()]
    public class GetDictByColTest
    {
        /// <summary>
        /// 测试一个List非空的情况, 且元素不重复的情况
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetDictByColTest_Normal()
        {
            var target = new frmMain_Accessor();
            var actual = target.GetDictByCol(new List<string> { "a", "b", "c" });
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(0, actual["a"][0]);
            Assert.AreEqual(1, actual["b"][0]);
            Assert.AreEqual(2, actual["c"][0]);
        }

        /// <summary>
        /// 测试前两个元素重复的List
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetDictByColTest_SimpleDuplicateAtHead()
        {
            var target = new frmMain_Accessor();
            var actual = target.GetDictByCol(new List<string> { "a", "a", "b", "c" });
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(0, actual["a"][0]);
            Assert.AreEqual(1, actual["a"][1]);
            Assert.AreEqual(2, actual["b"][0]);
            Assert.AreEqual(3, actual["c"][0]);
        }

        /// <summary>
        /// 测试中间两个元素重复
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetDictByColTest_SimpleDuplicateAtCenter()
        {
            var target = new frmMain_Accessor();
            var actual = target.GetDictByCol(new List<string> { "a", "b", "b", "c" });
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(0, actual["a"][0]);
            Assert.AreEqual(1, actual["b"][0]);
            Assert.AreEqual(2, actual["b"][1]);
            Assert.AreEqual(3, actual["c"][0]);
        }

        /// <summary>
        /// 测试末尾两个元素重复
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetDictByColTest_SimpleDuplicateAtTail()
        {
            var target = new frmMain_Accessor();
            var actual = target.GetDictByCol(new List<string> { "a", "b", "c", "c" });
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(0, actual["a"][0]);
            Assert.AreEqual(1, actual["b"][0]);
            Assert.AreEqual(2, actual["c"][0]);
            Assert.AreEqual(3, actual["c"][1]);
        }

        /// <summary>
        /// 待测试的字符串为null
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetDictByColTest_ListIsNull()
        {
            var target = new frmMain_Accessor();
            var actual = target.GetDictByCol(null);
            Assert.AreEqual(0, actual.Count);
        }

        /// <summary>
        /// 待测试的字符串为的长度为零
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetDictByColTest_ListCountIsZero()
        {
            var target = new frmMain_Accessor();
            var actual = target.GetDictByCol(new List<string>());
            Assert.AreEqual(0, actual.Count);
        }

        /// <summary>
        /// 测试一个实际数据
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetDictByColTest_FactData()
        {
            var target = new frmMain_Accessor();
            var actual = target.GetDictByCol(new List<string> { 
                "月份",      // 0
                "DB32C7",   // 1
                "DB32C8",   // 2
                "DB32C9",   // 3
                "DB32C7",   // 4
                "DB32C8",   // 5
                "DB32C9"    // 6
            });
            Assert.AreEqual(4, actual.Count);
            Assert.AreEqual(0, actual["月份"][0]);
            Assert.AreEqual(1, actual["DB32C7"][0]);
            Assert.AreEqual(2, actual["DB32C8"][0]);
            Assert.AreEqual(3, actual["DB32C9"][0]);
            Assert.AreEqual(4, actual["DB32C7"][1]);
            Assert.AreEqual(5, actual["DB32C8"][1]);
            Assert.AreEqual(6, actual["DB32C9"][1]);
        }
    }
}
