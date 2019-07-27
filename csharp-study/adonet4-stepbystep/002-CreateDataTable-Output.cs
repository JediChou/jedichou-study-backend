using System;
using System.Data;

/// <summary>
/// 创建DataTable对象
/// </summary>
public class CreateDataTable
{
	public static void Main()
	{
		// 创建无名称的DataTable对象
		var unnamedTable = new DataTable();

		// 创建带名称的DataTable对象
		var namedTable = new DataTable("Customer");

		// 输出
		Console.WriteLine("unnamedTable toString(): {0}", unnamedTable);
		Console.WriteLine("namedTable toString(): {0}", namedTable);
	}
}
