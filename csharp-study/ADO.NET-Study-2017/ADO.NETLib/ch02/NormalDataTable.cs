namespace ADO.NETLib.ch02
{
    using System.Data;

    /// <summary>
    /// Get a normal DataTable object
    /// </summary>
    public class NormalDataTable
    {
        /// <summary>
        /// Get a Books data table
        /// </summary>
        /// <returns>Books DataTable</returns>
        public DataTable GetBooksDataTable()
        {
            var dt = new DataTable("Books");
            var idCol = new DataColumn("BookId", typeof(int));
            var nameCol = new DataColumn("BookName", typeof(string));
            var priceCol = new DataColumn("BookPrice", typeof(double));

            dt.Columns.Add(idCol);
            dt.Columns.Add(nameCol);
            dt.Columns.Add(priceCol);

            return dt;
        }

        /// <summary>
        /// Get an Employees data table
        /// </summary>
        /// <returns>Employees DataTable</returns>
        public DataTable GetEmployeeDataTable()
        {
            var dt = new DataTable("Employees");
            dt.Columns.Add("EmpId", typeof(int));
            dt.Columns.Add("WorkId", typeof(string));
            dt.Columns.Add("NotesMail", typeof(string));
            dt.Columns.Add("SuperNotes", typeof(string));
            return dt;
        }
    }
}
