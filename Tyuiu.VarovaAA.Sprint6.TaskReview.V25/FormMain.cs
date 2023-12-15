using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.VarovaAA.Sprint6.TaskReview.V25.Lib;
namespace Tyuiu.VarovaAA.Sprint6.TaskReview.V25
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        static int n;
        static int m;
        static int n1;
        static int n2;
        static int k;
        static int l;
        static int r;
        static int x;
        static int[,] array;
        Random random = new Random();
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void panelTask_VAA_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void buttonHelp_VAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void dataGridViewRes_VAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void buttonGenerateMatrix_VAA_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxInPutVarN_VAA.Text);
                int m = Convert.ToInt32(textBoxInPutVarM_VAA.Text);
                int n1 = Convert.ToInt32(textBoxInPutVarn1_VAA.Text);
                int n2 = Convert.ToInt32(textBoxInPutVarn2_VAA.Text);
                int x = Convert.ToInt32(textBoxInPutVarX_VAA.Text);

                array = ds.GetRandomMatrix(n, m, n1, n2, x);

                dataGridViewRes_VAA.RowCount = n;
                dataGridViewRes_VAA.ColumnCount = m;

                for (int i = 0; i < m; i++)
                {
                    dataGridViewRes_VAA.Columns[i].Width = 50;
                }

                for (int r = 0; r < n; r++)
                {
                    for (int c = 0; c < m; c++)
                    {
                        dataGridViewRes_VAA.Rows[r].Cells[c].Value = array[r, c];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            buttonCalc_VAA.Enabled = true;
        }

        private void buttonCalc_VAA_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(textBoxInPutVarK_VAA.Text);
                int l = Convert.ToInt32(textBoxInPutVarL_VAA.Text);
                int r = Convert.ToInt32(textBoxInPutVarR_VAA.Text);

                int res = ds.GetMatrix(array, r, k, l);
                textBoxResSum_VAA.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
