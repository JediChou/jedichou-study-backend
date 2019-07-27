using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECSDB_CmdTest
{
    class Order
    {
        public int OrderId { get; set; }
        public string Prefix { get; set; }
        public string Month { get; set; }

        public Order(string prefix, string month, int id)
        {
            Prefix = prefix;
            Month = month;
            OrderId = id;
        }
    }
}
