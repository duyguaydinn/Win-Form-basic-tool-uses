namespace Temel_Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sınıflarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "C Sınıflar menüsüne geçiş yapıldı";
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        int sayac = 0;
        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        int sure = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = sure.ToString();
            sure++;

            if(sure>=0 && sure <= 30)
            {
                panel1.BackColor = Color.Red;
                panel3.BackColor = Color.Transparent;
            }
            if(sure >30 && sure <= 40)
            {
                panel2.BackColor = Color.Yellow;
            }
            if(sure>40 && sure <= 70)
            {
                panel3.BackColor = Color.Green;
                panel1.BackColor = Color.Transparent;
                panel2.BackColor= Color.Transparent;
            }
            if(sure == 71)
            {
                sure = 0;
            }
        }
    }
}