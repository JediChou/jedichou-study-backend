namespace lab6
{
	using System;
	
	public class lab6
	{
		static void Main(string[] args)
		{
			// ʵ����һ�����Զ������
			mockobj testobj = new mockobj();
			Console.WriteLine("ʵ����֮��" + (testobj is Object).ToString());
			
			// ���ö�������Ϊnull
			// ����, null����object, ���Ҫע��!
			testobj = null;
			Console.WriteLine("���NULL��" + (testobj is Object).ToString());
		}
	}

	// �����õ���
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
