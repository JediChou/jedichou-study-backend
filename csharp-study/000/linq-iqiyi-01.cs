
namespace LinqExample01
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;

	class Program
	{
		static void Main(string[] args)
		{
			var students = new List<Student>
			{
				new Student {Name="Li", Scores=new List<int>{97,72,81,60}},
				new Student {Name="Naruto", Scores=new List<int>{75,84,91,39}},
				new Student {Name="Saski", Scores=new List<int>{88,94,65,85}},
				new Student {Name="Yiku", Scores=new List<int>{35,72,91,70}}
			};

			var scoreQuery = 
					from student in students
						from score in student.Scores
							where score > 80
							select new { Name = student.Name, score};

			foreach(var student in scoreQuery)
				Console.WriteLine(student.Name);
		}
	}

	class Student
	{
		public string Name {get; set;}
		public List<int> Scores {get; set;}
	}
}


