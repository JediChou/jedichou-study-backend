using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using treeViewLoadAndDelete.Model;
using System.Data;
using System.Data.SqlClient;

namespace treeViewLoadAndDelete.DAL
{
    /// <summary>
    /// Data access Operate for TblArea
    /// </summary>
    public class TblAreaDAL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<TblArea> GetAreaByAreaPid(int pid)
        {
            List<TblArea> list = new List<TblArea>();
            var sql = "select AreaID, AreaName from TBLArea where AreaPID = @pid";
            var pms = new SqlParameter("@pid", pid);

            using (var reader = SqlHelper.ExecuteReader(sql, CommandType.Text, pms))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var model = new TblArea();
                        model.AreaId = reader.GetInt32(0);
                        model.AreaName = reader.GetString(1);
                        list.Add(model);
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteAreaByAreaId(int id)
        {
            var sql = "delete from TBLArea where AreaID = @areaid";
            var pms = new SqlParameter("@areaid", id);
            return (int)SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);
        }
    }
}
