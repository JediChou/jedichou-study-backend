using SplitSheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using NPOI.HSSF.UserModel;

namespace SplitSheetTest
{
    [TestClass]
    public class GetFirstSheetTest
    {
        private readonly string testfile = AppDomain.CurrentDomain.BaseDirectory + "\\" + "GetFirstSheetTest.xls";

        [TestInitialize]
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

        [TestCleanup]
        public void MyTestCleanup()
        {
            if (File.Exists(testfile))
                File.Delete(testfile);
        }

        /// <summary>
        /// 测试临时文件生成
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetFirstSheetTest_CheckTempFileCreate()
        {
            Assert.IsTrue(File.Exists(testfile), "测试文件未生成");
        }

        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetFirstSheetTest_CheckCount()
        {
            var target = new frmMain_Accessor();
            var actual = target.GetFirstSheet(testfile);
            Assert.AreEqual(2, actual.Count);
        }

        /// <summary>
        /// 测试正常情况下获得的值
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetFirstSheetTest_Normal()
        {
            var target = new frmMain_Accessor();
            var actual = target.GetFirstSheet(testfile);
            Assert.AreEqual("workid", actual[0][0]);
            Assert.AreEqual("name", actual[0][1]);
            Assert.AreEqual("location", actual[0][2]);
            Assert.AreEqual("F3216338", actual[1][0]);
            Assert.AreEqual("Jedi", actual[1][1]);
            Assert.AreEqual("D13-4", actual[1][2]);
        }

        /// <summary>
        /// 测试文件为空的情况
        /// </summary>
        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetFirstSheetTest_FileDoesNotExists()
        {
            var target = new frmMain_Accessor();
            var actual = target.GetFirstSheet(testfile + "jedi.test");
            Assert.IsNull(actual);
        }

        [TestMethod]
        [DeploymentItem("SplitSheet.exe")]
        public void GetFirstSheetTest_SheetWithoutContent()
        {
            // 创建一个临时的workbook
            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet("Jedi");
            using (var fs = new FileStream(testfile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                workbook.Write(fs);

            var target = new frmMain_Accessor();
            var actual = target.GetFirstSheet(testfile);
            Assert.IsNull(actual);
        }
    }
}
