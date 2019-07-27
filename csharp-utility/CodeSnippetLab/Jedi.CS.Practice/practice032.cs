// 建议32：总是优先考虑泛型
namespace CodeSnippetLab.Practice032
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 没有使用泛型的例子
    /// </summary>
    class MyList
    {
        int[] items;

        public MyList(int i)
        {
            items = new int[i];
        }

        public int this[int i]
        {
            get { return items[i]; }
            set { this.items[i] = value; }
        }

        public int Count
        {
            get { return items.Length; }
        }
    }

    /// <summary>
    /// 使用了泛型的例子
    /// </summary>
    /// <typeparam name="T">泛型类型</typeparam>
    class MyGenericList<T>
    {
        T[] items;

        public MyGenericList(int i)
        {
            items = new T[i];
        }

        public T this[int i]
        {
            get { return items[i]; }
            set { this.items[i] = value; }
        }

        public int Count
        {
            get { return this.items.Length; }
        }
    }

    /// <summary>
    /// 使用了泛型的测试例子
    /// </summary>
    class MyGenericListTest
    {
        public void ExecuteTest1()
        {
            var myglist = new MyGenericList<int>(10);
            myglist[0] = 2;
            myglist[1] = 3;
            for (int i = 0; i < myglist.Count; i++)
                Console.WriteLine(myglist[i]);
        }

        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public void ExecuteTest2()
        {
            var myglist = new MyGenericList<Student>(5);
            myglist[0] = new Student { Name = "Jedi", Age = 39 };
            myglist[1] = new Student { Name = "Becky", Age = 34 };
            for (int i = 0; i < myglist.Count; i++)
                if (myglist[i] != null) 
                    Console.WriteLine("{0} -> {1}", myglist[i].Name, myglist[i].Age);
        }
    }
}
