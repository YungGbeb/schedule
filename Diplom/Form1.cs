using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Data.Common;
using System.Resources;
using System.IO;

namespace Diplom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string path = "audspath.txt";
            FileInfo file = new FileInfo(path);
            if (!file.Exists)
            {
                System.IO.File.Create("audspath.txt");
            }
            InitializeComponent();
            string[] days = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
            string[] times = new string[] { "9:00-9:50", "10:00-10:50", "11:00-11:50", "12:20-13:10", "13:20-14:10", "14:20-15:10", "15:20-16:10", "16:20-17:10", 
                "17:20-18:10", "18:20-19:10", "19:20-20:10", "20:20-21:00" };
            dataGridView1.Columns.Add("day", "День");
            dataGridView1.Columns.Add("time", "Время");
            dataGridView2.Columns.Add("auditoria", "Аудитория");
            int j = 0;
            for (int i = 0; i < times.Length*6; i++)
            {
                dataGridView1.Rows.Add(" ", times[j]);
                j++;
                    if (j == times.Length) j = 0;
            }
            for (int i = 0; i < days.Length; i++)
            {
                dataGridView1[0, i * times.Length].Value = days[i];
            }
            int cnt = 0;
            foreach (string item in times)
            {
                dataGridView2.Columns.Add("time" + cnt, item);
                cnt++;
            }
            label2.Text = "false";
            dataGridView1.Focus();

            if (Properties.Resources.audspath.ToString().Length < 5)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.DefaultExt = "*.xls;*.xlsx";
                ofd.Filter = "Excel document(*.xlsx;*.xlsx)|*.xls;*.xlsx";
                ofd.Title = "Выберите документ для сохранения данных";
                ofd.ShowDialog();
                //Properties.Resources.audspath.Concat(ofd.FileName);
                StreamWriter sw = new StreamWriter("audspath.txt");
                sw.WriteLine(ofd.FileName.ToString());
                sw.Close();
                //Properties.Resources.audspath.Insert(0, ofd.FileName.ToString());
                //Console.WriteLine(ofd.FileName);

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cell1 = " ";
            string cell2 = " ";
            string cell3 = " ";
            string cell4 = " ";
            string cell5 = " ";
            if (teachers.SelectedValue != null)
            {  cell5 = teachers.SelectedValue.ToString(); }
            if (disciplines.SelectedItem != null)
            {
                cell1 = disciplines.Text;
            }
            if (teachers.SelectedItem != null)
            {
                cell2 = teachers.Text;
                //string[] cell_str = cell2.Split(' ');
                //cell_str[0] = cell_str[0] + " ";
                //cell_str[1] = cell_str[1].Remove(1)+". ";
                //cell_str[2] = cell_str[2].Remove(1)+".";
                //cell2 = "";
                //foreach (string item in cell_str)
                //{
                //    cell2 += item;
                //}
            }
            if (auditoria.SelectedItem != null)
            {
                cell3 = auditoria.Text;
            }
            if (lessonType.SelectedItem != null)
            {
                cell4 = lessonType.Text;
            }
            if (disciplines.SelectedItem != null && teachers.SelectedItem != null && auditoria.SelectedItem != null && lessonType.SelectedItem != null)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    cell.Value = cell1 + "\n" + cell4 + cell3 + "\n" + cell5 + " " + cell2;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cell1 = " ";
            string cell2 = " ";
            string cell3 = " ";
            string cell4 = " ";
            string cell5 = " ";
            if (teachers.SelectedValue != null)
            { cell5 = teachers.SelectedValue.ToString(); }
            if (disciplines.SelectedItem != null)
            {
                cell1 = disciplines.Text;
            }
            if (teachers.SelectedItem != null)
            {
                cell2 = teachers.Text;
                //string[] cell_str = cell2.Split(' ');
                //cell_str[0] = cell_str[0] + " ";
                //cell_str[1] = cell_str[1].Remove(1)+". ";
                //cell_str[2] = cell_str[2].Remove(1)+".";
                //cell2 = "";
                //foreach (string item in cell_str)
                //{
                //    cell2 += item;
                //}
            }
            if (auditoria.SelectedItem != null)
            {
                cell3 = auditoria.Text;
            }
            if (lessonType.SelectedItem != null)
            {
                cell4 = lessonType.Text;
            }
            if (disciplines.SelectedItem != null && teachers.SelectedItem != null && auditoria.SelectedItem != null && lessonType.SelectedItem != null)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    cell.Value = cell1 + "\n" + cell4 + cell3 + "\n" + cell5 + " " + cell2;
                }
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cell1 = " ";
            string cell2 = " ";
            string cell3 = " ";
            string cell4 = " ";
            string cell5 = " ";
            if (teachers.SelectedValue != null)
            { cell5 = teachers.SelectedValue.ToString(); }
            if (disciplines.SelectedItem != null)
            {
                cell1 = disciplines.Text;
            }
            if (teachers.SelectedItem != null)
            {
                cell2 = teachers.Text;
                //string[] cell_str = cell2.Split(' ');
                //cell_str[0] = cell_str[0] + " ";
                //cell_str[1] = cell_str[1].Remove(1)+". ";
                //cell_str[2] = cell_str[2].Remove(1)+".";
                //cell2 = "";
                //foreach (string item in cell_str)
                //{
                //    cell2 += item;
                //}
            }
            if (auditoria.SelectedItem != null)
            {
                cell3 = auditoria.Text;
            }
            if (lessonType.SelectedItem != null)
            {
                cell4 = lessonType.Text;
            }
            if (disciplines.SelectedItem != null && teachers.SelectedItem != null && auditoria.SelectedItem != null && lessonType.SelectedItem != null)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    cell.Value = cell1 + "\n" + cell4 + cell3 + "\n" + cell5 + " " + cell2;
                }
            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cell1 = " ";
            string cell2 = " ";
            string cell3 = " ";
            string cell4 = " ";
            string cell5 = " ";
            if (teachers.SelectedValue != null)
            { cell5 = teachers.SelectedValue.ToString(); }
            if (disciplines.SelectedItem != null)
            {
                cell1 = disciplines.Text;
            }
            if (teachers.SelectedItem != null)
            {
                cell2 = teachers.Text;
                //string[] cell_str = cell2.Split(' ');
                //cell_str[0] = cell_str[0] + " ";
                //cell_str[1] = cell_str[1].Remove(1)+". ";
                //cell_str[2] = cell_str[2].Remove(1)+".";
                //cell2 = "";
                //foreach (string item in cell_str)
                //{
                //    cell2 += item;
                //}
            }
            if (auditoria.SelectedItem != null)
            {
                cell3 = auditoria.Text;
            }
            if (lessonType.SelectedItem != null)
            {
                cell4 = lessonType.Text;
            }
            if (disciplines.SelectedItem != null && teachers.SelectedItem != null && auditoria.SelectedItem != null && lessonType.SelectedItem != null)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    cell.Value = cell1 + "\n" + cell4 + cell3 + "\n" + cell5 + " " + cell2;
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex < 2)
            {
                dataGridView1.CurrentCell = null;
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demo2DataSet.sotrudnik_fio_view". При необходимости она может быть перемещена или удалена.
            this.sotrudnik_fio_viewTableAdapter.Fill(this.demo2DataSet.sotrudnik_fio_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demo2DataSet.sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.demo2DataSet.sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demo2DataSet.disciplina". При необходимости она может быть перемещена или удалена.
            this.disciplinaTableAdapter.Fill(this.demo2DataSet.disciplina);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demo2DataSet.gruppa". При необходимости она может быть перемещена или удалена.
            this.gruppaTableAdapter.Fill(this.demo2DataSet.gruppa);
            this.discnkafTableAdapter.Fill(this.raspisanieDataSet.Discnkaf);
            this.kafsTableAdapter.Fill(this.raspisanieDataSet.kafs);
            this.auditoriesTableAdapter.Fill(this.raspisanieDataSet.auditories);
            this.teachersTableAdapter.Fill(this.raspisanieDataSet.teachers);
            this.disciplinesTableAdapter.Fill(this.raspisanieDataSet.disciplines);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Word.Application wordApp = new Word.Application();
            object start = 0;
            object end = 0;
            Word.Document wordDoc = new Word.Document();
            Word.Range tableLoc = wordDoc.Range(ref start, ref end);
            wordDoc.Tables.Add(tableLoc, dataGridView1.Rows.Count, dataGridView1.Columns.Count);
            Word.Table currentTable = wordDoc.Tables[1];
            currentTable.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            currentTable.Range.Font.Name = "Times New Roman";
            currentTable.Range.Font.Size = 11;
            currentTable.Rows.First.Range.Font.Size = 14;
            wordDoc.Range(0, 0).PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            currentTable.Columns[1].PreferredWidth = 60;
            currentTable.Columns[2].PreferredWidth = 60;
            currentTable.PreferredWidth = wordDoc.PageSetup.PageWidth - 60;
            currentTable.Range.Paragraphs.SpaceAfter = 0;
            currentTable.Range.Paragraphs.Space1();
            currentTable.Borders.Enable = 1;
            wordDoc.PageSetup.LeftMargin = 30;
            wordDoc.PageSetup.RightMargin = MaximumSize.Width;
            wordDoc.PageSetup.TopMargin = 30;
            wordDoc.PageSetup.BottomMargin = 30;
            wordApp.Visible = true;
            for (int p = 0; p < dataGridView1.Columns.Count; p++)
            {
                currentTable.Rows[1].Cells[p + 1].Range.Text = dataGridView1.Columns[p].HeaderText.ToString();
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Console.WriteLine(" i = " + i);
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    if (dataGridView1[j, i].Value == null)
                    {
                        Word.Cell cell = wordDoc.Tables[1].Cell(i + 1, j);
                    }
                    else
                    {
                        string cell = dataGridView1[j, i].Value.ToString();
                        cell = cell.Substring(0, cell.Length);
                        currentTable.Cell(i + 2, j + 1).Range.Text = cell;
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (drs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string[] days = new string[] { "Понедельник ", "Вторник ", "Среда ", "Четверг ", "Пятница ", "Суббота " };
                string[] times = new string[] { "9:00-9:50", "10:00-10:50", "11:00-11:50", "12:20-13:10", "13:20-14:10", "14:20-15:10", "15:20-16:10", "16:20-17:10", "17:20-18:10", "18:20-19:10", "19:20-20:10", "20:20-21:00" };
            Reset:
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.DefaultExt = "*.doc;*.docx";
                ofd.Filter = "Word document(*.doc;*.docx)|*.doc;*.docx";
                ofd.Title = "Выберите документ для загрузки данных";
                Word.Application app = new Word.Application();
                Word.Document doc;
                Console.WriteLine("a1");
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    label3.Text = ofd.FileName;
                    Console.WriteLine("a2");
                    doc = app.Documents.Open(ofd.FileName);
                    Console.WriteLine("a3");
                    Console.WriteLine(doc.Tables.Count);
                    if (doc.Tables.Count == 0)
                    {
                        Console.WriteLine("a3");
                        MessageBox.Show("Документ не содержит таблиц", "Ошибка");
                        goto Reset;
                    }
                    else
                    {
                        table.Items.Clear();
                        for (int i = 0; i < doc.Tables.Count; i++)
                        {
                            table.Items.Add(i + 1);
                            int j = 0;
                            Word.Table currentTable1 = doc.Tables[i + 1];
                            currentTable1.Columns[currentTable1.Columns.First.Index].Delete();
                            currentTable1.Columns.Add(currentTable1.Columns.First);
                            for (int u = 2; u < currentTable1.Rows.Count; u++)
                            {
                                if (j == times.Length) j = 0;
                                string currentTime = currentTable1.Rows[u].Cells[2].Range.Text;
                                currentTime = currentTime.Substring(0, currentTime.Length - 2);
                                currentTime = currentTime.Trim();
                                if (currentTime == times[j])
                                {
                                    Console.WriteLine("true" + currentTime + " " + times[j]);
                                    j++;
                                }
                                else
                                {
                                    Console.WriteLine("false " + currentTime + " " + times[j]);
                                    currentTable1.Rows.Add(currentTable1.Rows[u]);
                                    currentTable1.Rows[u].Cells[2].Range.Text = times[j];
                                    j++;
                                }

                            }
                            string LastTime = currentTable1.Rows[currentTable1.Rows.Count].Cells[2].Range.Text;
                            LastTime = LastTime.Substring(0, LastTime.Length - 2);
                            int LastTimeIndex = Array.FindIndex(times, time => time == LastTime) + 1;
                            int iter = times.Length - LastTimeIndex;
                            Console.WriteLine(LastTime + " " + LastTimeIndex + " " + times.Length);
                            if (LastTimeIndex != times.Length - 1)
                            {
                                for (int p = LastTimeIndex; p < iter + LastTimeIndex; p++)
                                {
                                    Console.WriteLine(p);
                                    currentTable1.Rows.Add();
                                    currentTable1.Rows[currentTable1.Rows.Count].Cells[2].Range.Text = times[p];
                                }
                            }
                        }
                        Console.WriteLine("a4");
                        dataGridView1.Columns.Clear();
                        dataGridView1.Columns.Add("days", "Дни");
                        Word.Table currentTable = doc.Tables[1];
                        int currentTableRows = currentTable.Rows.Count;
                        for (int y = 2; y < currentTable.Columns.Count + 1; y++)
                        {
                            string currentText = currentTable.Rows[1].Cells[y].Range.Text;
                            int x = currentText.Length - 1;
                            currentText = currentText.Substring(0, x);
                            dataGridView1.Columns.Add("column" + y, currentText);
                        }
                        int timeCount = 0;
                        for (int r = 2; r < currentTable.Rows.Count + 1; r++)
                        {
                            dataGridView1.Rows.Add();
                            for (int c = 2; c < currentTable.Columns.Count; c++)
                            {

                                string curText = currentTable.Rows[r].Cells[c].Range.Text;
                                int z = curText.Length - 1;
                                curText = curText.Substring(0, z);
                                curText = curText.Trim();
                                dataGridView1.Rows[r - 2].Cells[c - 1].Value = curText;
                            }
                         }
                        for (int a = 0; a < dataGridView1.Rows.Count; a++)
                        {
                            if (dataGridView1[1, a].Value.ToString().StartsWith(times[0]))
                            {
                                dataGridView1[0, a].Value = days[timeCount];
                                timeCount++;
                            }
                            else
                            {
                                dataGridView1[0, a].Value = " ";
                            }
                        }
                        Console.WriteLine("a5");
                        doc.Undo();
                        doc.Undo();
                        app.Quit(false);
                    }
                }
            } catch(Exception ex)
            {
                Console.WriteLine("something wrong" + ex);
                throw;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("audspath.txt");
            string line = sr.ReadLine();

            try
            {

            
                Excel.Application exApp = new Excel.Application();
                exApp.Workbooks.Open(line, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                Excel.Worksheet wsh = exApp.Worksheets[1];
                string[] audarray = new string[] { "404", "406", "407", "408", "409", "432", "433", "435", "414", "415", "417", "418", "420", "421", "425", "405", "249", "307", "210", "320", "338",
                    "329", "310", "311", "312", "330", "325", "305", "325а", "334", "327", "246", "1/401", "1/402", "1/403", "1/404", "1/409", "1/407", "1/419", "1/422", "1/423", "1/425", "1/109",
                    "1/413", "1/414", "1/428", "1/429", "1/430", "1/107", "107", "109", "149", "152", "243", "324", "326", "322", "321", "401", "318", "320", "118", "121", "122", "129", "131",
                    "1/203", "1/214", "1/309", "1/313", "1/408", "145", "1/312", "1/317", "1/320", "1/321", "1/322", "1/324", "1/325", "1/326", "1/313а", "1/311", "1/305", "1/308", "1/306",
                    "1/307", "1/201", "1/203", "1/204", "1/205", "1/206", "1/213", "1/214", "1/215", "1/216", "1/217", "1/218", "1/220", "1/221", "1/222", "1/105", "1/124", "1/203", "1/209",
                    "1/311"};
                for (int i = 2; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        if (dataGridView1[i, j].Value != null && dataGridView1[i, j].Value.ToString().Length >5)
                        {
                            string currentCell = dataGridView1[i, j].Value.ToString();
                            string[] currentCellArray = currentCell.Split('\n');
                            string[] LastcurrentCellArray = currentCellArray.Last().Split(' ');
                            string teacherstr = LastcurrentCellArray[LastcurrentCellArray.Length - 2] + " " + LastcurrentCellArray[LastcurrentCellArray.Length - 1];
                            teacherstr = teacherstr.Trim();
                            int result;
                            string resultString = string.Join(string.Empty, Regex.Matches(dataGridView1[i, j].Value.ToString().Trim(), @"\d+").OfType<Match>().Select(m => m.Value));
                            int.TryParse(resultString, out result);
                            string currentAud = result.ToString();
                            if (currentAud.Length > 3)
                            {
                                currentAud = currentAud.Insert(1, "/");
                            }
                            Console.WriteLine(currentAud + " aud");
                            int CurrentAudID = Array.FindIndex(audarray, item => item == currentAud);
                            if (wsh.Cells[CurrentAudID + 2, j + 2].Value != null && wsh.Cells[CurrentAudID + 2, j + 2].Value.ToString().Length > 3 && 
                                wsh.Cells[CurrentAudID + 2, j + 2].Value.ToString().Trim() != teacherstr.Trim())
                            { 
                                dataGridView1[i, j].Style.BackColor = Color.Red;
                            }
                            else
                            {
                                wsh.Cells[CurrentAudID + 2, j + 2].Value = teacherstr;
                                dataGridView1[i, j].Style.BackColor = Color.White;
                            }
                        }

                    }
                }
                exApp.ActiveWorkbook.Save();
                exApp.Quit();
                }
                catch (Exception)
                {
                }
            sr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName("excel");
            foreach (var item in proc)
            {
                item.Kill();
            }
            var proc1 = Process.GetProcessesByName("winword");
            foreach (var item in proc1)
            {
                item.Kill();
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] days = new string[] { "Понедельник ", "Вторник ", "Среда ", "Четверг ", "Пятница ", "Суббота " };
                string[] times = new string[] { "9:00-9:50", "10:00-10:50", "11:00-11:50", "12:20-13:10", "13:20-14:10", "14:20-15:10", "15:20-16:10", "16:20-17:10", "17:20-18:10", "18:20-19:10", "19:20-20:10", "20:20-21:00" };
                Word.Application app = new Word.Application();
                Word.Document doc;
                Console.WriteLine("a2");
                doc = app.Documents.Open(label3.Text, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value);
                Console.WriteLine("a4");
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("days", "Дни");
                Word.Table currentTable = doc.Tables[int.Parse(table.Text)];
                int currentTableRows = currentTable.Rows.Count;
                for (int y = 2; y < currentTable.Columns.Count + 1; y++)
                {
                    string currentText = currentTable.Rows[1].Cells[y].Range.Text;
                    int x = currentText.Length - 1;
                    currentText = currentText.Substring(0, x);
                    dataGridView1.Columns.Add("column" + y, currentText);
                }
                int timeCount = 0;
                for (int r = 2; r < currentTable.Rows.Count + 1; r++)
                {
                    dataGridView1.Rows.Add();
                    for (int c = 2; c < currentTable.Columns.Count; c++)
                    {
                        string curText = currentTable.Rows[r].Cells[c].Range.Text;
                        int z = curText.Length - 1;
                        curText = curText.Substring(0, z);
                        curText = curText.Trim();
                        dataGridView1.Rows[r - 2].Cells[c - 1].Value = curText;
                    }
                }
                for (int a = 0; a < dataGridView1.Rows.Count; a++)
                {
                    if (dataGridView1[1, a].Value.ToString().StartsWith(times[0]))
                    {
                        dataGridView1[0, a].Value = days[timeCount];
                        timeCount++;
                    }
                    else
                    {
                        dataGridView1[0, a].Value = " ";
                    }
                }
                Console.WriteLine("a5");
                doc.Undo();
                app.Quit(false);
                //Excel.Application exApp = new Excel.Application();
                //exApp.Workbooks.Open(@"D:\Диплом\аудитории.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                //Excel.Worksheet wsh = exApp.Worksheets[1];
                }
                catch (Exception)
                {

                }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.doc;*.docx";
            ofd.Filter = "Word document(*.doc;*.docx)|*.doc;*.docx";
            ofd.Title = "Выберите документ для загрузки данных";
            Word.Application wordApp = new Word.Application();
            wordApp.Documents.Open(ofd.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
       
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add(group_name_cb.Text, group_name_cb.Text);
            label2.Text = "true";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Вы действительно хотите удалить выбранный столбец?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (drs == DialogResult.Yes)
            {
                int curcol = dataGridView1.CurrentCellAddress.X;
                string curcolname = dataGridView1.Columns[curcol].Name;
                dataGridView1.Columns.Remove(curcolname);
                MessageBox.Show("Столбец с именем " + curcolname + " удален", "Удаление столбца", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = "true";
            if (dataGridView1.CurrentCell.ColumnIndex < 2)
            {
                dataGridView1.CurrentCell = null;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("audspath.txt");
            string line = sr.ReadLine();
            Excel.Application exApp = new Excel.Application();
            object trueValue = true;
            exApp.Workbooks.Open(line, Type.Missing, false);
            Excel.Worksheet wsh = exApp.Worksheets[1];
            string[] audarray = new string[] { "404", "406", "407", "408", "409", "432", "433", "435", "414", "415", "417", "418", "420", "421", "425", "405", "249", "307", "210", "320", "338",
                    "329", "310", "311", "312", "330", "325", "305", "325а", "334", "327", "246", "1/401", "1/402", "1/403", "1/404", "1/409", "1/407", "1/419", "1/422", "1/423", "1/425", "1/109",
                    "1/413", "1/414", "1/428", "1/429", "1/430", "1/107", "107", "109", "149", "152", "243", "324", "326", "322", "321", "401", "318", "320", "118", "121", "122", "129", "131",
                    "1/203", "1/214", "1/309", "1/313", "1/408", "145", "1/312", "1/317", "1/320", "1/321", "1/322", "1/324", "1/325", "1/326", "1/313а", "1/311", "1/305", "1/308", "1/306",
                    "1/307", "1/201", "1/203", "1/204", "1/205", "1/206", "1/213", "1/214", "1/215", "1/216", "1/217", "1/218", "1/220", "1/221", "1/222", "1/105", "1/124", "1/203", "1/209",
                    "1/311", };
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 2; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        int result;
                        string resultString = string.Join(string.Empty, Regex.Matches(dataGridView1[j,i].Value.ToString().Trim(), @"\d+").OfType<Match>().Select(m => m.Value));
                        int.TryParse(resultString, out result);
                        string currentAud = result.ToString(); 
                        if (currentAud.Length >3)
                        {
                            currentAud = currentAud.ToString().Insert(1, "/");
                        }
                        int CurrentAudID = Array.FindIndex(audarray, item => item == currentAud);
                       
                        Console.WriteLine(currentAud + " " + CurrentAudID);
                    }
                }
            }
            exApp.ActiveWorkbook.Save();
            exApp.Quit();
            sr.Close();
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            discnkafBindingSource.Filter = "kaf = '" + kafFilter.Text + "'";
            teachersBindingSource.Filter = "kaf = '" + kafFilter.Text + "'";
            if (kafFilter.Text == "Нет")
            {
                disciplinesBindingSource.RemoveFilter();
                teachersBindingSource.RemoveFilter();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            StreamReader sr = new StreamReader("audspath.txt");
            string line = sr.ReadLine();
            try
            {
                if (label2.Text == "true" )
                {
                    Console.WriteLine("start");
                    Excel.Application exApp = new Excel.Application();
                    object trueValue = true;
                    exApp.Workbooks.Open(line, Type.Missing, false);
                    Excel.Worksheet wsh = exApp.Worksheets[1];
                    string[] audarray = new string[] { "404", "406", "407", "408", "409", "432", "433", "435", "414", "415", "417", "418", "420", "421", "425", "405", "249", "307", "210", "320", "338",
                    "329", "310", "311", "312", "330", "325", "305", "325а", "334", "327", "246", "1/401", "1/402", "1/403", "1/404", "1/409", "1/407", "1/419", "1/422", "1/423", "1/425", "1/109",
                    "1/413", "1/414", "1/428", "1/429", "1/430", "1/107", "107", "109", "149", "152", "243", "324", "326", "322", "321", "401", "318", "320", "118", "121", "122", "129", "131",
                    "1/203", "1/214", "1/309", "1/313", "1/408", "145", "1/312", "1/317", "1/320", "1/321", "1/322", "1/324", "1/325", "1/326", "1/313а", "1/311", "1/305", "1/308", "1/306",
                    "1/307", "1/201", "1/203", "1/204", "1/205", "1/206", "1/213", "1/214", "1/215", "1/216", "1/217", "1/218", "1/220", "1/221", "1/222", "1/105", "1/124", "1/203", "1/209",
                    "1/311", };
                    int cellIDRow = dataGridView1.SelectedCells[0].RowIndex;
                    int cellIDCol = dataGridView1.SelectedCells[0].ColumnIndex;
                    string currentAud = auditoria.Text;
                    int CurrentAudID = Array.FindIndex(audarray, item => item == currentAud);
                    int errIDCol = 0;
                    int errIDRow = 0;
                    int cnt = 0;
                    for (int i = 1; i < audarray.Length+1; i++)
                    {
                        if (wsh.Cells[i + 1, cellIDRow + 2].Value != null && wsh.Cells[i + 1, cellIDRow + 2].Value.ToString().Trim() == teachers.Text.Trim())
                        {
                            cnt++;
                            errIDCol = cellIDRow + 2;
                            errIDRow = i + 1;
                        }
                        if (cnt >0)
                        { 
                            Console.WriteLine(" cnt >0");
                            DialogResult drs = MessageBox.Show("Данный преподаватель уже занят в другой аудитории, заменить его?", "Накладка!", MessageBoxButtons.YesNo);
                            if (drs == DialogResult.Yes)
                            { 
                                label2.Text = "false";
                                wsh.Cells[CurrentAudID + 2, cellIDRow + 2].Value = teachers.Text.Trim();
                                dataGridView1.SelectedCells[0].Style.BackColor = Color.White;
                                wsh.Cells[errIDRow, errIDCol].Value = null;
                                goto End;
                            }
                            else if(drs == DialogResult.No)
                            {
                                dataGridView1.SelectedCells[0].Style.BackColor = Color.Red;
                                break;
                            }
                            
                        }
                    }
                    if (wsh.Cells[CurrentAudID + 2, cellIDRow + 2].Value != null && wsh.Cells[CurrentAudID + 2, cellIDRow + 2].Value.ToString() != 
                            teachers.Text && wsh.Cells[CurrentAudID + 2, cellIDRow + 2].Value.ToString().Length > 2)
                    {
                        Console.WriteLine("case 1");
                        DialogResult drs = MessageBox.Show("Данная аудитория уже занята другим преподавателем, заменить его?", "Накладка!", MessageBoxButtons.YesNo);
                        if (drs == DialogResult.Yes)
                        {
                            label2.Text = "false";
                            wsh.Cells[CurrentAudID + 2, cellIDRow + 2].Value = teachers.Text.Trim();
                            dataGridView1.SelectedCells[0].Style.BackColor = Color.White;
                            goto End;
                        }
                        else if (drs == DialogResult.No)
                        {
                            dataGridView1.SelectedCells[0].Style.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        wsh.Cells[CurrentAudID + 2, cellIDRow + 2].Value = teachers.Text.Trim();
                        dataGridView1.SelectedCells[0].Style.BackColor = Color.White;
                    }
                    End:
                    Console.WriteLine("exit");
                    exApp.ActiveWorkbook.Save();
                    exApp.Quit();
                }
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            sr.Close();
            label2.Text = "false";
        }
        private void raspisanieDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("audspath.txt");
            string line = sr.ReadLine();
            Excel.Application exApp = new Excel.Application();
            object trueValue = true;
            exApp.Workbooks.Open(line , Type.Missing, false);
            Excel.Worksheet wsh = exApp.Worksheets[1];
            string[] audarray = new string[] { "404", "406", "407", "408", "409", "432", "433", "435", "414", "415", "417", "418", "420", "421", "425", "405", "249", "307", "210", "320", "338",
                    "329", "310", "311", "312", "330", "325", "305", "325а", "334", "327", "246", "1/401", "1/402", "1/403", "1/404", "1/409", "1/407", "1/419", "1/422", "1/423", "1/425", "1/109",
                    "1/413", "1/414", "1/428", "1/429", "1/430", "1/107", "107", "109", "149", "152", "243", "324", "326", "322", "321", "401", "318", "320", "118", "121", "122", "129", "131",
                    "1/203", "1/214", "1/309", "1/313", "1/408", "145", "1/312", "1/317", "1/320", "1/321", "1/322", "1/324", "1/325", "1/326", "1/313а", "1/311", "1/305", "1/308", "1/306",
                    "1/307", "1/201", "1/203", "1/204", "1/205", "1/206", "1/213", "1/214", "1/215", "1/216", "1/217", "1/218", "1/220", "1/221", "1/222", "1/105", "1/124", "1/203", "1/209",
                    "1/311", };
            label2.Text = "false";
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                if (cell.Value != null)
                {
                    int result;
                    string resultString = string.Join(string.Empty, Regex.Matches(cell.Value.ToString().Trim(), @"\d+").OfType<Match>().Select(m => m.Value));
                    int.TryParse(resultString, out result);
                    string currentAud = result.ToString();
                    int CurrentAudID = Array.FindIndex(audarray, item => item == currentAud);
                    int currCellIDRow = cell.RowIndex;
                    int currCellIDCol = cell.ColumnIndex;
                    if (wsh.Cells[CurrentAudID+2, currCellIDRow+2].Value != null)
                    {
                        wsh.Cells[CurrentAudID + 2, currCellIDRow + 2].Value = null;
                    }
                    cell.Value = null;
                }
            }
            exApp.ActiveWorkbook.Save();
            exApp.Quit();
            label2.Text = "true";
            sr.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private async void button2_Click_1(object sender, EventArgs e)
        {
            //string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            //string FileName = string.Format("{0}Resources\\аудитории.xlsx", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            //Excel.Application application = new Excel.Application();
            //application.Workbooks.Open(FileName);
            //Excel.Worksheet wsh = application.Worksheets[1];
        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.disciplinaTableAdapter.FillBy(this.demo2DataSet.disciplina);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_disc_filter.Text.Length == 0)
                {
                    disciplinaBindingSource.RemoveFilter();
                }
                else
                {
                    disciplinaBindingSource.Filter = "disciplina_ru LIKE '*" + tb_disc_filter.Text + "*'";
                }
            }
            catch (Exception)
            {

            }
           
        }

        private void tb_prep_filter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_prep_filter.Text.Length == 0)
                {
                    sotrudnikfioviewBindingSource.RemoveFilter();
                }
                else
                {
                    sotrudnikfioviewBindingSource.Filter = "Expr1 LIKE '*" + tb_prep_filter.Text + "'*";
                }
            }
            catch (Exception)
            {

            }
        }
    } 

}



