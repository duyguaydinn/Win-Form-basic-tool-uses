using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temel_Arac_Kullanimlari
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            radioButton1.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label4.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label4.Text = openFileDialog1.FileName;
        }
    }
}
