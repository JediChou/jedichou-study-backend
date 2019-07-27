namespace ADO.NETLib.ch02
{
    using System.Data;

    /// <summary>
    /// DataColumn's property
    /// </summary>
    public class ColumnProp
    {
        /// <summary>
        /// Check AllowDbNull Property
        /// </summary>
        /// <returns></returns>
        public DataTable AllowDbNullProp()
        {
            // Define DataTable and DataColumn object instance
            var dt = new DataTable("Database");
            var col = new DataColumn("ID", typeof (string)) {AllowDBNull = true};

            // Add col to dt
            dt.Columns.Add(col);

            return dt;
        }

        /// <summary>
        /// Check AutoIncrement Property
        /// </summary>
        /// <returns></returns>
        public DataTable AutoIncrementProp()
        {
            // Define DataTable and DataColumn object instance
            var dt = new DataTable("Database");
            var col = new DataColumn("IntId", typeof (int)) {AutoIncrement = true};
            
            // Add col to dt
            dt.Columns.Add(col);

            return dt;
        }
    }
}
