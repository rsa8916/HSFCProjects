using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    public partial class Form1 : Form
    {
        //global variables
        int carSpeed = 5;
        int roadSpeed = 5;
        bool carLeft;
        bool carRight;
        int trafficSpeed = 5;
        int Score = 0;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            trophy.Visible = false; //hide the trophy image 
            button1.Enabled = false; //diable the button when the game is playing
            exsplosion.Visible = false; //hide the exsplosion gif
            trafficSpeed = 5; //set the traffic back to defalt
            roadSpeed = 5; //set the road speed back to deafault speed
            Score = 0; //reset the score to zero

            player.Left = 161; //reset player left
            player.Top = 286; //reset player top

            carLeft = false; //reset the moving left to false
            carRight = false; //reset the moving right to false

            //move the AI to defalt position this will be of screen
            AI1.Left = 66;
            AI1.Top = -120;

            AI2.Left = 294;
            AI2.Top = -185;

            //reset the road to their default positon
            roadTrack2.Left = -3;
            roadTrack2.Top = -222;
            roadTrack1.Left = -2;
            roadTrack1.Top = -638;

            //start the timer
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Score++; //increases the score as we move

            distance.Text = "" + Score; //show the score on the distance lable

            roadTrack1.Top += roadSpeed; //move the track 1 down with the +=
            roadTrack2.Top += roadSpeed; //move the track 2 down with the +=

            //if the track has gone down past -630 then we set it back to default
            //this means it will give us a seamless animation
            if (roadTrack1.Top > 630)
            {
                roadTrack1.Top = -630;
            }
            if (roadTrack2.Top > 630)
            {
                roadTrack2.Top = -630;
            }

            //end of track animation.

            if (carLeft) { player.Left -= carSpeed; } //move the car left if the car left is true
            if (carRight) { player.Left -= carSpeed; } //move the car right if the car right is true

            //end of car moving.

            //bounce the cars of the boundaries of the pannel
            if (player.Left < 1)
            {
                carLeft = false; //stop the car from going of the screen
            }
            else if (player.Left + player.Width > 380)
            {
                carRight = false;
            }
            //end of the boudaries check

            //move the AI cars down 
            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;

            //respawn the AIs and change their images
            if (AI1.Top > panel1.Height)
            {
                changeAI1(); //change the AI images once theyve left the screen
                AI1.Left = rnd.Next(185, 327); //random numbers where they appear on the left
                AI1.Top = rnd.Next(100, 200) * -1; //random numbers where they appear on the top
            }
            if (AI2.Top > panel1.Height)
            {
                changeAI2(); //change the AI images once theyve left the screen
                AI2.Left = rnd.Next(185, 327); //random numbers where they appear on the left
                AI2.Top = rnd.Next(100, 200) * -1; //random numbers where they appear on the top
            }
            //end of respawing the AIs and image changing

            //hit test the player and the AIs
            //below if statement is checking multiple conditions
            //if player one hits AI1 or player hits AI2
            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver();//this will run if a player hits a AI
            }
            //end of hit testing the player

            //speed up the traffic
            //below we are checking for multiple conditions
            //if score in above 1000 AND below 500
            if (Score > 500 && Score < 500)
            {
                trafficSpeed = 6;
                roadSpeed = 7;
            }
            if (Score > 500 && Score < 1000)
            {
                trafficSpeed = 7;
                roadSpeed = 8;
            }
            if (Score > 1200)
            {
                trafficSpeed = 9;
                roadSpeed = 10;
            }
            //end of traffic speeding up
        }

        private void moveCar(object sender, KeyEventArgs e)
        {
            //if the player pressed the left key AND the player is inside the pannel
            //then we set the players move leftbooleon to true
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                carLeft = true;
            }
            //if player pressed the right key and the player left plus width is less than the panel1 width
            //then we set the player right to true
            if (e.KeyCode == Keys.Right && player.Left + player.Width < panel1.Width)
            {
                carRight = true;
            }
        }

        private void stopCar(object sender, KeyEventArgs e)
        {
            // if the LEFT key is up then we set the car left to false
            if (e.KeyCode == Keys.Left)
            {
                carLeft = false;
            }
            //if the RIGHT key is up we can set the car right to false
            if (e.KeyCode == Keys.Right)
            {
                carRight = false;
            }
        }

        private void changeAI1()
        {
            int num = rnd.Next(1, 8);//we set up a local variable to generate a number between 1 and 8
            //by using a switch statement we can show any image bassed on that number
            //switch statement will check which number has been generated and will disipher the images as requested
            switch (num)
            {
                //if the number generated is one then we choose the green car
                case 1:
                    AI1.Image = Properties.Resources.carGreen;
                    break;
                //if the number generated is two then we choose the grey car
                case 2:
                    AI1.Image = Properties.Resources.carGrey;
                    break;
                //if the number generated is three then we choose the organge
                case 3:
                    AI1.Image = Properties.Resources.carOrange;
                    break;
                //four -- > pink   
                case 4:
                    AI1.Image = Properties.Resources.carPink;
                    break;
                //fuve -- > red
                case 5:
                    AI1.Image = Properties.Resources.CarRed;
                    break;
                //four -- > blue truck
                case 6:
                    AI1.Image = Properties.Resources.TruckBlue;
                    break;
                //four -- > white truck
                case 7:
                    AI1.Image = Properties.Resources.TruckWhite;
                    break;
                //four -- > ambulance
                case 8:
                    AI1.Image = Properties.Resources.ambulance;
                    break;
                default:
                    break;
            }
        }

        private void changeAI2()
        {
            int num = rnd.Next(1, 8);//we set up a local variable to generate a number between 1 and 8
            //by using a switch statement we can show any image bassed on that number
            //switch statement will check which number has been generated and will disipher the images as requested
            switch (num)
            {
                //if the number generated is one then we choose the green car
                case 1:
                    AI2.Image = Properties.Resources.carGreen;
                    break;
                //if the number generated is two then we choose the grey car
                case 2:
                    AI2.Image = Properties.Resources.carGrey;
                    break;
                //if the number generated is three then we choose the organge
                case 3:
                    AI2.Image = Properties.Resources.carOrange;
                    break;
                //four -- > pink   
                case 4:
                    AI2.Image = Properties.Resources.carPink;
                    break;
                //fuve -- > red
                case 5:
                    AI2.Image = Properties.Resources.CarRed;
                    break;
                //four -- > blue truck
                case 6:
                    AI2.Image = Properties.Resources.TruckBlue;
                    break;
                //four -- > white truck
                case 7:
                    AI2.Image = Properties.Resources.TruckWhite;
                    break;
                //four -- > ambulance
                case 8:
                    AI2.Image = Properties.Resources.ambulance;
                    break;
                default:
                    break;
            }

        }

        private void gameOver()
        {
            trophy.Visible = true; //change the trophy to visible

            timer1.Stop(); //stop the timer

            button1.Enabled = true; //enable the button so we can use it now

            //showing the exsplosion on top of the car image
            exsplosion.Visible = true; //makes the image visible
            player.Controls.Add(exsplosion); //add the exsplsoion image on top of the player
            exsplosion.Location = new Point(-8, 5); // we are moving the image so it is suitably positioned
            exsplosion.BackColor = Color.Transparent; //changes the backgroud to transparent
            exsplosion.BringToFront(); //bring to front of player image

            //finale score trophy
       
            //if the player got score less than 1000 we give them a bronze 
            if(Score < 1000)
            {
                trophy.Image = Properties.Resources.bronze;
            }
            //if player scored more than 2000
            if(Score > 2000)
            {
                trophy.Image = Properties.Resources.silver;
            }
            if (Score > 3500)
            {
                trophy.Image = Properties.Resources.gold;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
