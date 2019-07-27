// Decompiled with JetBrains decompiler
// Type: JediDemo.Program
// Assembly: hello, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 967F6A52-7270-427E-92A3-AF1D1BBC7B02
// Assembly location: D:\temp\hello.exe
// Compiler-generated code is shown
// Metadata token values is shown
// IL code is shown in comments

using System;

namespace JediDemo
{
  /*Type Program with token 02000002*/
  // .class private auto ansi beforefieldinit 
    // JediDemo.Program
      // extends [mscorlib]System.Object
  // 
  internal class Program
  {
    /*Method .ctor with token 06000002*/
    // .method public hidebysig specialname rtspecialname instance void 
      // .ctor() cil managed 

    /*Method Main with token 06000001*/
    // .method public hidebysig static void 
      // Main(
        // string[] args
      // ) cil managed 
    public static void Main(/*Parameter with token 08000001*/string[] args)
    // .maxstack 8
    // 
    // IL_0000: nop          
    // IL_0001: ldstr        "abcd"
    // IL_0006: call         void [mscorlib]System.Console::WriteLine(string)
    // IL_000b: nop          
    // IL_000c: ret          
    // 
    {
      Console.WriteLine("abcd");
    }
  }
}
