// File Name: Ex110505.cs
// Description:
//   Add an iterator to People class. And you can use this
//   iterator to iterate element's age property. It likes:
//     foreach(int age in myPeople.Ages)
//     {
//         // Display ages.
//     }

namespace BeginCSharp_Ex110505
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Person class
    /// </summary>
    class Person
    {
        private string name;
        private int age;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public Person(string name, int age)
        {
            this.Name = name; this.Age = age;
        }

        // Execise answer. Operator overload.
        public static int operator +(Person p1, Person p2) { return p1.Age + p2.Age; }
        public static int operator -(Person p1, Person p2) { return p1.Age - p2.Age; }
        public static bool operator <(Person p1, Person p2) { return p1.Age < p2.Age; }
        public static bool operator >(Person p1, Person p2) { return p1.Age > p2.Age; }
        public static bool operator <=(Person p1, Person p2) { return p1.Age <= p2.Age; }
        public static bool operator >=(Person p1, Person p2) { return p1.Age >= p2.Age; }
    }

    /// <summary>
    /// Peple class
    /// </summary>
    class People
    {
        List<Person> list;

        public People()
        {
            list = new List<Person>();
        }

        public void Add(Person person)
        {
            list.Add(person);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            foreach(Person elt in list)
                yield return elt;
        }

        public IEnumerator<int> Ages()
        {
            foreach (Person elt in list)
                yield return elt.Age;
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            // Define
            var people = new People();
            people.Add(new Person("HaiHong", 40));
            people.Add(new Person("Jedi", 36));
            people.Add(new Person("WuZhou", 28));
            people.Add(new Person("DaPeng", 36));
            people.Add(new Person("ZhiQuan", 29));
            people.Add(new Person("NiXu", 23));
            people.Add(new Person("XinLiang", 22));
            people.Add(new Person("TanYan", 29));
            people.Add(new Person("FengQi", 24));
            people.Add(new Person("KeKe", 22));
            people.Add(new Person("XiongGang", 34));
            people.Add(new Person("XiaoXiao", 28));
            people.Add(new Person("LiuJian", 24));

            // Output
            //foreach (Person elt in people)
            //    Console.WriteLine("Name:{0}, Age:{1}", elt.Name, elt.Age);

            foreach (Person elt in people)
                Console.WriteLine(elt.Name);

            //foreach (int age in People.Ages)
            //    Console.WriteLine(age);

            Console.ReadLine();
        }
    }

}

