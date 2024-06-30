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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnArttir_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
