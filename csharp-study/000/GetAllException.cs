using System; 

namespace StudyKit
{
	class Program
	{
		static void Main(string[] args)
		{
			try {
				// throw new ApplicationException();
				throw new Exception();
			} catch (Exception) {
				Console.WriteLine("Get a exception");
			}
		}
	}
}
