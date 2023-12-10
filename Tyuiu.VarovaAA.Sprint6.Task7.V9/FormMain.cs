using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Tyuiu.VarovaAA.Sprint6.Task7.V9.Lib;
namespace Tyuiu.VarovaAA.Sprint6.Task7.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_VAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_VAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string path;

        public static int[,] LoadFromFileData(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return matrix;
        }
        private void buttonOpenFile_VAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_VAA.ShowDialog();
            path = openFileDialogTask_VAA.FileName;

            int[,] matrix = new int[rows, columns];

            matrix = LoadFromFileData(path);

            dataGridViewIn_VAA.ColumnCount = columns;
            dataGridViewIn_VAA.RowCount = rows;
            dataGridViewOut_VAA.ColumnCount = columns;
            dataGridViewOut_VAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_VAA.Columns[i].Width = 25;
                dataGridViewOut_VAA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_VAA.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }

            matrix = ds.GetMatrix(path);
            buttonDone_VAA.Enabled = true;
        }

        private void buttonHelp_VAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[rows, columns];
            matrix = ds.GetMatrix(path);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_VAA.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            buttonSaveFile_VAA.Enabled = true;
        }

        private void buttonSaveFile_VAA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_VAA.FileName = "OutPutFileTask7V9.csv";
            saveFileDialogMatrix_VAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_VAA.ShowDialog();

            string path = saveFileDialogMatrix_VAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_VAA.RowCount;
            int columns = dataGridViewOut_VAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_VAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_VAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_VAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VAA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_VAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VAA.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_VAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VAA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_VAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VAA.ToolTipTitle = "Справка";
        }
    }
}
