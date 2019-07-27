using System;

namespace ConsoleApplication1
{
    struct Student
    {
        public int Age;
        public string Name;
        public string Level;
    }

    class Program
    {
        static void Main()
        {
            Student struct1;
            struct1.Age = 5;
            struct1.Name = "CiCi Chou";
            struct1.Level = "30";

            const int maxsize = 20;
            var arrStudent = new Student[maxsize];
            arrStudent[0] = struct1;

            Console.WriteLine(arrStudent[0].Age);
        }
    }
}
