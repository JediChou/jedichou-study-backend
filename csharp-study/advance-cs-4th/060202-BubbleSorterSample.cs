namespace Wrox.ProCSharp.BubbleSorterSample
{
	using System;

	class BubbleSorter
	{
		// Define a Bubble Sort method
		static public void Sort(object[] sortArray, CompareOp getMethod)
		{
			for(int i=0; i<sortArray.Length; i++)
			{
				for(int j=i+1; j<sortArray.Length; j++)
				{
					if (getMethod(sortArray[j], sortArray[i]))
					{
						object temp = sortArray[i];
						sortArray[i] = sortArray[j];
						sortArray[j] = temp;
					}
				}
			}
		}
	}

	public class Employee
	{
		private string name;
		private decimal salary;

		public Employee(string name, decimal salary)
		{
			this.name = name;
			this.salary = salary;
		}

		public override string ToString()
		{
			return string.Format(name + ",{0:C}", salary);
		}

		public static bool RhsIsGreater(object lhs, object rhs)
		{
			Employee empLhs = (Employee)lhs;
			Employee empRhs = (Employee)rhs;
			return (empRhs.salary > empLhs.salary) ? true : false;
		}
	}

	delegate bool CompareOp(object lhs, object rhs);

	class Program
	{
		static void Main()
		{
			var employees = new Employee [] {
				new Employee("Bugs Bunny", 20000),
				new Employee("Elemer Fudd", 10000),
				new Employee("Daffy Duck", 25000),
				new Employee("Wiley Coyote", (decimal)1000000.38),
				new Employee("Foghorn Leghorn", 23000),
				new Employee("RoadRunner", 50000)
			};

			var employeeCompareOp = new CompareOp(Employee.RhsIsGreater);
			BubbleSorter.Sort(employees, employeeCompareOp);

			foreach(var item in employees)
				Console.WriteLine(item.ToString());
		}
	}

}
