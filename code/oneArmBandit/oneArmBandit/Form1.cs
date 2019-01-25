using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using oneArmBandit.Properties;//to access resources


namespace oneArmBandit
{
    public partial class Form1 : Form
    {
        Image[] images = { Resources.pup1, Resources.pup2, Resources.pup3, Resources.pup5, Resources.pup6 };
        int wheel1position = 0;
        int wheel2position = 0;
        int wheel3position = 0;

        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)//spin button

        {
            //put a if statement in for the images to continualy run with a 'count'
            //picture box one
            wheel1position = rnd.Next(0, 5);  
            pictureBox1.Image = images[wheel1position];

            wheel2position = rnd.Next(0, 5);
            pictureBox2.Image = images[wheel2position];

            wheel3position = rnd.Next(0, 5);
            pictureBox3.Image = images[wheel3position];

        }

        private void nudge1_Click(object sender, EventArgs e)//nudge one
        {

            wheel1position = ((wheel1position +1 ) % images.Length);
            pictureBox1.Image = images[wheel1position];
            pictureBox1.Update();

        }
        
        private void nudge2_Click(object sender, EventArgs e)//nudge button two
        {
            wheel2position = ((wheel2position + 1) % images.Length);
            pictureBox2.Image = images[wheel2position];
            pictureBox2.Update();
    
        }

        private void nudge3_Click(object sender, EventArgs e)//nudge button three
        {
            wheel3position = ((wheel3position + 1) % images.Length);
            pictureBox3.Image = images[wheel3position];
            pictureBox3.Update();

        }
    }
}

