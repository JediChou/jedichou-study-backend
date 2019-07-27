using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo.BLL
{
    public class TBLUserBLL
    {
        public bool CheckPassword(string user, string password)
        {
            var count = new DAL.TBL_Users().GetPassword(user, password);
            return count > 0 ? true : false;
        }
    }
}
