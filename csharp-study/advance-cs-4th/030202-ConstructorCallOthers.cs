// File name: 030202-ConstructorCallOthers.cs
// Create by Jedi at 2013.5.22 11:33 AM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 85
// Compile:
//   1. csc 030202-ConstructorCallOthers.cs
//   2. csc /target:exe /out:a.exe 030202-ConstructorCallOtherss.cs

namespace Wrox.ProfessionalCSharp.ConstructorCallOthers
{
	using System;
	using System.Collections.Generic;
	
	public class Mathematician {
		private string name;
		private int from;
		private int to;
		private string country;
		
		public Mathematician(string name, int from, int to) : this(name, from, to, "Chinese") {}
		public Mathematician(string name, int from, int to, string country) {
			this.name = name;
			this.from = from;
			this.to = to;
			this.country = country;
		}

		public string getFullDescription() {
			return this.name + ", " +
			       this.country + ", from " +
				   this.from + " to " +
				   this.to;
		}
	}
	
	// Execute from this line.
	public class CallConstructProtectedType {
		public static void Main(string[] args) {
			Mathematician firstMTC   = new Mathematician("Chen Jingrun", 1923, 1966, "Chinese");
			Mathematician secondMTC  = new Mathematician("Hua Luogent", 1910, 1985, "Chinese");
			Mathematician thirdMTC   = new Mathematician("Ke Zhao", 1910, 2002);
			Mathematician fourthMTC  = new Mathematician("Su Buqing", 1902, 2003);
			
			List<Mathematician> list = new List<Mathematician>();
			list.Add(firstMTC);
			list.Add(secondMTC);
			list.Add(thirdMTC);
			list.Add(fourthMTC);
			
			for(int i=0; i < list.Count; i++) {
				Console.WriteLine(list[i].getFullDescription());
			}
		}
	}
}
