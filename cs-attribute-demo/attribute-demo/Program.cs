namespace attribute_demo
{
    using System;
    using System.Linq;

    public class Program
    {
        private static void Main()
        {
            #region 有特定属性的类

            var t = new Article();
            var attrs = t.GetType().GetCustomAttributes(true);
            foreach (Attribute attr in attrs)
                Console.WriteLine(attr);

            #endregion

            #region 有特定属性的方法

            var m = new RunnableClass();
            var specialMethod = m.GetType().GetMethods()
                .Where(g => g.GetCustomAttributes(typeof(Runnable), false).Length > 0)
                .ToArray();
            var methodName = specialMethod[0].Name;

            m.GetType().GetMethod(methodName)?.Invoke(m, new object[] {"fuck Bad news"});
            m.GetType().GetMethod(methodName)?.Invoke(m, new object[] {"fuck Bas"});

            #endregion

            Console.ReadLine();
        }
    }

    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class Author : Attribute
    {
        private readonly string _name;
        public double Version;
        
        public Author(string name)
        {
            _name = name;
            Version = 1.0;
        }
    }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Struct)]
    public class Runnable : Attribute
    {
        public string Name { get; set; }
        public string Version { get; set; }

        public Runnable(string name, string version)
        {
            Name = name;
            Version = version;
        }

        public Runnable(string name)
        {
            Name = name;
            Version = string.Empty;
        }
    }

    [Author("P. Ackerman", Version = 1.2)]
    class Article { }

    [Author("Jedi Chou", Version = 1.1)]
    internal class RunnableClass
    {
        [Runnable("Can", "1.2.3")]
        public static void Println(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
