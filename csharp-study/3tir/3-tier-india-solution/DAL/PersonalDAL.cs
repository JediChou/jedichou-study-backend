using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    /// <summary>
    /// Data Access Layer for Personal
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class PersonalDAL
    {
        /// <summary>
        /// Define default connection string
        /// </summary>
        static readonly string ConnStr = ConfigurationManager.AppSettings["ConnectionString"];

        /// <summary>
        /// Insert record into the database
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="age">Age</param>
        /// <returns>Execute Flag</returns>
        public int Insert(string firstName, string lastName, int age)
        {
            // define a return value
            int returnValue;

            // call sqlserver store procedure to insert record
            using (var conn = new SqlConnection(ConnStr))
            {
                using (var dCmd = new SqlCommand("InsertPerson", conn))
                {
                    dCmd.CommandType = CommandType.StoredProcedure;
                    var prms = new SqlParameter[3];
                    prms[0] = new SqlParameter("@FirstName", SqlDbType.VarChar, 50) {Value = firstName};
                    prms[1] = new SqlParameter("@LastName", SqlDbType.VarChar, 50) {Value = lastName};
                    prms[2] = new SqlParameter("@Age", SqlDbType.Int) {Value = age};

                    dCmd.Parameters.AddRange(prms);

                    conn.Open();
                    returnValue = dCmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            return returnValue;
        }

        /// <summary>
        /// Update a personal record
        /// </summary>
        /// <param name="autoId">User ID</param>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="age">Age</param>
        /// <returns>Execute Flag</returns>
        public int Update(int autoId, string firstName, string lastName, int age)
        {
            // define a return value
            int returnvalue;

            // call sqlserver store procedure to update record
            using (var conn = new SqlConnection(ConnStr))
            {
                using (var dCmd = new SqlCommand("UpdatePerson", conn))
                {
                    dCmd.CommandType = CommandType.StoredProcedure;
                    var prms = new SqlParameter[4];
                    prms[0] = new SqlParameter("@FirstName", SqlDbType.VarChar, 50) { Value = firstName };
                    prms[1] = new SqlParameter("@LastName", SqlDbType.VarChar, 50) { Value = lastName };
                    prms[2] = new SqlParameter("@Age", SqlDbType.Int) { Value = age };
                    prms[3] = new SqlParameter("@AutoId", SqlDbType.Int) { Value = autoId };

                    dCmd.Parameters.AddRange(prms);

                    conn.Open();
                    returnvalue = dCmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            return returnvalue;
        }

        /// <summary>
        /// Delete record from the database table
        /// </summary>
        /// <param name="autoId">User ID</param>
        /// <returns>Execute Flag</returns>
        public int Delete(int autoId)
        {
            // define a return value
            int returnValue;

            using (var conn = new SqlConnection(ConnStr))
            {
                using (var dCmd = new SqlCommand("DeletePerson", conn))
                {
                    dCmd.CommandType = CommandType.StoredProcedure;
                    var prms = new SqlParameter("@AutoId", SqlDbType.Int) { Value = autoId };

                    dCmd.Parameters.Add(prms);

                    conn.Open();
                    returnValue = dCmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            return returnValue;
        }

        /// <summary>
        /// Load a single records from database table
        /// </summary>
        /// <param name="autoId">User ID</param>
        /// <returns></returns>
        public DataTable Load(int autoId)
        {
            // define return value
            var table = new DataTable();
            using (var conn = new SqlConnection(ConnStr))
            {
                using (var ad = new SqlDataAdapter("LoadPerson", conn))
                {
                    ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                    var prm = new SqlParameter("@AutoId", SqlDbType.Int) { Value = autoId };
                    ad.SelectCommand.Parameters.Add(prm);

                    ad.Fill(table);
                }
            }
            return table;
        }

        /// <summary>
        /// Load all records from database table
        /// </summary>
        /// <returns></returns>
        public DataTable LoadAll()
        {
            var table = new DataTable();
            using (var conn = new SqlConnection(ConnStr))
            {
                using (var ad = new SqlDataAdapter("LoadAll", conn))
                {
                    ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                    ad.Fill(table);
                }
            }
            return table;
        }
    }
}
