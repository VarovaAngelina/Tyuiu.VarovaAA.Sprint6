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
using Tyuiu.VarovaAA.Sprint6.Task6.V27.Lib;
namespace Tyuiu.VarovaAA.Sprint6.Task6.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path;
        private void buttonOpenFile_VAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_VAA.ShowDialog();
            path = openFileDialogTask_VAA.FileName;
            textBoxIn_VAA.Text = File.ReadAllText(path);
            groupBoxOut_VAA.Text = groupBoxOut_VAA.Text + " " + openFileDialogTask_VAA.FileName;
            buttonDone_VAA.Enabled = true;
        }

        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            textBoxOut_VAA.Text = ds.CollectTextFromFile(path);
        }

        private void buttonHelp_VAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
