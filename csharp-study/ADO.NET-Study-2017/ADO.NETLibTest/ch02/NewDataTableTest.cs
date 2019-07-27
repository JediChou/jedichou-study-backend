namespace ADO.NETLibTest.ch02
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NETLib.ch02;

    /// <summary>
    /// NewDataTableTest for NewDataTable class
    /// </summary>
    [TestClass]
    public class NewDataTableTest
    {
        /// <summary>
        /// Test method for GetUnnamedDataTable
        /// </summary>
        [TestMethod]
        public void GetUnnamedDataTableTest()
        {
            var ntt = new NewDataTable();
            var dt = ntt.GetUnnamedDataTable();
            Assert.AreEqual("", dt.TableName, "Unnamed data table error");
        }

        /// <summary>
        /// Test method for GetNamedDataTable
        /// </summary>
        [TestMethod]
        public void GetNamedDataTableTest()
        {
            var ntt = new NewDataTable();
            var dt = ntt.GetNamedDataTable("Jedi");
            Assert.AreEqual("Jedi", dt.TableName, "Named data table error");
        }
    }
}
