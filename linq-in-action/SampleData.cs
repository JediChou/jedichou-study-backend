// 代码清单 4-1
// 提供示例数据的SampleData类

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinqInAction.LinqBooks.Common
{
    static public class SampleData
    {
        static public Publisher[] Publishers =
        {
            new Publisher {Name="FunBooks"},
            new Publisher {Name="Joe Publishing"},
            new Publisher {Name="I Publisher"}
        };
            
    }
}