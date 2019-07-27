class B{public B(){System.Console.Write("base construct\n");}}
class C:B{public C(){System.Console.Write("child construct\n");}}
class P{static void Main(){new C();}}
