using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INGILIZCE_GELISTIRME_OYUNU
{
    public partial class soru : Form
    {
        

        public soru()
        {
            InitializeComponent();

        }

        bool sess2;

        public void sesial(bool ses)
        {
            sess2 = ses;
        }

        public void kılas(int dogru,int yanlis,int puan)
        {
            label1.Text = Convert.ToString(dogru);
            label3.Text = Convert.ToString(yanlis);
            label6.Text = Convert.ToString(puan);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonElipte1_Click(object sender, EventArgs e)
        {
            game gr = new game();
            this.Close();
            gr.Show();
            gr.sesdeneme(sess2);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
