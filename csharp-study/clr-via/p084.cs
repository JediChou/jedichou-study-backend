// File name: p084.cs
// About: C#����ת��

namespace P084
{
	using System;
	using System.Data;

	// ��������ʽ������System.Object
	internal class Employee {
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}

	// ��Employee���ͼ̳ж���
	internal class Manager : Employee {
		public string Title { get; set; }
	}

	public sealed class Program {
		public static void Main() {
			// ����һ��Manager���󣬰�������PromoteEmployee,
			// Manager"����" (IS-A) Employee������PromoteEmployee��
			// �ɹ�����
			var m = new Manager();
			PromoteEmployee(m);
		}

		public static void PromoteEmployee(object o) {
			Employee e = (Employee) o;
		}
	}
}
