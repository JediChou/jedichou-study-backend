using System;
using System.Linq;
using System.Reflection;

namespace CSLab.Study201502071355
{
    class StudyAnonymousTypes
    {
        /// <summary>
        /// A simplest method for anonymous types
        /// </summary>
        public static void SimpleUseAnonymousTypes()
        {
            // Reference url:https://msdn.microsoft.com/zh-cn/library/bb397696.aspx
            var v = new {Amount = 108, Message = "Hello"};
            Console.WriteLine(v.Amount);
            Console.WriteLine(v.Message);
        }

        /// <summary>
        /// Create a anonymous types collection, and use linq to
        /// filter object.
        /// </summary>
        public static void NormalUseAnonymousTypes()
        {
            // Reference url: https://msdn.microsoft.com/zh-cn/library/bb397696.aspx
            var phones = new[]
            {
                new {Name = "XiaoMi-3", Price = 1250},
                new {Name = "iPhone4", Price = 2500}, 
                new {Name = "iPhone5", Price = 3500},
                new {Name = "iPhone5s", Price = 4200}
            };

            var bestIPhone = from phone in phones
                             where phone.Price < 4000 && phone.Name.Contains("iPhone") 
                             select phone;

            foreach (var phone in bestIPhone)
                Console.WriteLine(phone);
        }
    }

    /// <summary>
    /// Return Anonymous Type in C#
    /// Reference URL: http://www.c-sharpcorner.com/UploadFile/pranayamr/return-anonymous-type-in-C-Sharp/
    /// Author: Pranay Rana (http://www.c-sharpcorner.com/authors/pranayamr/pranay-rana.aspx)
    /// </summary>
    class ReturnAnonymousType
    {
        public static void Execute()
        {
            var p = new ReturnAnonymousType();

            // Solution 1: Handle using Dynamic type 
            dynamic newtype = p.AnonymousReturn();
            Console.WriteLine("With Dynamic Type");
            Console.WriteLine(newtype.Name + " " + newtype.EmailID);
            Console.WriteLine();

            // Solution 2: Handle by creating the same anonymous type 
            Console.WriteLine("With Creation of same anonymous type");
            object o = p.AnonymousReturn();
            var obj = p.Cast(o, new {Name = "", EmailID = ""});
            Console.WriteLine(obj.Name + " " + obj.EmailID);
            // Console.WriteLine(obj.GetType().Name);  // Funing!
            Console.WriteLine();

            // Solution 3: Handle using Reflection
            Console.WriteLine("With Reflection");
            object refobj = p.AnonymousReturn();
            Type type = refobj.GetType();
            PropertyInfo[] fields = type.GetProperties();
            foreach (var field in fields)
            {
                string name = field.Name;
                var temp = field.GetValue(obj, null);
                Console.WriteLine(name + " " + temp);
            }
        }

        /// <summary>
        /// To understand each solution I created the following method that returns an anonymous type
        /// </summary>
        object AnonymousReturn()
        {
            return new { Name = "Jedi", EmailID = "skyzhx@163.com"};
        }

        /// <summary>
        /// Cast anonymous object to other object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        private T Cast<T>(object obj)
        {
            return Cast<T>(obj, default(T));
        }

        /// <summary>
        /// Cast anonymous object to other object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        T Cast<T>(object obj, T type)
        {
            return (T) obj;
        }

        /// <summary>
        /// I dont understand this code. It only create a object intances to accept
        /// anonymous object return.
        /// </summary>
        public static void Write()
        {
            var p = new ReturnAnonymousType();
            p.AnonymousReturn();
        }
    }
}
