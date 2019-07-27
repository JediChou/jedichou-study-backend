using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECSDB_CmdTest
{
    /// <summary>
    /// ECS常量类
    /// </summary>
    class ECStaicVar
    {
        /// <summary>
        /// 可用号段
        /// </summary>
        public static List<string> Prefix = new List<string>
        {
            "H", "I", "J", "K", "L",
            "M", "N", "O", "P", "Q",
            "R", "S", "T", "U", "V",
            "W", "X", "Y", "Z"
        };

        /// <summary>
        /// 可用月份
        /// </summary>
        public static List<string> Month = new List<string>
        {
            "5", "6", "7", "8", "9",
            "A", "B", "C"
        };

        /// <summary>
        /// 最大编号
        /// </summary>
        public static int MAX = 9999;
    }
}
