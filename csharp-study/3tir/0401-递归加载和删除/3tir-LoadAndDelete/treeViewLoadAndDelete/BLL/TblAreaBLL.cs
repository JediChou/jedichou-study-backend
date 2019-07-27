using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using treeViewLoadAndDelete.Model;
using treeViewLoadAndDelete.DAL;

namespace treeViewLoadAndDelete.BLL
{
    /// <summary>
    /// Business layer class for TblArea table
    /// </summary>
    public class TblAreaBLL
    {
        TblAreaDAL dal = new TblAreaDAL();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<TblArea> GetAreaByAreaPid(int pid)
        {
            return dal.GetAreaByAreaPid(pid);
        }

        public void RecuseDelete(int areaid)
        {
            // 1. 根据areaid查询它的所有子元素
            // 1.1 遍历查询到所有数据, 继续递归查询
            // 2. 将当前areaid这条记录删除
            
            List<TblArea> list = dal.GetAreaByAreaPid(areaid);
            foreach (TblArea item in list)
                RecuseDelete(item.AreaId);
            dal.DeleteAreaByAreaId(areaid);
        }
    }
}
