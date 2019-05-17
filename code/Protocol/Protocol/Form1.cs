using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protocol
{
    public partial class Form1 : Form
    {
        bool goLeft = false;
        bool goRight = false;
        bool jumping = false;

        int jumpSpeed = 10;
        double  force = 2;


        public Form1()
        {
            InitializeComponent();
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)//left button
            {
                goLeft = true; //setting the boolean to true
            }
            if (e.KeyCode == Keys.Right)//right button
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)//when the space bar is pressed down and jumping is not true
            {
                jumping = true;//setting jumping to true
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
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
            fireboy.Top += jumpSpeed;
            header.Top += jumpSpeed;


            if (jumping && force < 0)//checking if the player is jumping and the force is less than 0
            {
                jumping = false;
            }
            if (goLeft)//if goleft is true we can push the player towards the left of the screen
            {
                fireboy.Left -= 5;
                header.Top -= 5;
                
            }
            if (goRight)//if goright is true we can push the chararcter to the right of the screen 
            {
                fireboy.Left += 5;
                header.Top += 5;
              
            }
            if (jumping)//if jumping is true
            {
                jumpSpeed = -20;//will thrust the player towards the top 
                force -= 0.8;//decrease the force by 1 
                //gives the player a limit otherwise the player will fly over everything
            }
            else
            {
                jumpSpeed = 14;
            }
            
            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "character" )
                {
                    if(header.Bounds.IntersectsWith(x.Bounds))
                    {
                        force = 8;
                        header.Top = x.Top - header.Height;
                    }
                }
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (fireboy.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        fireboy.Top = x.Top - fireboy.Height;
                    }
                }
                if(x is PictureBox && x.Tag == "border")
                {
                    if(fireboy.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        fireboy.Top = x.Top - fireboy.Height;
                    }
                }
                if (x is PictureBox && x.Tag == "water")
                {
                    if (fireboy.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        timer1.Stop();
                        MessageBox.Show("you DIED");

                    }
                }


            }
        }

        
    }
}
