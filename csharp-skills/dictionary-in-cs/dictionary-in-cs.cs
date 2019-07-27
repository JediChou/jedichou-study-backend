using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryInCSharp
{
	class Student
	{
		public int StudentId { get; set; }
		public string StudentName { get; set; }
		public string Gender { get; set; }
		public double TotalMarks { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			var sOne   = new Student {StudentId=201, StudentName="Adiden Pearce",Gender="Male",  TotalMarks=455.50};
			var sTwo   = new Student {StudentId=202, StudentName="Lara Croft",   Gender="Female",TotalMarks = 455.50 };  
        	var sThree = new Student {StudentId=203, StudentName="Black Widow",  Gender="Female",TotalMarks = 342 };  
        	var sFour  = new Student {StudentId=204, StudentName="Sam Fisher",   Gender="Male",  TotalMarks = 550.12 };  
        	var sFive  = new Student {StudentId=205, StudentName="Max Payne",    Gender="Male",  TotalMarks = 288.50 }; 

			var studentDictionary = new Dictionary<int, Student>();
			studentDictionary.Add(sOne.StudentId, sOne);
			studentDictionary.Add(sTwo.StudentId, sTwo);
			studentDictionary.Add(sThree.StudentId, sThree);
			studentDictionary.Add(sFour.StudentId, sFour);
			studentDictionary.Add(sFive.StudentId, sFive);

			// unique id
			if( studentDictionary.ContainsKey(sFive.StudentId) )
				Console.WriteLine("The key {0} already exists.", string.Concat(sFive.StudentId));
			else
				studentDictionary.Add(sFive.StudentId, sFive);

			// get a value with null key
			var s = new Student();
			if( studentDictionary.TryGetValue(2220, out s))
				Console.WriteLine("Student Name is {0}", string.Concat(s.StudentName));
			else
				Console.WriteLine("Invalid key");

			// count property
			Console.WriteLine("The total number is {0}", studentDictionary.Count);

			// count method
			var totalItem = studentDictionary.Count(x => x.Value.TotalMarks > 400);
			Console.WriteLine("The number is {0} (TotalMarks>400).", totalItem);

			// remove method
			// studentDictionary.Remove(sOne.StudentId);
			
			// clear method
			// studentDictionary.Clear();

			// Output
			foreach(KeyValuePair<int, Student> student in studentDictionary)
			{
				var tempStudent = student.Value;
				Console.WriteLine(student.Key + " " + tempStudent.StudentName);
			}
		}
	}
}
