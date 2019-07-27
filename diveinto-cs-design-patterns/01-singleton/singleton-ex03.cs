using System;

namespace SingletonExample03 {

	// Singleton mode simple style
	class Singleton_Simple	{
		public static readonly Singleton_Simple Instances = new Singleton_Simple();
		private Singleton_Simple() {}

		public int getInterger() { return 1;}
	}

	// Singleton mode comple style, it's effect same as simple style.
	// Good: do not fear multi-thread.
	// Badness: can not support constructor with many parameters.
	class Singleton_Complex {
		public static readonly Singleton_Complex Instances;
		static Singleton_Complex() {
			Instances = new Singleton_Complex();
		}
		private Singleton_Complex() {}
	}

	// Test function
	class Program {
		static void Main() {
			var ston_simple = Singleton_Simple.Instances;
			var ston_complex = Singleton_Complex.Instances;
			Console.WriteLine(ston_simple);
			Console.WriteLine(ston_complex);
		}
	}
}
