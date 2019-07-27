using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using System.IO;

namespace SplitSheet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            txtMessage.Text = string.Format(
                "{0}\r\n{1}\r\n{2}\r\n",
                "1.只能处理Excel2003格式",
                "2.只处理第一个sheet",
                "3.sheet中不要有空行"
            );
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSelect.Text))
                btnSplit.Enabled = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (ofdSelect.ShowDialog() == DialogResult.OK)
                txtSelect.Text = ofdSelect.FileName;

            if (!string.IsNullOrEmpty(txtSelect.Text))
                btnSplit.Enabled = true;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////
            try
            {
                // 1. 判定是否為可處理的Excel文件
                if (!IsValidXls(txtSelect.Text))
                {
                    txtMessage.Text = "不是有效的Excel文件, 或文件正處於開啟狀態!";
                    return;
                }
                else
                {
                    txtMessage.Text = "是有效的Excel文件!";
                }

                // 2. 定义需要处理Excel用的局部变量
                var firstRowOriginal = GetFirstRow(txtSelect.Text); // 獲取第一個Sheet中的第一行內容
                var firstRowDistinct = Distinct(firstRowOriginal);  // 第一行内容去重复
                var sheetNums = firstRowDistinct.Count;             // 獲取要生成N個Sheet
                var firstRowDict = GetDictByCol(firstRowOriginal);  // 获取Title和Col的Dictionary, 后续依此删除sheet中的各列

                // 3. 定义需要处理导出Excel的局部变量
                var currentFilePath = Directory.GetParent((txtSelect.Text).ToString());
                var currentFileName = Path.GetFileNameWithoutExtension((txtSelect.Text));
                var outputFilePath = string.Format("{0}{1}{2}{3}", currentFilePath, "\\", currentFileName, "-split.xls");

                // 4. 複製N個Sheet[0], 到文件中
                if (File.Exists(outputFilePath)) File.Delete(outputFilePath);
                for (int i = 1; i < firstRowDistinct.Count; i++)
                {
                    // 4.1 获得最原始的sheet内容 (内容每次都从原文件中读一次)
                    var sheetname = firstRowDistinct[i];
                    var cuurentSheet = GetFirstSheet(txtSelect.Text);

                    // 4.2 获得当前sheetname在原始内容中出现的位置
                    var sheetnameLocation = GetLocation(firstRowOriginal, sheetname);

                    // 4.3 删除那些不应该有的元素
                    // 获得当前sheetname应该删除的哪些元素的位置
                    // 第1个元素是不能删除, 如果包含0索引则删除
                    // 正式删除前要做下排序, 从后面往前删除
                    var deleteList = GetDeleteLocation(sheetnameLocation, firstRowOriginal.Count);
                    if (deleteList.Contains(0))
                        deleteList.Remove(0);
                    deleteList.Sort();
                    deleteList.Reverse();

                    // 4.4 遍历删除sheetname中的元素
                    // 4.5 根據Dict中的內容刪除sheet中的列(從後向前刪除)
                    foreach (var row in cuurentSheet)
                        foreach (var index in deleteList)
                            row.RemoveAt(index);

                    // 4.6 将信息写入文件                
                    WriteASheetToXls(outputFilePath, cuurentSheet, sheetname);
                }

                // 5. 回显信息
                txtMessage.Text = "导出至: " + outputFilePath;
            }
            catch (Exception ex)
            {
                txtMessage.Text = "文件写入错误\r\n";
                txtMessage.Text += string.Format("\"{0}\"", ex.Message);
            }

            ////////////////////////////////////////////////////////////////////
        }

        #region HelpMethod

        /// <summary>
        /// 获得当前sheetname应删除的哪些元素的位置
        /// </summary>
        /// <param name="locationList">不能删除的索引位置列表</param>
        /// <param name="size">列表的原始长度</param>
        /// <returns>应删除的哪些元素的位置列表</returns>
        private List<int> GetDeleteLocation(List<int> locationList, int size)
        {
            // 获得原始的所有索引位置列表
            var list = new List<int>();
            for (int i = 0; i < size; i++)
                list.Add(i);

            // 将不能删除的索引提出掉
            foreach (var element in locationList)
                if (list.Contains(element))
                    list.Remove(element);

            return list;
        }

        /// <summary>
        /// 获得指定字符串的索引集合
        /// </summary>
        /// <param name="list">字符列表</param>
        /// <param name="str">指定字符串</param>
        /// <returns>索引集和</returns>
        private List<int> GetLocation(List<string> list, string str)
        {
            try
            {
                if (list != null && list.Count > 0 && !string.IsNullOrEmpty(str))
                {
                    var result = new List<int>();
                    for (int i = 0; i < list.Count; i++)
                        if (list[i] == str)
                            result.Add(i);
                    return result;
                }
                else
                {
                    return null;
                }
                
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 檢查文件是否為合法的xls文件
        /// </summary>
        /// <param name="filepath">文件路徑</param>
        /// <returns>是否有效</returns>
        private bool IsValidXls(string filepath)
        {
            try
            {
                if (!File.Exists(filepath)) return false;
                using (var fsr = File.OpenRead(filepath))
                {
                    var workbook = new HSSFWorkbook(fsr);
                }
                return true;
            }
            catch
            {
                return false;    
            }
        }

        /// <summary>
        /// 获得Excel的第一个Sheet的第一行内容
        /// </summary>
        /// <param name="filepath">文件路径</param>
        /// <returns>第一行内容的List</returns>
        private List<string> GetFirstRow(string filepath)
        {
            try
            {
                // 定义结果集合
                var result = new List<string>();
                
                // 读取文件并访问文件的第1个sheet的第1行, 最后遍历第1行的所有列
                // 然后将各列的内容放到结果集合中
                using (var fsr = File.OpenRead(filepath))
                {
                    var workbook = new HSSFWorkbook(fsr);
                    var sheet = workbook.GetSheetAt(0);
                    var row = sheet.GetRow(0);

                    for (int col = 0; col < row.LastCellNum; col++)
                    {
                        var cell = row.GetCell(col);
                        result.Add(cell.ToString());
                    }
                }

                // 返回结果集合
                return result;
            }
            catch (Exception ex)
            {
                // 如果出错则表示文件有错误, 或文档被打开等情形
                // 此时直接返回空集合
                return null;
            }
        }

        /// <summary>
        /// 将List中重复的内容去掉
        /// </summary>
        /// <param name="list">待处理的List</param>
        /// <returns>处理后的List</returns>
        private List<string> Distinct(List<string> list)
        {
            if (list != null && list.Count > 0)
            {
                var result = new List<string>();
                foreach (string item in list)
                    if (!result.Contains(item))
                        result.Add(item);
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将各Title及出现的栏位位置存放到一个Dictionary对象中
        /// </summary>
        /// <param name="list">包含所有Title的List</param>
        /// <returns>Dictionary对象含Title和栏位</returns>
        private Dictionary<string, List<int>> GetDictByCol(List<string> list)
        {
            var result = new Dictionary<string, List<int>>();
            
            if (list != null && list.Count > 0)
            {
                foreach (var str in Distinct(list))
                {
                    var indexList = GetIndexList(list, str);
                    result.Add(str, indexList);
                }
            }

            return result;
        }

        /// <summary>
        /// 获取特定字符串在List中的所有索引值
        /// </summary>
        /// <param name="list">在该字符串List中搜索</param>
        /// <param name="str">被搜索到字符串</param>
        /// <returns>包含所有索引值的List</returns>
        private List<int> GetIndexList(List<string> list, string str)
        {
            var result = new List<int>();
            
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i] == str)
                        result.Add(i);
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取指定Excel的第一个Sheet的所有信息
        /// </summary>
        /// <param name="filepath">指定Excel的文字</param>
        /// <returns>第一个信息的所有内容</returns>
        private List<List<string>> GetFirstSheet(string filepath)
        {
            List<List<string>> result = new List<List<string>>();

            try
            {
                using (var fsr = File.OpenRead(filepath))
                {
                    var workbook = new HSSFWorkbook(fsr);
                    var sheet = workbook.GetSheetAt(0);

                    for (int i = 0; i <= sheet.LastRowNum; i++)
                    {
                        var row = sheet.GetRow(i);
                        var templist = new List<string>();
                        for (int j = 0; j < row.LastCellNum; j++)
                        {
                            var cell = row.GetCell(j);
                            templist.Add(cell.ToString());
                        }
                        result.Add(templist);
                    }
                }

                return result;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 将数据写入到指定的Sheet
        /// </summary>
        /// <param name="listStr">数据列表</param>
        /// <param name="path">文件路径</param>
        /// <param name="sheetname">指定的sheet名称</param>
        private static void WriteASheetToXls(string filepath, List<List<string>> listStr, string sheetname)
        {
            // 定义后续需要用到的workbook
            HSSFWorkbook workbook;

            if (File.Exists(filepath))
            {
                // 如果文件存在, 则该文件中创建workbook的实例, 防止删除已存在的sheet
                using (var rfs = File.OpenRead(filepath))
                    workbook = new HSSFWorkbook(rfs);

                // 用workbook创建需要的sheet
                var sheet = workbook.CreateSheet(sheetname);
                var cellstyle = workbook.CreateCellStyle();
                cellstyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;

                // 遍历创建行
                for (int i = 0; i < listStr.Count; i++)
                {
                    // 使用指定的sheet创建行
                    // 并遍历创建单元格, 并向单元格中填充内容
                    var row = sheet.CreateRow(i);
                    for (int j = 0; j < listStr[i].Count; j++)
                    {
                        float temp;

                        if (float.TryParse(listStr[i][j], out temp))
                        {
                            var cell = row.CreateCell(j, NPOI.SS.UserModel.CellType.Numeric);
                            cell.CellStyle = cellstyle;
                            cell.SetCellValue(temp);
                        }
                        else
                        {
                            var cell = row.CreateCell(j, NPOI.SS.UserModel.CellType.String);
                            cell.CellStyle = cellstyle;
                            cell.SetCellValue(listStr[i][j]);
                        }
                    }
                }
                
                // 将创建好的workbook(含已指定的sheet), 写回到文件中
                using (var wfs = new FileStream(filepath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
                    workbook.Write(wfs);
            }
            else
            {
                // 创建一个全新的workbook实例
                workbook = new HSSFWorkbook();

                // 用workbook创建需要的sheet
                var sheet = workbook.CreateSheet(sheetname);
                var cellstyle = workbook.CreateCellStyle();
                cellstyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;

                // 遍历创建行
                for (int i = 0; i < listStr.Count; i++)
                {
                    var row = sheet.CreateRow(i);

                    // 使用指定的sheet创建行
                    // 并遍历创建单元格, 并向单元格中填充内容
                    for (int j = 0; j < listStr[i].Count; j++)
                    {
                        // row.CreateCell(j, NPOI.SS.UserModel.CellType.String).SetCellValue(listStr[i][j].ToString());

                        float temp;

                        if (float.TryParse(listStr[i][j], out temp))
                        {
                            var cell = row.CreateCell(j, NPOI.SS.UserModel.CellType.Numeric);
                            cell.CellStyle = cellstyle;
                            cell.SetCellValue(temp);
                        }
                        else
                        {
                            var cell = row.CreateCell(j, NPOI.SS.UserModel.CellType.String);
                            cell.CellStyle = cellstyle;
                            cell.SetCellValue(listStr[i][j]);
                        }
                    }
                }

                // 将创建好的workbook(含已指定的sheet), 写到新文件中
                using (var fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    workbook.Write(fs);
            }
        }

        #endregion
    }
}
