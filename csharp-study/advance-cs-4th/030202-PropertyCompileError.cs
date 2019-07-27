// File name: 030202-PropertyCompileError.cs
// Create by Jedi at 2013.4.17 13:45 PM
// Idea from <Profesional C#>, zhcn-4th, Page 82.

namespace Wrox.ProCSharp.PropertyCompileError
{
	class PropertyCompileError
	{
		// Will be pop a complied message.
		protected string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		// TODO: Complied error does not exists. 
		public static void Main() {}
	}
}
