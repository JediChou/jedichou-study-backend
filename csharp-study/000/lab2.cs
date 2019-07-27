using System;

namespace lab2 {
	public class lab2 {
		public static void Main(string[] args)
		{
			// <实现类型推断>
			// Tips : 要实现类型推断, 则必须进行变量初始化;
			
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
