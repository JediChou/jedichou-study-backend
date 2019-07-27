namespace ADO.NETLibTest.ch02
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NETLib.ch02;

    /// <summary>
    /// NewDataColumnTest
    /// </summary>
    [TestClass]
    public class NewDataColumnTest
    {
        /// <summary>
        /// Check DataColomn name
        /// </summary>
        [TestMethod]
        public void GetEmptyDataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetEmptyDataColumn();
            Assert.AreEqual("System.Data.DataColumn", dc.GetType().ToString());
        }

        /// <summary>
        /// Check Boolean DataColumn
        /// </summary>
        [TestMethod]
        public void GetBooleanDataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetBooleanDataColumn();
            Assert.AreEqual("Checked", dc.ToString());
            Assert.AreEqual("System.Boolean", dc.DataType.ToString());
        }

        /// <summary>
        /// Check Byte DataColumn
        /// </summary>
        [TestMethod]
        public void GetByteDataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetByteDataColumn();
            Assert.AreEqual("File", dc.ToString());
            Assert.AreEqual("System.Byte", dc.DataType.ToString());
        }

        /// <summary>
        /// Check Char DataColumn
        /// </summary>
        [TestMethod]
        public void GetCharDataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetCharDataColumn();
            Assert.AreEqual("Prefix", dc.ToString());
            Assert.AreEqual("System.Char", dc.DataType.ToString());
        }

        /// <summary>
        /// Check Datetime DataColumn
        /// </summary>
        [TestMethod]
        public void GetDatetimeColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetDatetimeColumn();
            Assert.AreEqual("ModifyTime", dc.ToString());
            Assert.AreEqual("System.DateTime", dc.DataType.ToString());
        }

        /// <summary>
        /// Check Decimal DataColumn
        /// </summary>
        [TestMethod]
        public void GetDecimalDataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetDecimalColumn();
            Assert.AreEqual("Current", dc.ToString());
            Assert.AreEqual("System.Decimal", dc.DataType.ToString());
        }

        /// <summary>
        /// Check Double DataColumn
        /// </summary>
        [TestMethod]
        public void GetDoubleDataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetDoubleDataColumn();
            Assert.AreEqual("HighMask", dc.ToString());
            Assert.AreEqual("System.Double", dc.DataType.ToString());
        }

        /// <summary>
        /// Check Int16 DataColumn
        /// </summary>
        [TestMethod]
        public void GetInt16DataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetInt16DataColumn();
            Assert.AreEqual("IronAge", dc.ToString());
            Assert.AreEqual("System.Int16", dc.DataType.ToString());
        }

        /// <summary>
        /// Check Int32 DataColumn
        /// </summary>
        [TestMethod]
        public void GetInt32DataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetInt32DataColumn();
            Assert.AreEqual("GoldAge", dc.ToString());
            Assert.AreEqual("System.Int32", dc.DataType.ToString());
        }

        /// <summary>
        /// Check Int64 DataColumn
        /// </summary>
        [TestMethod]
        public void GetInt64DataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetInt64DataColumn();
            Assert.AreEqual("GodsAge", dc.ToString());
            Assert.AreEqual("System.Int64", dc.DataType.ToString());
        }

        /// <summary>
        /// Check SByte DataColumn
        /// </summary>
        [TestMethod]
        public void GetSByteDataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetSByteDataColumn();
            Assert.AreEqual("SmallFile", dc.ToString());
            Assert.AreEqual("System.SByte", dc.DataType.ToString());
        }

        /// <summary>
        /// Check Single DataColumn
        /// </summary>
        [TestMethod]
        public void GetSingleDataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetSingleDataColumn();
            Assert.AreEqual("SingleMask", dc.ToString());
            Assert.AreEqual("System.Single", dc.DataType.ToString());
        }

        /// <summary>
        /// Check String DataColumn
        /// </summary>
        [TestMethod]
        public void GetStringDataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetStringDataColumn();
            Assert.AreEqual("StringMask", dc.ToString());
            Assert.AreEqual("System.String", dc.DataType.ToString());
        }

        /// <summary>
        /// Check TimeSpan DataColumn
        /// </summary>
        [TestMethod]
        public void GetTimeSpanDataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetTimeSpanDataColumn();
            Assert.AreEqual("TimeSpan", dc.ToString());
            Assert.AreEqual("System.TimeSpan", dc.DataType.ToString());
        }

        
        /// <summary>
        /// Check UInt16 DataColumn 
        /// </summary>
        [TestMethod]
        public void GetUInt16DataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetUInt16DataColumn();
            Assert.AreEqual("UInt16", dc.ToString());
            Assert.AreEqual("System.UInt16", dc.DataType.ToString());
        }

        /// <summary>
        /// Check UInt32 DataColumn
        /// </summary>
        [TestMethod]
        public void GetUInt32DataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetUInt32DataColumn();
            Assert.AreEqual("UInt32", dc.ToString());
            Assert.AreEqual("System.UInt32", dc.DataType.ToString());
        }

        /// <summary>
        /// Check UInt64 DataColumn
        /// </summary>
        [TestMethod]
        public void GetUInt64DataColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetUInt64DataColumn();
            Assert.AreEqual("UInt64", dc.ToString());
            Assert.AreEqual("System.UInt64", dc.DataType.ToString());
        }

        /// <summary>
        /// Check Byte Array DataColumn
        /// </summary>
        [TestMethod]
        public void GetByteArrayColumnTest()
        {
            var ndc = new NewDataColumn();
            var dc = ndc.GetByteArrayDataColumn();
            Assert.AreEqual("ByteArray", dc.ToString());
            Assert.AreEqual("System.Byte[]", dc.DataType.ToString());
        }
    }
}
