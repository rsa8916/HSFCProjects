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
           if(KEyCOde ==)
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
           
        }

       
    }
}
