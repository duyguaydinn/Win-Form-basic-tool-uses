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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void methotlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "C# methotlardasınız";
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bAŞLATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }
        int sure = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = sure.ToString();
            sure++;

            if(sure >=0 && sure <= 30)
            {
                panel1.BackColor = Color.Red;
                panel3.BackColor = Color.Transparent;
            }
            if( sure >30 && sure <= 40)
            {
                panel2.BackColor = Color.Yellow;
            }
            if(sure > 40 && sure <= 70)
            {
                panel3.BackColor = Color.Green;
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;
            }
            if ( sure == 71)
            {
                sure = 0;
            }
        }
    }
}
