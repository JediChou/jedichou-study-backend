namespace ADO.NETLib.ch02
{
    using System.Data;

    /// <summary>
    /// Add Colum object to DataTable object
    /// </summary>
    public class AddColToDataTable
    {
        /// <summary>
        /// Add one column to DataTable object
        /// </summary>
        /// <returns>DataTable object with one column</returns>
        public DataTable AddOneColumn()
        {
            // Define datable and column
            var dt = new DataTable("Customer");
            var col = new DataColumn("ID", typeof (string));
            
            // Add column to datatable
            dt.Columns.Add(col);

            return dt;
        }

        /// <summary>
        /// Add some columns to DataTable object
        /// </summary>
        /// <returns>DataTable with some columns</returns>
        public DataTable AddTwoColumns()
        {
            // Define DataTable and some Columns
            var dt = new DataTable("User");
            var colId = new DataColumn("ID", typeof (string));
            var colName = new DataColumn("Name", typeof (string));
            var colAge = new DataColumn("Age", typeof (int));

            // Add column to DataTable
            dt.Columns.Add(colId);
            dt.Columns.Add(colName);
            dt.Columns.Add(colAge);

            return dt;
        }

        /// <summary>
        /// Use AddRange to add some columns to DataTable object.
        /// </summary>
        /// <returns>DataTable with some columns</returns>
        public DataTable UseAddRange()
        {
            // Define DataTable and some Columns
            var dt = new DataTable("User");
            var cols = new[]
            {
                new DataColumn("ID", typeof (string)),
                new DataColumn("Name", typeof (string)),
                new DataColumn("Age", typeof (int))
            };

            // Add columns to DataTable by AddRange method
            dt.Columns.AddRange(cols);

            return dt;
        }
    }
}
