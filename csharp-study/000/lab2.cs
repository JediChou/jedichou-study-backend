using System;

namespace lab2 {
	public class lab2 {
		public static void Main(string[] args)
		{
			// <ʵ�������ƶ�>
			// Tips : Ҫʵ�������ƶ�, �������б�����ʼ��;
			
			var name = "Bugs Bunny";
			var age = 25;
			var isRabbit = true;
			
			Type nameType = name.GetType();
			Type ageType = age.GetType();
			Type isRabbitType = isRabbit.GetType();
			
			Console.WriteLine("name is type : " + nameType.ToString());
			Console.WriteLine("ageType is type : " + ageType.ToString());
			Console.WriteLine("isRabbit is type : " + isRabbitType.ToString());
		}
	}
}
