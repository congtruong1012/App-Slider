using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliderImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox5.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox9.Visible = false;
            timer1.Start();
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            
            pictureBox6.Visible = false;
            pictureBox9.Visible = true;
            timer1.Stop();
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            
            pictureBox9.Visible = false;
            pictureBox6.Visible = true;
            timer1.Start();
        }
    }
}
