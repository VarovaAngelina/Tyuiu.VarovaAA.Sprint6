using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.VarovaAA.Sprint6.Task2.V19.Lib;
namespace Tyuiu.VarovaAA.Sprint6.Task2.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();
        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxVarStart_VAA.Text);
                int stopValue = Convert.ToInt32(textBoxVarStop_VAA.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                this.chartFunction_VAA.Titles.Add("График функции ((Math.Sin(x)) / (x + 1.7)) - Math.Cos(x) * 4 * x - 6");

                this.chartFunction_VAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_VAA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_VAA.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartFunction_VAA.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_VAA.BackColor = Color.Pink;
        }

        private void buttonDone_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_VAA.BackColor = Color.PaleGreen;
        }

        private void buttonDone_VAA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_VAA.BackColor = Color.PaleTurquoise;
        }

        private void buttonSpravka_VAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнина студентка группы ИИПб-23-2 Варова Ангелина Александровна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
