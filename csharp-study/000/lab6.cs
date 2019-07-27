namespace lab6
{
	using System;
	
	public class lab6
	{
		static void Main(string[] args)
		{
			// 实例化一个测试对象并输出
			mockobj testobj = new mockobj();
			Console.WriteLine("实例化之后：" + (testobj is Object).ToString());
			
			// 将该对象设置为null
			// 另外, null并非object, 这点要注意!
			testobj = null;
			Console.WriteLine("设成NULL后：" + (testobj is Object).ToString());
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
