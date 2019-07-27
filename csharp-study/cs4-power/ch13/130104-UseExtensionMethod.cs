// C#与.NET4高级编程（第五版）
// 13.1.4 扩展方法

using System;
using System.Reflection;
using System.Security.Permissions;

namespace MyExtensions {
    
    static class ObjectExtensions {
        public static void DisplayDefiningAssembly(this object obj) {
            Console.WriteLine(
                 "{0} lives here: -> {1}",
                 obj.GetType().Name,
                 Assembly.GetAssembly(obj.GetType())  
            );
        }
    }
    
    class Program {
        static void Main() {
            int myInt = 1234567;
            myInt.DisplayDefiningAssembly();
            
            var d = new System.Data.DataSet();
            d.DisplayDefiningAssembly();
        }
    }
}