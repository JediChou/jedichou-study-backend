using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegToTblSeat.DAL;
using RegToTblSeat.Model;

namespace RegToTblSeat.BLL
{
    public class TblSeatBLL
    {
        TblSeatDAL dal = new TblSeatDAL();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tseat"></param>
        /// <returns></returns>
        public int RegUser(TSeat tseat)
        {
            tseat.LoginPassword = Common.SecurityHelp.GetMD5(tseat.LoginPassword);
            return dal.Insert(tseat);
        }
    }
}
