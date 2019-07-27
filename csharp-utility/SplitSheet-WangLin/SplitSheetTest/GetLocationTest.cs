using SplitSheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SplitSheetTest
{
    [TestClass]
    public class GetLocationTest
    {
        /// <summary>
        /// 每个元素只重复一次
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetLocationTest_Once()
        {
            var list = new List<string> { "a", "b", "c" };
            var target = new frmMain_Accessor();
            Assert.AreEqual(0, target.GetLocation(list, "a")[0]);
            Assert.AreEqual(1, target.GetLocation(list, "b")[0]);
            Assert.AreEqual(2, target.GetLocation(list, "c")[0]);
        }

        /// <summary>
        /// 每个元素只重复两次, 且重复字符不连续
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetLocationTest_TwiceNotContinue()
        {
            var list = new List<string> { "a", "b", "c", "a", "b", "c" };
            var target = new frmMain_Accessor();
            Assert.AreEqual(0, target.GetLocation(list, "a")[0]);
            Assert.AreEqual(3, target.GetLocation(list, "a")[1]);
            Assert.AreEqual(1, target.GetLocation(list, "b")[0]);
            Assert.AreEqual(4, target.GetLocation(list, "b")[1]);
            Assert.AreEqual(2, target.GetLocation(list, "c")[0]);
            Assert.AreEqual(5, target.GetLocation(list, "c")[1]); 
        }

        /// <summary>
        /// 每个元素只重复两次, 且重复字符连续
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetLocationTest_TwiceContinue()
        {
            var list = new List<string> { "a", "a", "b", "b", "c", "c" };
            var target = new frmMain_Accessor();
            Assert.AreEqual(0, target.GetLocation(list, "a")[0]);
            Assert.AreEqual(1, target.GetLocation(list, "a")[1]);
            Assert.AreEqual(2, target.GetLocation(list, "b")[0]);
            Assert.AreEqual(3, target.GetLocation(list, "b")[1]);
            Assert.AreEqual(4, target.GetLocation(list, "c")[0]);
            Assert.AreEqual(5, target.GetLocation(list, "c")[1]);
        }

        /// <summary>
        /// 只有一个元素不同, 且前面的元素相同
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetLocationTest_OnlyOnceDifferent_Backward()
        {
            var list = new List<string> { "a", "a", "a", "a", "a", "b" };
            var target = new frmMain_Accessor();
            Assert.AreEqual(0, target.GetLocation(list, "a")[0]);
            Assert.AreEqual(1, target.GetLocation(list, "a")[1]);
            Assert.AreEqual(2, target.GetLocation(list, "a")[2]);
            Assert.AreEqual(3, target.GetLocation(list, "a")[3]);
            Assert.AreEqual(4, target.GetLocation(list, "a")[4]);
            Assert.AreEqual(5, target.GetLocation(list, "b")[0]);
        }

        /// <summary>
        /// 只有一个元素不同, 且后面的元素相同
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetLocationTest_OnlyOnceDifferent_Forward()
        {
            var list = new List<string> { "b", "a", "a", "a", "a", "a"};
            var target = new frmMain_Accessor();
            Assert.AreEqual(0, target.GetLocation(list, "b")[0]);
            Assert.AreEqual(1, target.GetLocation(list, "a")[0]);
            Assert.AreEqual(2, target.GetLocation(list, "a")[1]);
            Assert.AreEqual(3, target.GetLocation(list, "a")[2]);
            Assert.AreEqual(4, target.GetLocation(list, "a")[3]);
            Assert.AreEqual(5, target.GetLocation(list, "a")[4]);
        }

        /// <summary>
        /// list参数为空的情况
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetLocationTest_ListParameterIsNull()
        {
            var target = new frmMain_Accessor();
            var actual = target.GetLocation(null, "b");
            Assert.IsNull(actual);
        }

        /// <summary>
        /// 搜索字符串为null
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetLocationTest_StringParameterIsNull()
        {
            var target = new frmMain_Accessor();
            var actual = target.GetLocation(new List<string> {"b"}, null);
            Assert.IsNull(actual);
        }

        /// <summary>
        /// 搜索字符串为空字符串
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetLocationTest_StringParameterIsEmpty()
        {
            var target = new frmMain_Accessor();
            var actual = target.GetLocation(new List<string> { "b" }, "");
            Assert.IsNull(actual);
        }
    }
}
