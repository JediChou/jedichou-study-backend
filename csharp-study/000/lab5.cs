using System;

namespace lab5 {
	public class lab5 
	{
		public static void Main(string[] args)
		{
			/* 
				<值类型 和 引用类型>
				=====================
				Vector x, y;
				x = new Vector();
				x.Value = 30;  // Value is a field defined in Vector class
				y = x;
				Console.WriteLine(y.Value);
				y.Value = 50;
				Console.WriteLine(x.Value);
			*/
			
			// 以下代码模拟上述情况
			// 创建两个对象，并初始化其中一个
			mockobj obj1, obj2;
			obj1 = new mockobj();
			obj1.setValue("value1", 10);
			obj1.setValue("value2", 20);
			
			// 通过等号操作，将reference指向同一个
			obj2 = obj1;
			Console.WriteLine("==========");
			Console.WriteLine(obj2.value1);
			Console.WriteLine(obj2.value2);
			Console.WriteLine("==========");
			
			// 更改值，并将两个对象的字段输出
			obj2.setValue("value1", 11);
			obj2.setValue("value2", 21);
			Console.WriteLine("obj1.value1 is " + obj1.value1);
			Console.WriteLine("obj1.value2 is " + obj1.value2);
			Console.WriteLine("obj2.value1 is " + obj2.value1);
			Console.WriteLine("obj2.value2 is " + obj2.value2);
			
			// 进行对象相等性测试
			if (obj1 == obj2)
				Console.WriteLine("Object is same");
			else
				Console.WriteLine("Object is not same");
		}
	}
	
	// 测试用的类
	class mockobj
	{
		public int value1;
		public int value2;
		
		public mockobj()
		{
			this.value1 = 0;
			this.value2 = 0;
		}
		
		public void setValue(string name, int value)
		{
			if ( name == "value1" )
				this.value1 = value;
			else
				this.value2 = value;
		}
	}
}
