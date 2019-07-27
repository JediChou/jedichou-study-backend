using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
	public abstract class myClass
	{
		private string id = "";
		private string name = "";

		public string ID
		{
			get { return id; }
			set { id = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public abstract void ShowInfo();
	}

	public class DriveClass : myClass
	{
		public override void ShowInfo()
		{
			Console.WriteLine(ID + " " + Name);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			DriveClass mc = new DriveClass();
			// myClass mc = dc;
			mc.ID = "BH001";
			mc.Name = "TM";
			mc.ShowInfo();
		}
	}
}
