using System;
using System.Text;

namespace Ch09_PG_176
{
  // Base Class
  public class MyBaseClass
  {
    public MyBaseClass()
    {
      Console.WriteLine(" Method - MyBaseClass() ");
    }

    public MyBaseClass(int i) 
    {
      Console.WriteLine(" Method - MyBaseClass(int i) ");
    }
  }

  // Sub Class
  public class MyDerivedClass : MyBaseClass
  {
    public MyDerivedClass()
    {
      Console.WriteLine(" Method - MyDerivedClass() ");
    }

    public MyDerivedClass(int i)
    {
      Console.WriteLine(" Method - MyDerivedClass(int i) ");
    }

    public MyDerivedClass(int i, int j)
    {
      Console.WriteLine(" Method - MyDerivedClass(int i, int j) ");
    }

    public static void Main(string[] args)
    {
      MyDerivedClass myobj1 = new MyDerivedClass();
      Console.WriteLine("====================================");
      MyDerivedClass myobj2 = new MyDerivedClass(1);
      Console.WriteLine("====================================");
      MyDerivedClass myobj3 = new MyDerivedClass(1, 1);
    }
  }

}

