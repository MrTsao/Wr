﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NPOI.XWPF;
using NPOI.XWPF.UserModel;
using NPOI.XWPF.Extractor;
using System.IO;

namespace SySoft
{
    public partial class PaperHandler : Form
    {
        private char formatType = 'A';
        public PaperHandler()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtFilePath.Text = "请选择导入文件！";
        }

        private void ReadDoc(string strFilePath)
        {
            string strFile = strFilePath.ToUpper();
            if (strFile.EndsWith(".DOCX") || strFile.EndsWith(".DOC"))
            {
                this.listBox1.Items.Clear();
                XWPFWordExtractor we = new XWPFWordExtractor(NPOI.POIXMLDocument.OpenPackage(strFile));
                NPOI.XWPF.UserModel.XWPFDocument pd = (NPOI.XWPF.UserModel.XWPFDocument)we.Document;
                IList<IBodyElement> ib = pd.BodyElements;
                for (int i = 0; i < ib.Count; i++)
                {
                    NPOI.XWPF.UserModel.XWPFParagraph docp = (NPOI.XWPF.UserModel.XWPFParagraph)ib[i];
                    if (docp.NumLevelText != null)
                    {
                        this.listBox1.Items.Add("" + docp.Text);
                    }
                    else
                    {
                        this.listBox1.Items.Add(docp.Text);
                    }
                }
                pd.Close();
                we.Close();
            }
            else
            {
                MessageBox.Show("当前不是WORD文档！");
            }
        }

        private void ReadTextA(string strFilePath)
        {
            string strFile = strFilePath.ToUpper();
            if (strFile.EndsWith(".TXT"))
            {
                this.listBox1.Items.Clear();
                StreamReader sr = new StreamReader(strFile, Encoding.Default);
                string strLine = "";
                string strCurrentType = "";
                bool isStart = false;
                bool isMerge = false;

                DataTable dtQuestion = new DataTable();
                dtQuestion.Columns.Add(new DataColumn("SEQ_NUM", Type.GetType("System.Int32")));
                dtQuestion.Columns.Add(new DataColumn("QUESTIONS_DESC", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("QUESTIONS_TYPE", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("OPTION_A", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("OPTION_B", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("OPTION_C", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("OPTION_D", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("ANSWER", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("ANALYSIS", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("ROWS", Type.GetType("System.Int32")));
                dtQuestion.Columns.Add(new DataColumn("Q_SEQ_NUM", Type.GetType("System.String")));
                this.dataGridView1.DataSource = dtQuestion;
                DataRow drNew = dtQuestion.NewRow();
                int i = 0, j = 0;
                this.tpBar.Value = 0;
                while ((strLine = sr.ReadLine()) != null)
                {
                    strLine = strLine.Replace("　", "");
                    i++;
                    this.listBox1.Items.Add(strLine);
                    if (strLine.Replace(" ", "") == string.Empty)
                    {
                        isStart = false;
                        if (!string.IsNullOrEmpty(drNew["QUESTIONS_DESC"].ToString()))
                        {
                            dtQuestion.Rows.Add(drNew);
                            drNew = dtQuestion.NewRow();
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (Regex.IsMatch(strLine, @"^\d+"))
                    {
                        isStart = true;
                        if (!string.IsNullOrEmpty(drNew["QUESTIONS_DESC"].ToString()))
                        {
                            dtQuestion.Rows.Add(drNew);
                            drNew = dtQuestion.NewRow();
                        }
                    }
                    if (!isStart)
                    {
                        if (strLine.Contains("单项选择题"))
                        {
                            strCurrentType = "单项选择题";
                        }
                        else if (strLine.Contains("多项选择题"))
                        {
                            strCurrentType = "多项选择题";
                        }
                        else if (strLine.Contains("判断题"))
                        {
                            strCurrentType = "判断题";
                        }
                        else if (strLine.Contains("不定项选择题"))
                        {
                            strCurrentType = "不定项选择题";
                        }
                        if (strCurrentType == "")
                        {
                            continue;
                        }
                        else
                        {
                            Regex regx = new Regex(@"^\d{1}");
                            if (regx.IsMatch(strLine))
                            {
                                isStart = true;
                            }
                        }
                    }
                    if (isStart)
                    {
                        if (string.IsNullOrEmpty(drNew["QUESTIONS_DESC"].ToString()))
                        {
                            drNew["SEQ_NUM"] = ++j;
                            strLine = Regex.Replace(strLine, @"^\d+", "").Trim();
                            strLine = Regex.Replace(strLine, @"^.", "").Trim();
                            strLine = Regex.Replace(strLine, @"^、", "").Trim();
                            drNew["QUESTIONS_DESC"] = strLine;
                            drNew["QUESTIONS_TYPE"] = strCurrentType;
                            drNew["ROWS"] = i;
                        }
                        else
                        {
                            if (strCurrentType == "判断题")
                            {
                                if (string.IsNullOrEmpty(drNew["ANSWER"].ToString()))
                                {
                                    if (strLine.Contains("【答案】"))
                                    {
                                        drNew["ANSWER"] = strLine.Replace("【答案】", "").Replace(" ", "");
                                    }
                                }
                                else if (string.IsNullOrEmpty(drNew["ANALYSIS"].ToString()))
                                {
                                    if (strLine.Contains("【解析】"))
                                    {
                                        drNew["ANALYSIS"] = strLine.Replace("【解析】", "").Replace(" ", "");
                                    }
                                }

                            }
                            else
                            {
                                if (string.IsNullOrEmpty(drNew["OPTION_A"].ToString()))
                                {
                                    if (strLine.Contains("  D"))
                                    {
                                        string strTmp = strLine.Substring(strLine.IndexOf("  D"));
                                        drNew["OPTION_D"] = GetFormatString(strTmp);
                                        strLine = strLine.Replace(strTmp, "");
                                        strTmp = strLine.Substring(strLine.IndexOf("  C"));
                                        drNew["OPTION_C"] = GetFormatString(strTmp);
                                        strLine = strLine.Replace(strTmp, "");
                                        strTmp = strLine.Substring(strLine.IndexOf("  B"));
                                        drNew["OPTION_B"] = GetFormatString(strTmp);
                                        strLine = strLine.Replace(strTmp, "");
                                        drNew["OPTION_A"] = GetFormatString(strLine);
                                    }
                                    else if (strLine.Contains("\tD"))
                                    {
                                        string strTmp = strLine.Substring(strLine.IndexOf("\tD"));
                                        drNew["OPTION_D"] = GetFormatString(strTmp);
                                        strLine = strLine.Replace(strTmp, "");

                                        if (strLine.IndexOf("\tC") > 0)
                                        {
                                            strTmp = strLine.Substring(strLine.IndexOf("\tC"));
                                        }
                                        else
                                        {
                                            strTmp = strLine.Substring(strLine.IndexOf("  C"));
                                        }

                                        drNew["OPTION_C"] = GetFormatString(strTmp);
                                        strLine = strLine.Replace(strTmp, "");
                                        if (strLine.IndexOf("\tB") > 0)
                                        {
                                            strTmp = strLine.Substring(strLine.IndexOf("\tB"));
                                        }
                                        else
                                        {
                                            strTmp = strLine.Substring(strLine.IndexOf("  B"));
                                        }
                                        drNew["OPTION_B"] = GetFormatString(strTmp);
                                        strLine = strLine.Replace(strTmp, "");
                                        drNew["OPTION_A"] = GetFormatString(strLine);
                                    }
                                    else if (strLine.Contains("  B"))
                                    {
                                        drNew["OPTION_A"] = GetFormatString(strLine.Substring(0, strLine.IndexOf("  B")));
                                        drNew["OPTION_B"] = GetFormatString(strLine.Substring(strLine.IndexOf("  B")));
                                    }
                                    else if (strLine.Contains("\tB"))
                                    {
                                        drNew["OPTION_A"] = GetFormatString(strLine.Substring(0, strLine.IndexOf("\tB")));
                                        drNew["OPTION_B"] = GetFormatString(strLine.Substring(strLine.IndexOf("\tB")));
                                    }
                                    else if (strLine.Contains("  C"))
                                    {
                                        drNew["OPTION_C"] = GetFormatString(strLine.Substring(strLine.IndexOf("  C")));
                                    }
                                    else if (strLine.Contains("\tC"))
                                    {
                                        drNew["OPTION_C"] = GetFormatString(strLine.Substring(strLine.IndexOf("\tC")));
                                    }
                                    else
                                    {
                                        drNew["OPTION_A"] = GetFormatString(strLine);
                                    }
                                }
                                else if (string.IsNullOrEmpty(drNew["OPTION_B"].ToString()))
                                {
                                    drNew["OPTION_B"] = GetFormatString(strLine);
                                }
                                else if (string.IsNullOrEmpty(drNew["OPTION_C"].ToString()))
                                {
                                    if (strLine.Contains("  D"))
                                    {
                                        drNew["OPTION_C"] = GetFormatString(strLine.Substring(0, strLine.IndexOf("  D")));
                                        drNew["OPTION_D"] = GetFormatString(strLine.Substring(strLine.IndexOf("  D")));
                                    }
                                    else if (strLine.Contains("\tD"))
                                    {
                                        drNew["OPTION_C"] = GetFormatString(strLine.Substring(0, strLine.IndexOf("\tD")));
                                        drNew["OPTION_D"] = GetFormatString(strLine.Substring(strLine.IndexOf("\tD")));
                                    }
                                    else
                                    {
                                        drNew["OPTION_C"] = GetFormatString(strLine);
                                    }
                                }
                                else if (string.IsNullOrEmpty(drNew["OPTION_D"].ToString()))
                                {
                                    drNew["OPTION_D"] = GetFormatString(strLine);
                                }
                                else if (string.IsNullOrEmpty(drNew["ANSWER"].ToString()))
                                {
                                    if (strLine.Contains("【答案】"))
                                    {
                                        drNew["ANSWER"] = strLine.Replace("【答案】", "").Replace(" ", "");
                                    }
                                }
                                else if (string.IsNullOrEmpty(drNew["ANALYSIS"].ToString()))
                                {
                                    if (strLine.Contains("【解析】"))
                                    {
                                        drNew["ANALYSIS"] = strLine.Replace("【解析】", "").Replace(" ", "");
                                    }
                                }
                                else
                                {
                                    drNew["ANALYSIS"] = drNew["ANALYSIS"].ToString() + "\n" + strLine;
                                }
                            }
                        }
                    }
                }
                dtQuestion.AcceptChanges();
                //this.dataGridView1.DataSource = dtQuestion;

                this.tpBar.Value = 100;
                sr.Close();
                sr.Dispose();
            }
        }

        private void preProcess(string strFilePath)
        {
            //string[] pathFile = Directory.GetFiles(path);
            string con = "";
            //foreach (string str in pathFile)
            //{
            FileStream fs = new FileStream(strFilePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            con = sr.ReadToEnd();
            con = con.Replace("\n\n", "").Replace("A.", "\nA.").Replace("B.", "\nB.").Replace("C.", "\nC.").Replace("D.", "\nD.");
            sr.Close();
            fs.Close();
            FileStream fs2 = new FileStream(strFilePath, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2, Encoding.UTF8);
            sw.WriteLine(con);
            sw.Close();
            fs2.Close();
            //}
            //MessageBox.Show("转换完成");
        }

        private void ReadTextB(string strFilePath)
        {
            preProcess(strFilePath);
            string strFile = strFilePath.ToUpper();
            if (strFile.EndsWith(".TXT"))
            {
                this.listBox1.Items.Clear();
                StreamReader sr = new StreamReader(strFile, Encoding.Default);
                string strLine = "";
                bool isStart = false;

                DataTable dtQuestion = new DataTable();
                dtQuestion.Columns.Add(new DataColumn("SEQ_NUM", Type.GetType("System.Int32")));
                dtQuestion.Columns.Add(new DataColumn("QUESTIONS_DESC", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("QUESTIONS_TYPE", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("OPTION_A", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("OPTION_B", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("OPTION_C", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("OPTION_D", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("ANSWER", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("ANALYSIS", Type.GetType("System.String")));
                dtQuestion.Columns.Add(new DataColumn("ROWS", Type.GetType("System.Int32")));
                dtQuestion.Columns.Add(new DataColumn("Q_SEQ_NUM", Type.GetType("System.String")));
                this.dataGridView1.DataSource = dtQuestion;
                DataRow drNew = dtQuestion.NewRow();
                this.tpBar.Value = 0;

                char ctype = ' ';
                Regex tirg = new Regex(@"^\d+\．");
                Regex oprg = new Regex(@"^[A-D]{1}\.");
                Regex opother = new Regex(@"^第 \d* 页");
                Regex opsl = new Regex(@"^版权所有");
                int i = 0, j = 0;
                while ((strLine = sr.ReadLine()) != null)
                {
                    strLine = strLine.Replace("　", "").Replace("\t", "").ToUpper().Trim();

                    if (opother.IsMatch(strLine)) { continue; }

                    if (opsl.IsMatch(strLine)) { continue; }

                    i++;
                    this.listBox1.Items.Add(strLine);
                    if (string.IsNullOrEmpty(strLine))
                        continue;

                    if (tirg.IsMatch(strLine))
                    {
                        string strQSeqNum = strLine.Substring(0, strLine.IndexOf("．"));
                        strLine = strLine.Substring((j + 1).ToString().Length + 1).Trim();
                        ctype = 'T';
                        if (!string.IsNullOrEmpty(drNew["QUESTIONS_DESC"].ToString()))
                        {
                            dtQuestion.Rows.Add(drNew);
                            drNew = dtQuestion.NewRow();
                        }
                        drNew["Q_SEQ_NUM"] = strQSeqNum;
                        drNew["SEQ_NUM"] = ++j;
                        drNew["ROWS"] = i;

                    }
                    if (oprg.IsMatch(strLine))
                    {
                        ctype = strLine.Substring(0, 1).ToUpper().ToCharArray()[0];
                    }
                    if (ctype == 'T')
                    {
                        drNew["QUESTIONS_DESC"] += strLine;
                    }
                    else if (ctype == 'A')
                    {
                        drNew["OPTION_A"] += strLine;
                    }
                    else if (ctype == 'B')
                    {
                        drNew["OPTION_B"] += strLine;
                    }
                    else if (ctype == 'C')
                    {
                        drNew["OPTION_C"] += strLine;
                    }
                    else if (ctype == 'D')
                    {
                        drNew["OPTION_D"] += strLine;
                    }
                }
                if (drNew != null)
                {
                    dtQuestion.Rows.Add(drNew);
                }
                dtQuestion.AcceptChanges();
                //this.dataGridView1.DataSource = dtQuestion;

                this.tpBar.Value = 100;
                sr.Close();
                sr.Dispose();
            }
        }

        private void ReadAnswers(string strFilePath)
        {
            DataTable dtQuestion = (DataTable)this.dataGridView1.DataSource;

            StreamReader sr = new StreamReader(strFilePath, Encoding.Default);
            string strLine;
            Regex tirg = new Regex(@"^\d+\.【");
            Regex opother = new Regex(@"^第\d*页");
            Regex opsl = new Regex(@"^版权所有");

            int i = 0;
            DataRow[] drs = null;
            while ((strLine = sr.ReadLine()) != null)
            {
                strLine = strLine.Replace("　", "").Replace("\t", "").ToUpper().Trim();

                if (opother.IsMatch(strLine)) { continue; }

                if (opsl.IsMatch(strLine)) { continue; }

                if (string.IsNullOrEmpty(strLine))
                    continue;

                if (tirg.IsMatch(strLine))
                {
                    string strSeqNum = strLine.Substring(0, strLine.IndexOf("."));
                    drs = dtQuestion.Select("Q_SEQ_NUM = '" + strSeqNum + "'");
                    if (drs.Length > 0)
                    {
                        int iStart = strLine.IndexOf("】") + 1;
                        int iEnd = strLine.IndexOf("。");
                        drs[0]["ANSWER"] = strLine.Substring(iStart, iEnd - iStart);
                        int iAnsi = strLine.IndexOf("解析：");
                        if (iAnsi > 0)
                        {
                            drs[0]["ANALYSIS"] = strLine.Substring(iAnsi);
                        }
                    }
                    else
                    {
                        drs = null;
                    }
                }
                else
                {

                    if (drs != null)
                    {
                        //dtQuestion.Rows[i]["ANSWER"] = strLine.Substring(strLine.IndexOf("】"), strLine.IndexOf("。"));
                        drs[0]["ANALYSIS"] += strLine;
                    }
                }
            }
            dtQuestion.AcceptChanges();
        }

        private string GetFormatString(string str)
        {
            str = str.Trim();
            bool isAdd = this.ckbOptionHead.Checked;
            if (str.StartsWith("A."))
            {
                str = (isAdd ? "A、" : "") + str.Substring(2).Replace(" ", "");
            }
            else if (str.StartsWith("A．"))
            {
                str = (isAdd ? "A、" : "") + str.Substring(2).Replace(" ", "");
            }
            else if (str.StartsWith("A、"))
            {
                return (!isAdd ? str.Replace("A、", "") : str);
            }
            else if (str.StartsWith("A"))
            {
                str = (isAdd ? "A、" : "") + str.Substring(1).Replace(" ", "");
            }
            else if (str.StartsWith("B."))
            {
                str = (isAdd ? "B、" : "") + str.Substring(2).Replace(" ", "");
            }
            else if (str.StartsWith("B．"))
            {
                str = (isAdd ? "B、" : "") + str.Substring(2).Replace(" ", "");
            }
            else if (str.StartsWith("B、"))
            {
                return (!isAdd ? str.Replace("B、", "") : str);
            }
            else if (str.StartsWith("B"))
            {
                str = (isAdd ? "B、" : "") + str.Substring(1).Replace(" ", "");
            }
            else if (str.StartsWith("C."))
            {
                str = (isAdd ? "C、" : "") + str.Substring(2).Replace(" ", "");
            }
            else if (str.StartsWith("C．"))
            {
                str = (isAdd ? "C、" : "") + str.Substring(2).Replace(" ", "");
            }
            else if (str.StartsWith("C、"))
            {
                return (!isAdd ? str.Replace("C、", "") : str);
            }
            else if (str.StartsWith("C"))
            {
                str = (isAdd ? "C、" : "") + str.Substring(1).Replace(" ", "");
            }
            else if (str.StartsWith("D."))
            {
                str = (isAdd ? "D、" : "") + str.Substring(2).Replace(" ", "");
            }
            else if (str.StartsWith("D．"))
            {
                str = (isAdd ? "D、" : "") + str.Substring(2).Replace(" ", "");
            }
            else if (str.StartsWith("D、"))
            {
                return (!isAdd ? str.Replace("D、", "") : str);
            }
            else if (str.StartsWith("D"))
            {
                str = (isAdd ? "D、" : "") + str.Substring(1).Replace(" ", "");
            }
            return str;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Windows.Forms.DataGridView dgv = (System.Windows.Forms.DataGridView)sender;
            int iRow;
            if (int.TryParse(dgv.CurrentRow.Cells[9].Value.ToString(), out iRow))
            {
                int iCurrent = iRow + 5;
                if (iCurrent > this.listBox1.Items.Count)
                {
                    iCurrent = this.listBox1.Items.Count - 1;
                }
                this.listBox1.SelectedIndex = iCurrent;
                this.listBox1.SelectedIndex = iRow - 1;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sflg = new SaveFileDialog();
            sflg.Filter = "Excel(*.xls)|*.xls|Excel(*.xlsx)|*.xlsx";
            if (sflg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            //this.gridView1.ExportToXls(sflg.FileName);
            //NPOI.xs book = new NPOI.HSSF.UserModel.HSSFWorkbook();
            NPOI.SS.UserModel.IWorkbook book = null;
            if (sflg.FilterIndex == 1)
            {
                book = new NPOI.HSSF.UserModel.HSSFWorkbook();
            }
            else
            {
                book = new NPOI.XSSF.UserModel.XSSFWorkbook();
            }

            NPOI.SS.UserModel.ISheet sheet = book.CreateSheet("test_001");

            // 添加表头
            NPOI.SS.UserModel.IRow row = sheet.CreateRow(0);
            int index = 0;
            foreach (DataGridViewColumn item in this.dataGridView1.Columns)
            {
                if (item.Visible)
                {
                    NPOI.SS.UserModel.ICell cell = row.CreateCell(index);
                    cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                    cell.SetCellValue(item.HeaderText);
                    index++;
                }
            }

            // 添加数据

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                index = 0;
                row = sheet.CreateRow(i + 1);
                foreach (DataGridViewColumn item in this.dataGridView1.Columns)
                {
                    if (item.Visible)
                    {
                        NPOI.SS.UserModel.ICell cell = row.CreateCell(index);
                        cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                        cell.SetCellValue(this.dataGridView1.Rows[i].Cells[index].Value.ToString());
                        index++;
                    }
                }
            }
            // 写入 
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            book.Write(ms);
            book = null;

            using (FileStream fs = new FileStream(sflg.FileName, FileMode.Create, FileAccess.Write))
            {
                byte[] data = ms.ToArray();
                fs.Write(data, 0, data.Length);
                fs.Flush();
            }

            ms.Close();
            ms.Dispose();
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text|*.txt";//|docx|*.docx|97-word|*.doc
            ofd.ShowDialog();
            this.txtFilePath.Text = ofd.FileName;
            string strFile = this.txtFilePath.Text.ToUpper();
            if (strFile.EndsWith(".DOCX") || strFile.EndsWith(".DOC"))
            {
                ReadDoc(strFile);
            }
            else if (strFile.EndsWith(".TXT"))
            {
                if (formatType == 'A')
                {
                    ReadTextA(strFile);
                }
                else if (formatType == 'B')
                {
                    ReadTextB(strFile);
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string strFile = this.txtFilePath.Text.ToUpper();
            if (strFile.EndsWith(".DOCX") || strFile.EndsWith(".DOC"))
            {
                ReadDoc(strFile);
            }
            else if (strFile.EndsWith(".TXT"))
            {
                if (formatType == 'A')
                {
                    ReadTextA(strFile);
                }
                else if (formatType == 'B')
                {
                    ReadTextB(strFile);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂未开发！");
        }

        private void MI_TYPE1_Click(object sender, EventArgs e)
        {
            this.MI_TYPE1.ForeColor = Color.Tan;
            this.MI_TYPE1.BackColor = Color.DarkSlateGray;
            this.MI_TYPE2.ForeColor = Color.Black;
            this.MI_TYPE2.BackColor = Color.Tan;
            formatType = 'A';
            ReadTextA(this.txtFilePath.Text.ToUpper());
        }

        private void MI_TYPE2_Click(object sender, EventArgs e)
        {
            this.MI_TYPE1.ForeColor = Color.Black;
            this.MI_TYPE1.BackColor = Color.Tan;
            this.MI_TYPE2.ForeColor = Color.Tan;
            this.MI_TYPE2.BackColor = Color.DarkSlateGray;
            formatType = 'B';
            ReadTextB(this.txtFilePath.Text.ToUpper());
        }

        private void mi_import_answer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text|*.txt";//|docx|*.docx|97-word|*.doc
            ofd.ShowDialog();
            string strFile = ofd.FileName.ToUpper();
            if (strFile.EndsWith(".TXT"))
            {
                if (formatType == 'B')
                {
                    ReadAnswers(strFile);
                }
            }
        }

    }
}
