using System; using System.Diagnostics; class Class1{}; class Program { private Class1 c1 = new Class1();
public static void Main(){var ai = new Program(); var timer = new Stopwatch();
timer.Start(); for(int i=0;i<10000;i++) ai.DoSomething1(); timer.Stop();
var micro = timer.Elapsed.Ticks/10m; Console.Write("runtime-is {0:F1}\n",micro);
timer = new Stopwatch();timer.Start(); for(int i=0;i<10000;i++) ai.DoSomething2(); timer.Stop();
 micro = timer.Elapsed.Ticks/10m; Console.Write("runtime-as {0:F1}\n",micro);
} public void DoSomething1(){object c2=c1; if(c2 is Class1){Class1 c=(Class1)c2;}
} public void DoSomething2(){object c2=c1; Class1 c=c2 as Class1; if(c!=null){/*other*/}}}
