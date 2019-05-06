using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace platformgame
{
    public partial class Form1 : Form
    {
        //the booleans for the keyboard movements
        bool goleft = false;
        bool goright = false;
        bool jumping = false;

        //the intergers just setting the values
        int jumpSpeed = 10;
        int force = 8;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e) //key down function
        {
            //will trigger when the buttons are pressed down
            if (e.KeyCode == Keys.Left)//left button
            {
                goleft = true; //setting the boolean to true
            }
            if (e.KeyCode == Keys.Right)//right button
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)//when the space bar is pressed down and jumping is not true
            {
                jumping = true;//setting jumping to true
            }

        }

        private void keyisup(object sender, KeyEventArgs e)//when the player realses the key
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //continusly dropping the player towards the ground
            //same effect as gravity (ish)
            player.Top += jumpSpeed;

            if (jumping && force < 0)//checking if the player is jumping and the force is less than 0
            {
                jumping = false;
            }
            if (goleft)//if goleft is true we can push the player towards the left of the screen
            {
                player.Left -= 5;
            }
            if (goright)//if goright is true we can push the chararcter to the right of the screen 
            {
                player.Left += 5;
            }
            if (jumping)//if jumping is true
            {
                jumpSpeed = -12;//will thrust the player towards the top 
                force -= 1;//decrease the force by 1 
                //gives the player a limit otherwise the player will fly over everything
            }
            else
            {
                jumpSpeed = 12;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                    }
                }
                if (x is PictureBox && x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }

                if (player.Bounds.IntersectsWith(door.Bounds))
                {
                    timer1.Stop();
                    MessageBox.Show("you WIN");
                }
            }
        }
    }
}
