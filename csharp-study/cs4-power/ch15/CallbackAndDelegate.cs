// File name: CallbackAndDelegate.cs
// Description: callback with delegate in a normal application
// Reference: C# 4.0 The Definetive Guide

namespace ProgrammingCSharp
{
	using System;
	
	/// <summary>
	/// Delegate - Echo message after print job complete
	/// </summary>
	/// <param name="message">message</param>
	public delegate void PrintCompleteCallback(string message);
	
	/// <summary>
	/// Worker
	/// <summary>
	class Worker
	{
		Printer printer1, printer2, printer3;
		
		public void DoWork()
		{
			printer1 = new Printer("1st Printer");
			printer2 = new Printer("2nd Printer");
			printer3 = new Printer("3rd Printer");
			
			// use delegate
			PrintCompleteCallback callback = new PrintCompleteCallback(Printer.Notify);
			printer1.Print(callback);
			printer2.Print(callback);
			printer3.Print(callback);
		}
		
		public static void Main()
		{
			var worker = new Worker();
			worker.DoWork();
		}
	}
	
	/// <summary>
	/// Printer
	/// </summary>
	class Printer
	{
		private string _name;
		public Printer(string name)
		{
			_name = name;
		}
		
		public void Print(PrintCompleteCallback callback)
		{
			callback(string.Format("{0} - job complete", _name));
		}
		
		public static void Notify(string message)
		{
			Console.WriteLine(message);
		}
	}
}