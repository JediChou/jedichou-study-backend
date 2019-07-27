namespace ADO.NETLibTest.ch02
{
    using ADO.NETLib.ch02;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Data;
    
    [TestClass]
    public class AddColToDataTableTest
    {

        /// <summary>
        /// Test method of AddOneColumn
        ///</summary>
        [TestMethod]
        public void AddOneColumnTest()
        {
            var acdt = new AddColToDataTable();
            var ds = acdt.AddOneColumn();
            Assert.AreEqual("Customer", ds.TableName);
            Assert.AreEqual(1, ds.Columns.Count);
            Assert.AreEqual("ID", ds.Columns[0].ColumnName);
        }

        /// <summary>
        /// Test method of AddTwoColumns
        /// </summary>
        [TestMethod]
        public void AddTwoColumnsTest()
        {
            var acdt = new AddColToDataTable();
            var ds = acdt.AddTwoColumns();

            // Check column's name and count value of ds. 
            Assert.AreEqual("User", ds.TableName);
            Assert.AreEqual(3, ds.Columns.Count);

            // Check by name
            Assert.AreEqual("ID", ds.Columns["ID"].ColumnName);
            Assert.AreEqual("Name", ds.Columns["Name"].ColumnName);
            Assert.AreEqual("Age", ds.Columns["Age"].ColumnName);

            // Check by column index
            Assert.AreEqual("ID", ds.Columns[0].ColumnName);
            Assert.AreEqual("Name", ds.Columns[1].ColumnName);
            Assert.AreEqual("Age", ds.Columns[2].ColumnName);
        }

        /// <summary>
        /// Test method of UseAddRange
        /// </summary>
        [TestMethod]
        public void UseAddRangeTest()
        {
            var acdt = new AddColToDataTable();
            var ds = acdt.UseAddRange();

            // Check column's name and count value of ds. 
            Assert.AreEqual("User", ds.TableName);
            Assert.AreEqual(3, ds.Columns.Count);

            // Check by name
            Assert.AreEqual("ID", ds.Columns["ID"].ColumnName);
            Assert.AreEqual("Name", ds.Columns["Name"].ColumnName);
            Assert.AreEqual("Age", ds.Columns["Age"].ColumnName);

            // Check by column index
            Assert.AreEqual("ID", ds.Columns[0].ColumnName);
            Assert.AreEqual("Name", ds.Columns[1].ColumnName);
            Assert.AreEqual("Age", ds.Columns[2].ColumnName);
        }
    }
}
