using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace side_scrolling_plateform_game
{
    public partial class Form1 : Form
    {
        bool goLeft = false;
        bool goright = false;
        bool jumping = false;
        bool hasKey = false; //defalut value of r wehater the player has the key

        int jumpSpeed = 10;
        int force = 8;
        int score = 0;

        int playSpeed = 18;//int set plaer y speed to 18
        int backLeft = 8; //background moving speed
            
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;
            //refreshes the player continuosly
            player.Refresh();

            if (jumping && force > 0)
            {
                jumping = false;
            }
            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (goLeft && player.Left > 100)
            {
                player.Left -= playSpeed;
            }

            if (goright && player.Left + (player.Width + 100)< this.ClientSize.Width)
            {
                player.Left += playSpeed;
            }

            if(goright && background.Left  > -1353)
            {
                background.Left -= backLeft;
                foreach (Control x in this.Controls)
                {
                    if(x is PictureBox && x.Tag == "platform" || x is PictureBox &&
                          x.Tag == "coin" || x is PictureBox && x.Tag == "door" || x is PictureBox && x.Tag == "key")
                    {
                        x.Left -= backLeft;
                    }
                }
            }
            if(goLeft && background.Left < 2 )
            {
                background.Left += backLeft;

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform" || x is PictureBox &&
                          x.Tag == "coin" || x is PictureBox && x.Tag == "door" || x is PictureBox && x.Tag == "key")
                    {
                        x.Left += backLeft;
                    }
                }
            }
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "platform")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                        jumpSpeed = 0;
                    }
                }
                if(x is PictureBox && x.Tag == "coin")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }
            }
            if (player.Bounds.IntersectsWith(door.Bounds) && hasKey)
            {
                door.Image = Properties.Resources.door_open;
                gameTimer.Stop();
                MessageBox.Show("You have completed this level");
            }
            if(player.Bounds.IntersectsWith(key.Bounds))
            {
                this.Controls.Remove(key);
                hasKey = true;
            }

            // if player goes below pthe forms then end gmae
            if(player.Top + player.Height > this.ClientSize.Height +60)
            {
                gameTimer.Stop();
                MessageBox.Show("you have DIED");
                
            }

        }
  
        private void keyisdown(object sender, KeyEventArgs e)
        {
            //if the plaeyr preeses the leftkey and the player is inside the panel
            //then we ste the car left boolean to true
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
           //  if the player pressed theright key and the pplaeyr left plus th eplayer width is less than the panel width
           if(e.KeyCode == Keys.Right)
            {
                goright = true;
            }
           if(e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (jumping)
            {
                jumping = false;
            }
        }

       
    }
}
