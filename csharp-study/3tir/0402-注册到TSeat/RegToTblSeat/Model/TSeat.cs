using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegToTblSeat.Model
{
    /// <summary>
    /// 对应数据库中的的TblSeat表
    /// </summary>
    public class TSeat
    {
        public int AutoID { get; set; }
        public string LoginId { get; set; }
        public string LoginPassword { get; set; }
        public string UserName { get; set; }
        public int ErrorTimes { get; set; }
        public DateTime? LockDateTime { get; set; }
        public int? TestInt { get; set; }
    }
}
