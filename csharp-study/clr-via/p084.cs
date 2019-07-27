// File name: p084.cs
// About: C#类型转换

namespace P084
{
	using System;
	using System.Data;

	// 该类型隐式派生自System.Object
	internal class Employee {
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}

	// 从Employee类型继承而来
	internal class Manager : Employee {
		public string Title { get; set; }
	}

	public sealed class Program {
		public static void Main() {
			// 构造一个Manager对象，把它传给PromoteEmployee,
			// Manager"属于" (IS-A) Employee，所以PromoteEmployee能
			// 成功运行
			var m = new Manager();
			PromoteEmployee(m);
		}

		public static void PromoteEmployee(object o) {
			Employee e = (Employee) o;
		}
	}
}
