using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.VarovaAA.Sprint6.Task1.V24.Lib;
namespace Tyuiu.VarovaAA.Sprint6.Task1.V24
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();
        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxVarStart_VAA.Text);
                int stopValue = Convert.ToInt32(textBoxVarStop_VAA.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxRes_VAA.Text = "";
                textBoxRes_VAA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxRes_VAA.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxRes_VAA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   |", startValue, valueArray[i]);
                    textBoxRes_VAA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxRes_VAA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_VAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнина студентка группы ИИПб-23-2 Варова Ангелина Александровна", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxVarStart_VAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRes_VAA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
