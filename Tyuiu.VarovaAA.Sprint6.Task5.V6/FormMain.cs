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
using Tyuiu.VarovaAA.Sprint6.Task5.V6.Lib;
namespace Tyuiu.VarovaAA.Sprint6.Task5.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\User\source\repos\Tyuiu.VarovaAA.Sprint6\Tyuiu.VarovaAA.Sprint6.Task5.V6\bin\Debug\InPutFileTask5V6.txt";
        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_VAA.ColumnCount = 2;
            dataGridViewNums_VAA.Columns[0].Width = 20;
            dataGridViewNums_VAA.Columns[1].Width = 50;

            this.chartFunction_VAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_VAA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_VAA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_VAA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_VAA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_VAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_VAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнина студентка группы ИИПб-23-2 Варова Ангелина Александровна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
