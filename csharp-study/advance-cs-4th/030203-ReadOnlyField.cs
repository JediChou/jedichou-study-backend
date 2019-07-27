// File name: 030203-ReadOnlyField.cs
// Create by Jedi at 2013.5.22 17:08 AM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 88
// Compile:
//   1. csc 030203-ReadOnlyField.cs
//   2. csc /target:exe /out:a.exe 030203-ReadOnlyField.cs

namespace Wrox.ProfessionalCSharp.ReadOnlyField
{
	using System;
	using System.Collections.Generic;
	
	// Create a Book class. It has a read only field.
	// We initialized it at static constructor method.
	public class Book {
		public static readonly string publisher;
		public string Bookname;
		public string ISBN;

		static Book() { publisher = "Microsoft Press"; } 
		
		public Book(string Bookname, string ISBN) {
			this.Bookname = Bookname;
			this.ISBN = ISBN;
		}
		
		public string getDescription() {
			return Book.publisher + ", " +
			       this.Bookname + ", " +
				   this.ISBN;
		}
	}
	
	// Execute from this line.
	public class testReadOnlyField {
		public static void Main(string[] args) {
			Book bk1 = new Book("史記", "978-7-101-05563-4");
			Book bk2 = new Book("MINITAB統計分析教程", "978-7-121-4153-2");
			Book bk3 = new Book("數學與猜想 Vol-1", "7-03-009110-8");
			
			List<Book> bklist = new List<Book>();
			bklist.Add(bk1); bklist.Add(bk2); bklist.Add(bk3);
			
			foreach(Book elt in bklist) {
				Console.WriteLine(elt.getDescription());
			}
			
			Console.ReadLine();
		}
	}
}
