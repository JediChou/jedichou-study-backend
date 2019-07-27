using System.Data;
using DAL;

namespace BAL
{
    // ReSharper disable once InconsistentNaming
    public class PersonalBLL
    {
        /// <summary>
        /// Insert record into the database
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="age">Age</param>
        /// <returns>Sucess Flag</returns>
        public int Insert(string firstName, string lastName, int age)
        {
            // Your business logic, calculations or validations may go here
            return new PersonalDAL().Insert(firstName, lastName, age);
        }

        /// <summary>
        /// Update record into the database
        /// </summary>
        /// <param name="autoId">User ID</param>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="age">Age</param>
        /// <returns>Success flag</returns>
        public int Update(int autoId, string firstName, string lastName, int age)
        {
            // your business logic, calculations or validations may go here
            return new PersonalDAL().Update(autoId, firstName, lastName, age);
        }

        /// <summary>
        /// Delete record from the database table
        /// </summary>
        /// <param name="autoId">User ID</param>
        /// <returns>Success flag</returns>
        public int Delete(int autoId)
        {
            // your business logic, calculations or validations may go here
            return new PersonalDAL().Delete(autoId);
        }

        /// <summary>
        /// Load all records from database table
        /// </summary>
        /// <returns>All Informations</returns>
        public DataTable LoadAll()
        {
            // your business logic, calculations or validations may go here
            return new PersonalDAL().LoadAll();
        }

        /// <summary>
        /// Load a single records from database table
        /// </summary>
        /// <param name="autoId">User ID</param>
        /// <returns>Single Perfonal Information</returns>
        public DataTable Load(int autoId)
        {
            // your business logic, calculations or validations may go here
            return new PersonalDAL().Load(autoId);
        }
    }
}
