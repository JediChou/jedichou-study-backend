using ADO.NETLib.ch02;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace ADO.NETLibTest.ch02
{
    /// <summary>
    /// Test class for ColumnProp
    ///</summary>
    [TestClass]
    public class ColumnPropTest
    {
        /// <summary>
        /// Test method for AllowDbNullProp
        /// </summary>
        [TestMethod]
        public void AllowDbNullPropTest()
        {
            var clp = new ColumnProp();
            var dt = clp.AllowDbNullProp();
            Assert.IsTrue(dt.Columns["ID"].AllowDBNull);
        }

        /// <summary>
        /// Test method for AutoIncrementProp
        /// </summary>
        [TestMethod]
        public void AutoIncrementPropTest()
        {
            var clp = new ColumnProp();
            var dt = clp.AutoIncrementProp();
            Assert.IsTrue(dt.Columns["IntId"].AutoIncrement);
        }
    }
}
