using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace INGILIZCE_GELISTIRME_OYUNU
{
    public partial class ENGAME : Form
    {
        public bool ses = true;

        public ENGAME()
        {
            InitializeComponent();

            //label2.BackColor = System.Drawing.Color.Transparent;

            //exit.BackColor = System.Drawing.Color.Transparent;
            //exit.ForeColor = System.Drawing.Color.Transparent;

            //start.BackColor = System.Drawing.Color.Transparent;
            //information.BackColor = System.Drawing.Color.Transparent;
            //label1.BackColor = System.Drawing.Color.Transparent;
            //label3.BackColor = System.Drawing.Color.Transparent;
            //label4.BackColor = System.Drawing.Color.Transparent;

            //int a = 1;
            //pictureBox4.Image = Image.FromFile(@"Images\" + Convert.ToString(a) +".png");
            //pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;

        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }

        static void kop(string[] args)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonElipte1_Click(object sender, EventArgs e) // information
        {

            information_form formm = new information_form();

            this.Hide();
            formm.Show();


        }


        private void start_Click(object sender, EventArgs e) // start
        {
            game oyun = new game();
            this.Hide();
            oyun.Show();

        }

        private void buttonElipte2_Click(object sender, EventArgs e) // exit
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

    class ButtonElipte : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(graphics);
            base.OnPaint(pevent);
        }
    }
}
