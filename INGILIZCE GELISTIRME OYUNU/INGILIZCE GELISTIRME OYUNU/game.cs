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
using System.Timers;
using Timer = System.Windows.Forms.Timer;
using System.Media;
using WMPLib;



namespace INGILIZCE_GELISTIRME_OYUNU
{
    
    // 3080 de kaldın A.txt onu düzelt debug içine at 
    public partial class game : Form
    {

        public int counter = 0;
        public int ynlis = 0;
        public int puan = 0;

        bool btn1 = false;
        bool btn2 = false;
        bool btn3 = false;
        bool btn4 = false;
        bool btn5 = false;
        bool btn6 = false;

        public bool sess = true;

        private static readonly System.Windows.Forms.Timer timer = new Timer();

        string file = "A.txt";


        List<string> liste = new List<string>();
        List<string> sayilar = new List<string>();
        List<string> ing = new List<string>();
        List<string> tr = new List<string>();
        string line;
        int sure = 120;
        Random rnd = new Random();
        string cevap;


        public void islemler() // dosya okuma işlemleri 
        {
            StreamReader sr = new StreamReader(file);

            while ((line = sr.ReadLine()) != null)
            {

                liste.Add(line);
                string[] subs = line.Split('\t');
                sayilar.Add(subs[0]);
                ing.Add(subs[1]);
                tr.Add(subs[2]);
               
            }
        }

        //public void  sesial(bool ses)
        //{
        //    sess = ses;
        //}

        public void dogru()
        {

            int a = rnd.Next(0, 5000);
            int z = rnd.Next(1, 7);

            label1.Text = Convert.ToString(counter);
            label2.Text = ing[a];
            cevap = ing[a];
            label4.Text = Convert.ToString(sure);
            label5.Text = Convert.ToString(puan);
            label6.Text = Convert.ToString(ynlis);

            button1.Text = tr[rnd.Next(0, 5000)];
            button2.Text = tr[rnd.Next(0, 5000)];
            button3.Text = tr[rnd.Next(0, 5000)];
            button4.Text = tr[rnd.Next(0, 5000)];
            button5.Text = tr[rnd.Next(0, 5000)];
            button6.Text = tr[rnd.Next(0, 5000)];

            switch (z)
            {
                case 1:
                    button1.Text = tr[a];
                    btn1 = true;
                    break;
                case 2:
                    button2.Text = tr[a];
                    btn2 = true;
                    break;
                case 3:
                    button3.Text = tr[a];
                    btn3 = true;
                    break;
                case 4:
                    button4.Text = tr[a];
                    btn4 = true;
                    break;
                case 5:
                    button5.Text = tr[a];
                    btn5 = true;
                    break;
                case 6:
                    button6.Text = tr[a];
                    btn6 = true;
                    break;
            }

        }

        public game()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            islemler();
            dogru();
            timer1.Start();

            }

        public void sesdeneme(bool c)
        {

            if (c == true)
            {
                int a = 1;
                buttonElipte1.BackgroundImage = Image.FromFile(Convert.ToString(a) + ".png");
                buttonElipte1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                sess = c;
            }

            if (c == false)
            {
                int a = 2;
                buttonElipte1.BackgroundImage = Image.FromFile(Convert.ToString(a) + ".png");
                buttonElipte1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                sess = c;
            }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label4.Text = Convert.ToString (sure);
            if (sure <= 0)
            {
                timer1.Stop();

                soru sru = new soru();
                sru.kılas(counter, ynlis,puan);
                sru.sesial(sess);
                this.Hide();
                sru.Show();
                

            }
        }

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        
        private void button1_Click(object sender, EventArgs e)
        {



            if (btn1 == true)
            {
                counter++;
                puan += 200;
                if (sess == true)
                {
                    wplayer.URL = "correct-sound-effect.mp3";
                }


            }

            else
            {
                ynlis++;
                puan -= 100;
                if (sess == true)
                {
                    wplayer.URL = "wrong-answer-sound-effect-hd.mp3";

                }
            }

            btn1 = false;
            dogru();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (btn2 == true)
            {
                counter++;
                puan += 200;
                if (sess == true)
                {
                    wplayer.URL = "correct-sound-effect.mp3";

                }
            }

            else
            {
                ynlis++;
                puan -= 100;
                if (sess == true)
                {
                    wplayer.URL = "wrong-answer-sound-effect-hd.mp3";

                }
            }

            btn2 = false;
            dogru();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (btn3 == true)
            {
                counter++;
                puan += 200;

                if (sess == true)
                {
                    wplayer.URL = "correct-sound-effect.mp3";

                }
            }

            else
            {
                ynlis++;
                puan -= 100;
                if (sess == true)
                {
                    wplayer.URL = "wrong-answer-sound-effect-hd.mp3";

                }
            }

            btn3 = false;
            dogru();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (btn4 == true)
            {
                counter++;
                puan += 200;
                if (sess == true)
                {
                    wplayer.URL = "correct-sound-effect.mp3";

                }
            }

            else
            {
                ynlis++;
                puan -= 100;
                if (sess == true)
                {
                    wplayer.URL = "wrong-answer-sound-effect-hd.mp3";

                }
            }

            btn4 = false;
            dogru();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (btn5 == true)
            {
                counter++;
                puan += 200;
                if (sess == true)
                {
                    wplayer.URL = "correct-sound-effect.mp3";

                }
            }

            else
            {
                ynlis++;
                puan -= 100;
                if (sess == true)
                {
                    wplayer.URL = "wrong-answer-sound-effect-hd.mp3";

                }
            }

            btn5 = false;
            dogru();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (btn6 == true)
            {
                counter++;
                puan += 200;
                if (sess == true)
                {
                    wplayer.URL = "correct-sound-effect.mp3";

                }
            }

            else
            {
                ynlis++;
                puan -= 100;
                if (sess == true)
                {
                    wplayer.URL = "wrong-answer-sound-effect-hd.mp3";

                }
            }

            btn6 = false;
            dogru();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonElipte1_Click(object sender, EventArgs e)
        {
            if (sess == true)
            {
                int a = 2;
                buttonElipte1.BackgroundImage = Image.FromFile(Convert.ToString(a) + ".png");
                buttonElipte1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                sess = false;
            }

            else if (sess == false && sure == 120 )
            {
                int a = 1;
                buttonElipte1.BackgroundImage = Image.FromFile(Convert.ToString(a) + ".png");
                buttonElipte1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }

            else
            {
                int a = 1;
                buttonElipte1.BackgroundImage = Image.FromFile(Convert.ToString(a) + ".png");
                buttonElipte1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                sess = true;
            }
        }
    }


}
