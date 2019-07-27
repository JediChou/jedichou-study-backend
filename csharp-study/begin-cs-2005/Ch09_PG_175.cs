// Filename	: Ch09_PG_175.cs
// Description	: How to use finalize method.

using System;
using System.Text;

namespace Ch09_PG_175
{
  public class SimpleClass
  {
    public SimpleClass() { Console.WriteLine("Method-SimpleClass()");}
    public SimpleClass(int i) { Console.WriteLine("Method-SimpleClass(int i)");}

    ~SimpleClass()
    {
      Console.WriteLine("Method-Finialize-~SimpleClass()");
    }

    public static void Main(string[] args)
    {
      SimpleClass myobj1 = new SimpleClass();
      // When program stop, the console will call finalize method.
    }

  }
}

