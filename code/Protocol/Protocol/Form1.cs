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
        //for fireboy
        bool goLeft = false;//this controls fb to go left
        bool goRight = false;//a bool for fb to go right
        bool jumping = false;//a bool for fb jumping
        //for watergirl
        bool h2oLeft = false;
        bool h2oRight = false;
        bool h2oJumping = false;
        
        //for fireboy
        int jumpSpeed = 10;
        double  force = 2;
        //for watergirl
        int h2oJumpSpeed = 10;
        double h2oForce = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            //fireboy
            if (e.KeyCode == Keys.Left)//left button
            {
                goLeft = true; //setting the boolean to true
            }
            if (e.KeyCode == Keys.Right)//right button
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && !jumping)//when the space bar is pressed down and jumping is not true
            {
                jumping = true;//setting jumping to true
            }

            //watergirl
            if(e.KeyCode == Keys.A)
            {
                h2oLeft = true;
            }
            if(e.KeyCode == Keys.D)
            {
                h2oRight = true;
            }
            if(e.KeyCode == Keys.W && !h2oJumping)
            {
                h2oJumping = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            //fireboy
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

            //watergirl
            if(e.KeyCode == Keys.A)
            {
                h2oLeft = false;
            }
            if(e.KeyCode == Keys.D)
            {
                h2oRight = false;
            }
            if(e.KeyCode == Keys.W)
            {
                h2oJumping = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //continusly dropping the player towards the ground
            //same effect as gravity (ish)
            fireboy.Top += jumpSpeed;
            watergirl.Top += h2oJumpSpeed;
            header.Top += jumpSpeed;

            if (jumping && force < 0)//checking if the player is jumping and the force is less than 0
            {
                jumping = false;
            }
            if(h2oJumping && h2oForce < 0)
            {
                h2oJumping = false;
            }
            

            if (goLeft)//if goleft is true we can push the player towards the left of the screen
            {
                fireboy.Left -= 5;
                header.Left -= 5;
                
            }
            if(h2oLeft)
            {
                watergirl.Left -= 5;
            }
            //going right
            if (goRight)//if goright is true we can push the chararcter to the right of the screen 
            {
                fireboy.Left += 5;
                header.Left += 5;
              
            }
            if(h2oRight)
            {
                watergirl.Left += 5;
            }
            //jumoing
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

            if(h2oJumping)
            {
                h2oJumpSpeed = -20;
                h2oForce -= 0.8;
            }
            else
            {
                h2oJumpSpeed = 14;
            }

            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "character")
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
                    if(watergirl.Bounds.IntersectsWith(x.Bounds) && !h2oJumping)
                    {
                        h2oForce = 8;
                        watergirl.Top = x.Top - watergirl.Height;
                    }
                    if(header.Bounds.IntersectsWith(x.Bounds))
                    {

                    }
                }

              if(x is PictureBox && x.Tag == "watergirlDoor")
                {
                    if(watergirl.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer1.Stop();
                        MessageBox.Show("you WIN");//add score later
                    
                    }
                }
              if(x is PictureBox && x.Tag == "fireboyDoor")
                {
                    if(fireboy.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer1.Stop();
                        MessageBox.Show("you WIN");
                       
                    }
                }
                     
                if (x is PictureBox && x.Tag == "water")
                {
                    if (fireboy.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        timer1.Stop();
                        MessageBox.Show("you DIED");
                        fireboy.Location = new Point(700, 450);
                        watergirl.Location = new Point(94, 443);
                        jumping = false;
                        goLeft = false;
                        goRight = false;
                       timer1.Start();
                    }
                }
                if(x is PictureBox && x.Tag =="fire")
                {
                    if(watergirl.Bounds.IntersectsWith(x.Bounds) && !h2oJumping)
                    {
                        timer1.Stop();
                        MessageBox.Show("you DIED");
                        fireboy.Location = new Point(700, 450);
                        watergirl.Location = new Point(94, 443);
                        h2oRight = false;
                        h2oJumping = false;
                        h2oLeft = false;
                       timer1.Start();
                    }
                }

            }
        }

        
    }
}
