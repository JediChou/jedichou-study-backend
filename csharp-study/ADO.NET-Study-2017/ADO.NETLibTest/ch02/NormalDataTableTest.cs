namespace ADO.NETLibTest
{
    using ADO.NETLib.ch02;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Data;

    /// <summary>
    /// NormalDataTableTest class
    ///</summary>
    [TestClass]
    public class NormalDataTableTest
    {
        /// <summary>
        /// GetBooksDataTableTest method test 
        /// </summary>
        [TestMethod]
        public void GetBooksDataTableTest()
        {
            var target = new NormalDataTable().GetBooksDataTable();
            var columns = target.Columns;
            Assert.AreEqual(3, columns.Count);
            Assert.IsTrue(columns.Contains("BookId"));
            Assert.IsTrue(columns.Contains("BookName"));
            Assert.IsTrue(columns.Contains("BookPrice"));
        }

        /// <summary>
        /// GetEmployeeDataTable method test
        /// </summary>
        [TestMethod]
        public void GetEmployeeDataTableTest()
        {
            var target = new NormalDataTable().GetEmployeeDataTable();
            var columns = target.Columns;
            Assert.AreEqual(4, columns.Count);
            Assert.IsTrue(columns.Contains("EmpId"));
            Assert.IsTrue(columns.Contains("WorkId"));
        }
    }
}
