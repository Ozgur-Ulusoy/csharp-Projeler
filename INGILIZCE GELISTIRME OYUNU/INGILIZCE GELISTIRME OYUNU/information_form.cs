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
    public partial class information_form : Form
    {
        public information_form()
        {
            InitializeComponent();

        }


        private void exit_Click(object sender, EventArgs e)
        {

            foreach (Form funk in Application.OpenForms)
            {
                if (funk is ENGAME)
                {
                    funk.Show();
                    break;
                }
            }
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


}
