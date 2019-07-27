using SplitSheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SplitSheetTest
{
    [TestClass]
    public class GetDeleteLocationTest
    {
        /// <summary>
        /// 测试最为普通的情况
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetDeleteLocationTest_Normal()
        {
            var list = new List<int> { 0, 1, 2 };
            frmMain_Accessor target = new frmMain_Accessor();
            var actual = target.GetDeleteLocation(list, 5);
            Assert.AreEqual(3, actual[0]);
            Assert.AreEqual(4, actual[1]);
        }

        /// <summary>
        /// 给的列表中有重复元素
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetDeleteLocationTest_ElementDuplicate()
        {
            var list = new List<int> { 0, 1, 1, 2 };
            frmMain_Accessor target = new frmMain_Accessor();
            var actual = target.GetDeleteLocation(list, 5);
            Assert.AreEqual(3, actual[0]);
            Assert.AreEqual(4, actual[1]);
        }

        /// <summary>
        /// 给的列表中的长度有问题
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetDeleteLocationTest_ListLengthIsWrong()
        {
            var list = new List<int> { 0, 1, 1, 2, 2, 0, 1, 2 };
            frmMain_Accessor target = new frmMain_Accessor();
            var actual = target.GetDeleteLocation(list, 5);
            Assert.AreEqual(3, actual[0]);
            Assert.AreEqual(4, actual[1]);
        }
    }
}
