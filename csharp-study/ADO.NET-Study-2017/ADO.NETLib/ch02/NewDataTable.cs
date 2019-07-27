namespace ADO.NETLib.ch02
{
    using System.Data;

    /// <summary>
    /// Get a new data table
    /// </summary>
    public class NewDataTable
    {
        /// <summary>
        /// Get a unnamed data table object
        /// </summary>
        /// <returns>unnamed data table</returns>
        public DataTable GetUnnamedDataTable()
        {
            var dt = new DataTable();
            return dt;
        }

        /// <summary>
        /// Get a named data table object
        /// </summary>
        /// <param name="tbname">data table name</param>
        /// <returns>named data table</returns>
        public DataTable GetNamedDataTable(string tbname)
        {
            var dt = new DataTable(tbname);
            return dt;
        }
    }
}
