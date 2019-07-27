using SplitSheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using NPOI.HSSF.UserModel;
using System.Linq;
using System.Text;

namespace SplitSheetTest
{
    [TestClass()]
    public class GetFirstRowTest
    {
        private readonly string testfile = AppDomain.CurrentDomain.BaseDirectory + "\\" + "GetFirstRowTest.xls";

        [TestInitialize()]
        public void MyTestInitialize()
        {
            // 创建一个临时的workbook
            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet("Jedi");
            var first_row = sheet.CreateRow(0);
            var second_row = sheet.CreateRow(1);
            first_row.CreateCell(0, NPOI.SS.UserModel.CellType.String).SetCellValue("workid");
            first_row.CreateCell(1, NPOI.SS.UserModel.CellType.String).SetCellValue("name");
            first_row.CreateCell(2, NPOI.SS.UserModel.CellType.String).SetCellValue("location");
            second_row.CreateCell(0, NPOI.SS.UserModel.CellType.String).SetCellValue("F3216338");
            second_row.CreateCell(1, NPOI.SS.UserModel.CellType.String).SetCellValue("Jedi");
            second_row.CreateCell(2, NPOI.SS.UserModel.CellType.String).SetCellValue("D13-4");

            // 写入到文件
            using (var fs = new FileStream(testfile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                workbook.Write(fs);
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            if (File.Exists(testfile))
                File.Delete(testfile);
        }

        /// <summary>
        /// 测试临时文件生成
        /// </summary>
        [TestMethod()]
        [DeploymentItem("SplitSheet.exe")]
        public void GetFirstRowTest_CheckTempFileCreate()
        {
            Assert.IsTrue(File.Exists(testfile), "测试文件未生成");
        }

        /// <summary>
        /// 测试获得的第一行栏位信息的集合
        /// </summary>
        [TestMethod()]
        [DeploymentItem("SplitSheet.exe")]
        public void GetFirstRowTest_Check()
        {
            frmMain_Accessor target = new frmMain_Accessor();
            var filepath = testfile;
            var expected = new List<string> { "workid", "name", "location" };
            var actual = target.GetFirstRow(filepath);

            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], actual[i], "获得的栏位信息不匹配");
        }
    }
}
