using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24._10._2023_butona_basma_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Button> butonlar = new List<Button>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=1; i<6; i++)
            {
                Button btn = new Button();
                btn.Name = "btn "+i.ToString();
                btn.SetBounds(20, 70 * i, 60, 30);
                this.Controls.Add(btn);
                butonlar.Add(btn);
                btn.Click += Btn_Click;
            }
            Button btn1 = new Button();
            btn1.Click += Btn_Click;

        }
        int sayi = 0;
        private void Btn_Click(object sender, EventArgs e)
        {
            Button buton = (sender as Button);
            buton.Visible = false;
            sayi++;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayi == 5)
            {
                timer1.Stop();
                MessageBox.Show("Game Over");
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < butonlar.Count; i++)
                    butonlar[i].SetBounds(rnd.Next(50, 250), rnd.Next(0, 250), 60, 30);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

        }
    }
}
