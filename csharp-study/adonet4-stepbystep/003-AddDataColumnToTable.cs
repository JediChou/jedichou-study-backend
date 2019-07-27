using System;
using System.Data;

/// <summary>
/// 添加DataColumn对象到DataTable对象中的示例
/// </summary>
class AddDataColumnToTable
{
    static void Main(string[] args)
    {
        // 实例化一个DataTable对象, 实例化两个DataColumns对象
        var dt = new DataTable("Customer");
        var dl_id = new DataColumn("ID", typeof(long));
        var dl_tp = new DataColumn("Type", typeof(string));

        // 将两个DataColumn对象添加到DataTable的Columns属性中
        dt.Columns.Add(dl_id);
        dt.Columns.Add(dl_tp);

        // 分别输出DataTable和DataColumns对象的基本信息
        Console.WriteLine(dt);
        foreach(var col in dt.Columns)
            Console.WriteLine(".." + col);
    }
}