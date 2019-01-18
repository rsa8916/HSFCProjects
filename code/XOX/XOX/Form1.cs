using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX
{
    public partial class Form1 : Form
    {
        private GameUI myGame;
        public Form1()
        {
            InitializeComponent();
        }

        string playerOneName;
        string playerTwoName;
        

        private void playerOne_TextChanged(object sender, EventArgs e)
        {
            //player one enters there name
            playerOneName = playerOne.Text;
        }

        private void playerTwo_TextChanged(object sender, EventArgs e)
        {
            //player two enters there name
            playerTwoName = playerTwo.Text;
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            //the user clicks START 
            //collect the two names and pass them into the Game engine
           myGame = new XOX.GameUI( playerOneName, playerTwoName);
            myGame.Show();
        }
    }
}
