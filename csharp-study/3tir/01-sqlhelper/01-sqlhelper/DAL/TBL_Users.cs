using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace demo.DAL
{
    public class TBL_Users
    {
        public int GetPassword(string user, string password)
        {
            var sql = "select count(1) from users where loginId=@uid and loginPwd=@pwd";
            var pms = new SqlParameter[] {
                new SqlParameter("@uid", user),
                new SqlParameter("@pwd", password)
            };
            return (int) SqlHelper.ExecuteScalar(sql, CommandType.Text, pms);
        }
    }
}
