using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ADONetStudy
{
    /// <summary>
    /// 学习《ADO.NET4从入门到精通》
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            # region 创建DataTable
            //DataTable unnamedTable = new DataTable();
            //DataTable namedTable = new DataTable("Customer");
            #endregion

            #region 向DataTable中添加栏位
            //DataTable customer = new DataTable("Customer");
            //customer.Columns.Add("ID", typeof(long));
            //customer.Columns.Add("FullName", typeof(string));
            //if (customer.Columns.Count != 0)
            //{
            //    foreach (var col in customer.Columns)
            //    {
            //        string value = col.ToString();
            //        string type = col.GetType().ToString();
            //        string result = string.Format("col:{0}, type:{1}", value, type);
            //        Console.WriteLine(result);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Something error !");
            //}
            #endregion

            #region 指定DataTable中的主键

            //// 定义
            //DataTable dt = new DataTable("customer");

            //// 增加栏位
            //dt.Columns.Add("ID", typeof(long));
            //dt.Columns.Add("FullName", typeof(string));
            //dt.Columns.Add("LastOrderDate", typeof(DateTime));
            
            //// 指定主键
            //dt.PrimaryKey = new DataColumn[]{dt.Columns["ID"]};

            //// 输出
            //foreach (DataColumn col in dt.Columns)
            //{
            //    string colName = col.ColumnName;
            //    string colType = col.DataType.ToString();
            //    bool isPrimaryKey = (dt.PrimaryKey != null) && (dt.PrimaryKey.Contains(col) == true);
            //    string output = isPrimaryKey ?
            //        string.Format("column name: {0}, column type: {1}, primary key: {2}", colName, colType, isPrimaryKey) :
            //        string.Format("column name: {0}, column type: {1}", colName, colType);
            //    Console.WriteLine(output);
            //}
            
            #endregion

            #region 3.1.1 创建新行

            //DataTable dt = new DataTable("Customer");
            //dt.Columns.Add("ID", typeof(string));
            //dt.Columns.Add("FirstName", typeof(string));
            //dt.Columns.Add("LastName", typeof(string));
            
            //DataRow oneRow = dt.NewRow();
            //DataRow twoRow = dt.NewRow();
            
            //Console.WriteLine(dt.Rows.Count);

            #endregion

            #region 3.1.2 定义行值

            //DataTable dt = new DataTable("Customer");
            //dt.Columns.Add("ID", typeof(string));
            //dt.Columns.Add("Name", typeof(string));
            
            //DataRow oneRow = dt.NewRow();
            //oneRow["ID"] = "First";
            //oneRow["Name"] = "Jedi Chou";

            #endregion

            #region 3.1.3 在表中存储行 - 使用传统的Add方式

            //DataTable dt = new DataTable("Customer");
            //dt.Columns.Add("ID", typeof(string));
            //dt.Columns.Add("Name", typeof(string));

            //DataRow oneRow = dt.NewRow();
            //oneRow["ID"] = "First";
            //oneRow["Name"] = "Jedi Chou";
            //dt.Rows.Add(oneRow);

            //DataRow twoRow = dt.NewRow();
            //twoRow["ID"] = "Second";
            //twoRow["Name"] = "Becky Wu";
            //dt.Rows.Add(twoRow);

            //Console.WriteLine(dt);

            #endregion

            #region 3.1.3 在表中存储行 - 使用Add的重载

            //DataTable dt = new DataTable("Customer");
            //dt.Columns.Add("ID", typeof(int));
            //dt.Columns.Add("FirstName", typeof(string));
            //dt.Columns.Add("LastName", typeof(string));

            //dt.Rows.Add(new object[]{1, "Jedi", "Chou"});
            //dt.Rows.Add(new object[] { 2, "Becky", "Wu" });

            //Console.WriteLine();

            #endregion

            #region 3.2 查看和更改数据 (查看数据)

            //DataTable dt = new DataTable("Customer");
            //dt.Columns.Add("ID", typeof(int));
            //dt.Columns.Add("FirstName", typeof(string));
            //dt.Columns.Add("LastName", typeof(string));

            //dt.Rows.Add(new object[] { 1, "Jedi", "Chou" });
            //dt.Rows.Add(new object[] { 2, "Becky", "Wu" });
            //dt.Rows.Add(new object[] { 3, "CiCi", "Chou" });

            //// 遍历dt的row(即遍历dt里的行)
            //foreach (DataRow row in dt.Rows)
            //{
            //    // 进行转型并计算输出
            //    int id = Convert.ToInt32(row["ID"]);
            //    string firstName = Convert.ToString(row["FirstName"]);
            //    string lastName = Convert.ToString(row["LastName"]);
            //    string output = string.Format("ID: {0}, First Name: {1}, Last Name: {2}", id, firstName, lastName);
                
            //    // 输出
            //    Console.WriteLine(output);
            //}

            #endregion

            #region 3.2 查看和更改数据 (更改数据)

            //DataTable dt = new DataTable("Customer");
            //dt.Columns.Add("ID", typeof(int));
            //dt.Columns.Add("Name", typeof(string));
            //dt.PrimaryKey = new DataColumn[]{dt.Columns["ID"]};

            //dt.Rows.Add(new object[] { 1, "Sara" });
            //dt.Rows.Add(new object[] { 2, "Xin" });
            //dt.Rows.Add(new object[] { 3, "Miki" });

            //Console.WriteLine("Before modify: ");
            //foreach (DataRow row in dt.Rows)
            //{
            //    Console.WriteLine(string.Format("{0}, {1}", row["ID"], row["Name"]));
            //}

            //Console.WriteLine("After modify: ");
            //DataRow[] customerRow = dt.Select("ID = 1");
            //customerRow[0]["ID"] = 4;
            //customerRow[0]["Name"] = "Sarah";
            //foreach (DataRow row in dt.Rows)
            //{
            //    Console.WriteLine(string.Format("{0}, {1}", row["ID"], row["Name"]));
            //}

            #endregion

            #region 3.3 删除数据 (删除dt.Rows.Remove(row))

            //// 定义DataTable、栏位和主键
            //DataTable dt = new DataTable("Personal");
            //dt.Columns.Add("ID", typeof(int));
            //dt.Columns.Add("Name", typeof(string));
            //dt.Columns.Add("Sal", typeof(int));
            //dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };

            //// 增加数据
            //dt.Rows.Add(new object[] { 1, "Jedi", 3000});
            //dt.Rows.Add(new object[] { 2, "Kaja", 4000 });
            //dt.Rows.Add(new object[] { 3, "Lanchesty", 2000 });

            //// 删除前的输出
            //Console.WriteLine("Before Delete");
            //Console.WriteLine("=============");
            //foreach (DataRow row in dt.Rows)
            //{
            //    int id = Convert.ToInt32(row["ID"]);
            //    string name = Convert.ToString(row["Name"]);
            //    int salary = Convert.ToInt32(row["sal"]);
            //    string output = string.Format("ID:{0} Name:{1} Salary:{2}", id, name, salary);
            //    Console.WriteLine(output);
            //}
            //Console.WriteLine();

            //// 执行过滤并删除
            //DataRow[] filters = dt.Select("ID = 1");
            //// DataRow[] filters = dt.Select("ID NOT = 1");
            //// DataRow[] filters = dt.Select("Name LIKE = 'je'");
            //dt.Rows.Remove(filters[0]);

            //// 执行删除的输出
            //Console.WriteLine("After Delete");
            //Console.WriteLine("=============");
            //foreach (DataRow row in dt.Rows)
            //{
            //    int id = Convert.ToInt32(row["ID"]);
            //    string name = Convert.ToString(row["Name"]);
            //    int salary = Convert.ToInt32(row["sal"]);
            //    string output = string.Format("ID:{0} Name:{1} Salary:{2}", id, name, salary);
            //    Console.WriteLine(output);
            //}
            
            #endregion

            #region 3.3 删除数据 (删除dt.Rows.RemoteAt(number))

            //// 定义DT、栏位、主键
            //DataTable dt = new DataTable("OfficeTelephone");
            //dt.Columns.Add("ID", typeof(int));
            //dt.Columns.Add("number", typeof(string));
            //dt.Columns.Add("Owner", typeof(string));
            //dt.Columns.Add("OwnerId", typeof(string));
            //dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };

            //// 增加数据
            //dt.Rows.Add(new object[] { 1, "560-81296", "Jedi", "f3216338" });
            //dt.Rows.Add(new object[] { 2, "560-81172", "Ray", "f3219815" });
            //dt.Rows.Add(new object[] { 3, "560-81222", "Cambo", "13145" });

            //// 删除前的显示
            //Console.WriteLine("Before Delete");
            //Console.WriteLine("=============");
            //foreach (DataRow row in dt.Rows)
            //{
            //    int id = Convert.ToInt32(row["ID"]);
            //    string sTelephone = Convert.ToString(row["number"]);
            //    string sOwner = Convert.ToString(row["Owner"]);
            //    string sOwnerId = Convert.ToString(row["OwnerID"]);
            //    string output = string.Format(
            //        "ID:{0} Telephone:{1} Owner:{2} Owner ID:{3}",
            //        id, sTelephone, sOwner, sOwnerId
            //    );
            //    Console.WriteLine(output);
            //}
            //Console.WriteLine();

            //// 删除最后一条数据
            //dt.Rows.RemoveAt(dt.Rows.Count - 1);

            //// 删除后的显示
            //Console.WriteLine("After Delete");
            //Console.WriteLine("============");
            //foreach (DataRow row in dt.Rows)
            //{
            //    int id = Convert.ToInt32(row["ID"]);
            //    string sTelephone = Convert.ToString(row["number"]);
            //    string sOwner = Convert.ToString(row["Owner"]);
            //    string sOwnerId = Convert.ToString(row["OwnerID"]);
            //    string output = string.Format(
            //        "ID:{0} Telephone:{1} Owner:{2} Owner ID:{3}",
            //        id, sTelephone, sOwner, sOwnerId
            //    );
            //    Console.WriteLine(output);
            //}

            #endregion

            #region 3.3 删除数据 (删除所有数据)

            //DataTable dt = new DataTable("");
            //dt.Columns.Add("ID", typeof(int));
            //dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };

            //for (int i = 0; i < 50; i++)
            //    dt.Rows.Add(new object[] { i+10 });
            //Console.WriteLine("Before delete all rows 'dt.Rows.Count'={0}", dt.Rows.Count);
            
            //dt.Rows.Clear();
            //Console.WriteLine("After delete all rows 'dt.Rows.Count'={0}", dt.Rows.Count);

            #endregion

            #region 3.4.1 行状态

            // Jedi: 主要用于行编辑（编辑特定行，待确定后再进行变更）
            // Jedi: 每一行(ROW)都有一个DataRow.RowState属性
            //   DataRowState.Detached: 任何一个还没有添加到DataTable中的行的默认状态;
            //   DataRowState.Added: 在向一个表中添加了数据行，但还没有确认对标的更改时，这些行的状态就是DataRowState.Added;
            //   DataRowSate.Unchanged: 任何已经出现在表中的数据行，但在上次调用AcceptChanges后未做改变，其状态即为此。
            //     用NewRow方法创建的新行就是使用这一状态;
            //   DataRowState.Deleted: 在调用AcceptChanges之前，被删除的行实际上并没有从表中移除，而是用这一状态设置将其标记
            //     为删除状态。关于“已删除(deleted)行”和“已删除(removed)”是有区别的
            //   DataRowState.Modified: 任意一个数据行，只要采用任何方式更改了它的字段，都会将其标记为已删除。

            #endregion

            #region 3.4.1 行状态 (DataRowState.Detached)
            
            //// Tips: Jedi -> 不可以直接执行, DataRow使用了模式，必须调用一个DataRowBuilder
            //// DataRow row = new DataRow();

            //DataTable dt = new DataTable("Detached");
            //dt.Columns.Add("ID", typeof(int));

            //DataRow firstRecord = dt.NewRow();
            //DataRow secondRecord = dt.NewRow();
            //DataRow[] rows = new DataRow[] { firstRecord, secondRecord };

            //// 会显示状态为Detached
            //foreach (DataRow row in rows)
            //    Console.WriteLine(row.RowState);

            #endregion

            #region 3.4.1 行状态 (DataRowState.Added)

            //DataTable dt = new DataTable("Added");
            //dt.Columns.Add("ID", typeof(int));

            //DataRow firstRecord = dt.NewRow();
            //DataRow secondRecord = dt.NewRow();
            //DataRow[] rows = new DataRow[] { firstRecord, secondRecord };

            //dt.Rows.Add(firstRecord);
            //dt.Rows.Add(secondRecord);

            //// 会显示状态为Added
            //foreach (DataRow row in rows)
            //    Console.WriteLine(row.RowState);

            #endregion

            #region 3.4.1 行状态 (DataRowState.Unchanged)

            //DataTable dt = new DataTable("Unchanged");
            //dt.Columns.Add("ID", typeof(int));
            
            //DataRow dr = dt.NewRow();
            //dr["ID"] = 3;

            //dt.Rows.Add(dr);
            //dt.AcceptChanges();
            //Console.WriteLine(dr.RowState);

            #endregion

            #region 3.4.1 行状态 (DataRowState.Deleted)

            //DataTable dt = new DataTable("RowDeleted");
            //dt.Columns.Add("ID", typeof(string));
            //dt.Columns.Add("WorkID", typeof(string));
            //dt.Columns.Add("Name", typeof(string));
            //dt.Columns.Add("WorkArea", typeof(string));
            //dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };

            //object[] employees = new object[]
            //{ 
            //    new object[] { Guid.NewGuid().ToString(), "F3216338", "Jedi Chou", "Team leader" },
            //    new object[] { Guid.NewGuid().ToString(), "F3219815", "Ray Jiang", "Programmer"},
            //    new object[] { Guid.NewGuid().ToString(), "F3267777", "Xiaobin Lau", "Programmer"}
            //};

            //foreach (object[] emp in employees)
            //    dt.Rows.Add(emp);
            //dt.AcceptChanges();

            //foreach (DataRow row in dt.Rows)
            //{
            //    string iId = Convert.ToString(row["ID"]);
            //    string sWorkId = Convert.ToString(row["WorkID"]);
            //    string sName = Convert.ToString(row["Name"]);
            //    string sWorkArea = Convert.ToString(row["WorkArea"]);
            //    string sRowState = row.RowState.ToString();
            //    string output = string.Format(
            //        @"ID:{0} WorkID:{1} Name:{2} WorkArea:{3} -> RowState:{4}",
            //        iId, sWorkId, sName, sWorkArea, sRowState
            //    );
            //    Console.WriteLine(output);
            //}
            //Console.WriteLine();

            //// 执行删除，但只是做标记而已
            //int deleteRowId = dt.Rows.Count - 1;
            //dt.Rows[deleteRowId].Delete();
            //Console.WriteLine(dt.Rows.Count);
            //Console.WriteLine(dt.Rows[deleteRowId].RowState);

            //// 接受变更(防止“不能通过已删除的行访问该行的信息”)
            //dt.AcceptChanges();

            //// 删除后显示
            //Console.WriteLine("After special row execute delete method");
            //foreach (DataRow row in dt.Rows)
            //{
            //    string iId = Convert.ToString(row["ID"]);
            //    string sWorkId = Convert.ToString(row["WorkID"]);
            //    string sName = Convert.ToString(row["Name"]);
            //    string sWorkArea = Convert.ToString(row["WorkArea"]);
            //    string sRowState = row.RowState.ToString();
            //    string output = string.Format(
            //        @"ID:{0} WorkID:{1} Name:{2} WorkArea:{3} -> RowState:{4}",
            //        iId, sWorkId, sName, sWorkArea, sRowState
            //    );
            //    Console.WriteLine(output);
            //}

            #endregion

            #region 3.4.1 行状态 (DataRowState.Modified)

            DataTable dt = new DataTable("RowStateModified");
            dt.Columns.Add("ID", typeof(string));
            dt.Rows.Add(new object[] { "Jedi Chou" });
            dt.AcceptChanges();

            dt.Rows[0]["ID"] = "Ray";
            Console.WriteLine(dt.Rows[0].RowState);
            
            dt.AcceptChanges();
            Console.WriteLine(dt.Rows[0].RowState);

            #endregion

            #region 3.4.2 行版本

            // Jedi: 这个概念不是特别理解
            // DataRowVersion.Orginal: 更改之前的字段起始值（在最近使用AcceptChanges之后的值）;
            // DataRowVersion.Proposed: 已被更改但还没有确认的字段值;
            // 

            #endregion
        }
    }
}
