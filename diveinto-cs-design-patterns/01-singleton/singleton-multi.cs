using System;

namespace SingletonExampleMulti
{
	public class Singleton {
		private static volatile Singleton instance;
		private static object lockHelp = new Object();
		private Singleton() {}
		public static Singleton Instance {
			get {
				if ( instance == null )
					lock (lockHelp)
						if (instance == null)
							instance = new Singleton();
				return instance;
			}
		}
	}

	public class Program {
		static void Main() {
			var ston1 = Singleton.Instance;
			var ston2 = Singleton.Instance;
			
			Console.WriteLine(ston1);
			Console.WriteLine(ston2);
		
			Console.WriteLine(
				"Object.ReferenceEquals(ston1, ston2) is : {0}", 
				Object.ReferenceEquals(ston1, ston2) == true
			);
		}
	}

}
