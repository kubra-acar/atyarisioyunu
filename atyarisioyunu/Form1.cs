using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atyarisioyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int at1soluz, at2soluz, at3soluz;
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int at1gen = pictureBox1.Width;
            int at2gen = pictureBox2.Width;
            int at3gen = pictureBox3.Width;
            int bitisuz = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rnd.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rnd.Next(5, 15);

            if(pictureBox1.Left > pictureBox2.Left +5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label7.Text = "1 numaralı at önde!!!!";
            }
            if (pictureBox2.Left > pictureBox1.Left +5 && pictureBox1.Left > pictureBox3.Left +5)
            {
                label7.Text = "2 numaralı at öne geçti!!!!";
            }
            if (pictureBox3.Left > pictureBox2.Left +5 && pictureBox2.Left > pictureBox1.Left +5)
            {
                label7.Text = "3 numaralı at yarışı kazanıcak gibi görünüyor!!!!";
            }

            if (pictureBox1.Left+ at1gen >= bitisuz)
            {
                int tahmin = Convert.ToInt32(textBox1.Text);
                timer1.Enabled = false;
                label7.Text = "1 numaralı at yarışı kazandı";
                
                if ( tahmin == 1)
                {
                    label9.Text = "Tahmin doğru KAZANDINIZ!!";
                    label9.BackColor = Color.Blue;
                }
                else
                {
                    label9.Text = "Kaybettiniz";
                    label9.BackColor = Color.Red;
                }
            }
            if(pictureBox2.Left + at2gen >= bitisuz)
            {
                int tahmin = Convert.ToInt32(textBox1.Text);
                timer1.Enabled = false;
                label7.Text = "2 numaralı at yarışı kazandı";

                if (tahmin == 2)
                {
                    label9.Text = "Tahmin doğru KAZANDINIZ!!";
                    label9.BackColor = Color.Blue;
                }
                else
                {
                    label9.Text = "Kaybettiniz";
                    label9.BackColor = Color.Red;                
                }
            }
            if(pictureBox3.Left + at3gen >= bitisuz)
            {
                int tahmin = Convert.ToInt32(textBox1.Text);
                timer1.Enabled = false;
                label7.Text = "3 numaralı at yarışı kazandı";

                if (tahmin == 3)
                {
                    label9.Text = "Tahmin doğru KAZANDINIZ!!";
                    label9.BackColor = Color.Blue;
                }
                else
                {
                    label9.Text = "Kaybettiniz";
                    label9.BackColor = Color.Red;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            at1soluz = pictureBox1.Left;
            at2soluz = pictureBox2.Left;
            at3soluz = pictureBox3.Left;
        }
    }
}
