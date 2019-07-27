using SplitSheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SplitSheetTest
{
    [TestClass()]
    public class GetIndexListTest
    {

        /// <summary>
        /// 测试没有重复的情况
        /// </summary>
        [TestMethod()]
        [DeploymentItem("SplitSheet.exe")]
        public void GetIndexListTest_Normal()
        {
            var target = new frmMain_Accessor();
            var list = new List<string> {"a", "b", "c"};
            string str = "a";
            var expected = new List<int> {0};
            var actual = target.GetIndexList(list, str);
            Assert.AreEqual(expected[0], actual[0]);
        }

        /// <summary>
        /// 最前面两个重复的情况
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetIndexListTest_SimpleDuplicateAtHead()
        {
            var target = new frmMain_Accessor();
            var list = new List<string> { "a", "a", "b", "c" };
            var actual = target.GetIndexList(list, "a");
            Assert.AreEqual(0, actual[0]);
            Assert.AreEqual(1, actual[1]);
        }

        /// <summary>
        /// 中间两个重复的情况
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetIndexListTest_SimpleDuplicateAtCenter()
        {
            var target = new frmMain_Accessor();
            var list = new List<string> { "a", "b", "b", "c" };
            var actual = target.GetIndexList(list, "b");
            Assert.AreEqual(1, actual[0]);
            Assert.AreEqual(2, actual[1]);
        }

        /// <summary>
        /// 最后两个重复的情况
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetIndexListTest_SimpleDuplicateAtTail()
        {
            var target = new frmMain_Accessor();
            var list = new List<string> { "a", "b", "c", "c" };
            var actual = target.GetIndexList(list, "c");
            Assert.AreEqual(2, actual[0]);
            Assert.AreEqual(3, actual[1]);
        }

        /// <summary>
        /// 被查询的字符串在List中没有
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetIndexListTest_ListWithoutStr()
        {
            var target = new frmMain_Accessor();
            var list = new List<string> { "a", "b", "c" };
            var actual = target.GetIndexList(list, "d");
            Assert.AreEqual(0, actual.Count);
        }

        /// <summary>
        /// 待处理List为空
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetIndexListTest_ListIsNull()
        {
            var target = new frmMain_Accessor();
            List<string> list = null;
            var actual = target.GetIndexList(list, "a");
            Assert.IsNull(actual);
        }

        /// <summary>
        /// 待处理List的长度为零
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetIndexListTest_ListCountIsZero()
        {
            var target = new frmMain_Accessor();
            List<string> list = new List<string>();
            var actual = target.GetIndexList(list, "a");
            Assert.IsNull(actual);
        }
    }
}
