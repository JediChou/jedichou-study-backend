namespace ADO.NETLib.ch02
{
    using System;
    using System.Data;

    /// <summary>
    /// NewDataColumn class
    /// </summary>
    public class NewDataColumn
    {
        /// <summary>
        /// Get a default data column
        /// </summary>
        /// <returns>DataColumn object</returns>
        public DataColumn GetEmptyDataColumn()
        {
            var dc = new DataColumn();
            return dc;
        }

        /// <summary>
        /// Get a boolean data column
        /// </summary>
        /// <returns>DataColumn object</returns>
        public DataColumn GetBooleanDataColumn()
        {
            var dc = new DataColumn("Checked", typeof(Boolean));
            return dc;
        }

        /// <summary>
        /// Get a byte data column
        /// </summary>
        /// <returns>DataColumn object</returns>
        public DataColumn GetByteDataColumn()
        {
            var dc = new DataColumn("File", typeof(byte));
            return dc;
        }

        /// <summary>
        /// Get a Char DataColumn
        /// </summary>
        /// <returns>DataColumn object</returns>
        public DataColumn GetCharDataColumn()
        {
            var dc = new DataColumn("Prefix", typeof(char));
            return dc;
        }

        /// <summary>
        /// Get a DateTime DataColumn
        /// </summary>
        /// <returns>DataColumn object</returns>
        public DataColumn GetDatetimeColumn()
        {
            var dc = new DataColumn("ModifyTime", typeof(DateTime));
            return dc;
        }

        /// <summary>
        /// Get a Decimal DataColumn
        /// </summary>
        /// <returns>DataColumn object</returns>
        public DataColumn GetDecimalColumn()
        {
            var dc = new DataColumn("Current", typeof(Decimal));
            return dc;
        }

        /// <summary>
        /// Get a double DataColumn
        /// </summary>
        /// <returns>DataColumn object</returns>
        public DataColumn GetDoubleDataColumn()
        {
            var dc = new DataColumn("HighMask", typeof(Double));
            return dc;
        }

        /// <summary>
        /// Get a Int16 DataColumn
        /// </summary>
        /// <returns>DataColumn object</returns>
        public DataColumn GetInt16DataColumn()
        {
            var dc = new DataColumn("IronAge", typeof(Int16));
            return dc;
        }

        /// <summary>
        /// Get a Int32 DataColumn
        /// </summary>
        /// <returns>DataColumn object</returns>
        public DataColumn GetInt32DataColumn()
        {
            var dc = new DataColumn("GoldAge", typeof(Int32));
            return dc;
        }

        /// <summary>
        /// Get a Int64 DataColumn
        /// </summary>
        /// <returns>DataColumn object</returns>
        public DataColumn GetInt64DataColumn()
        {
            var dc = new DataColumn("GodsAge", typeof(Int64));
            return dc;
        }

        /// <summary>
        /// Get a SByte DataColumn
        /// </summary>
        /// <returns>DataColumn Object</returns>
        public DataColumn GetSByteDataColumn()
        {
            var dc = new DataColumn("SmallFile", typeof(SByte));
            return dc;
        }

        /// <summary>
        /// Get a Single DataColumn
        /// </summary>
        /// <returns>DataColumn Object</returns>
        public DataColumn GetSingleDataColumn()
        {
            var dc = new DataColumn("SingleMask", typeof(Single));
            return dc;
        }

        /// <summary>
        /// Get a String DataColumn
        /// </summary>
        /// <returns>DataColumn Object</returns>
        public DataColumn GetStringDataColumn()
        {
            var dc = new DataColumn("StringMask", typeof(string));
            return dc;
        }

        /// <summary>
        /// Get a TimeSpan DataColumn
        /// </summary>
        /// <returns>DataColumn Object</returns>
        public DataColumn GetTimeSpanDataColumn()
        {
            var dc = new DataColumn("TimeSpan", typeof(TimeSpan));
            return dc;
        }

        /// <summary>
        /// Get an UInt16 DataColumn
        /// </summary>
        /// <returns>DataColumn Object</returns>
        public DataColumn GetUInt16DataColumn()
        {
            var dc = new DataColumn("UInt16", typeof(UInt16));
            return dc;
        }

        /// <summary>
        /// Get an UInt32 DataColumn
        /// </summary>
        /// <returns>DataColumn Object</returns>
        public DataColumn GetUInt32DataColumn()
        {
            var dc = new DataColumn("UInt32", typeof(UInt32));
            return dc;
        }

        /// <summary>
        /// Get an UInt64 DataColumn
        /// </summary>
        /// <returns>DataColumn Object</returns>
        public DataColumn GetUInt64DataColumn()
        {
            var dc = new DataColumn("UInt64", typeof(UInt64));
            return dc;
        }

        /// <summary>
        /// Get a byte array DataColumn
        /// </summary>
        /// <returns></returns>
        public DataColumn GetByteArrayDataColumn()
        {
            var dc = new DataColumn("ByteArray", typeof(byte[]));
            return dc;
        }
    }
}
