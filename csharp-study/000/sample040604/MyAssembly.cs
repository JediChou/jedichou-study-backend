using System.Diagnostics;
class Program {
	static void DisplayJITCounters() {
		PerformanceCounterCategory perfCategory
			= new PerformanceCounterCategory(".NET CLR Jit");
		PerformanceCounter[] perfCounters;
		perfCounters = perfCategory.GetCounters("MyAssembly");
		foreach(PerformanceCounter perfCounter in perfCounters)
			System.Console.WriteLine("{0}:{1}",
				perfCounter.CounterName,
				perfCounter.NextValue()
			);
	}
	static void f() {
		System.Console.WriteLine("---->Calling f().");
	}
	static void Main() {
		DisplayJITCounters();
		f();
		DisplayJITCounters();
	}
}
