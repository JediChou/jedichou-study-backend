using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using RegToTblSeat.Model;

namespace RegToTblSeat.DAL
{
    public class TblSeatDAL
    {
        public int Insert(TSeat tseat)
        {
            var sql = "insert into TblSeat(LoginID, LoginPassword, UserName) values(@LoginID, @LoginPassword, @UserName)";
            var pms = new SqlParameter[] {
                new SqlParameter("@LoginID", tseat.LoginId),
                new SqlParameter("@LoginPassword", tseat.LoginPassword),
                new SqlParameter("@UserName", tseat.UserName),
            };
            return (int)SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);
        }
    }
}
