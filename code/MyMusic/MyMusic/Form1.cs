using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMusic
{
    private MainCollection myCollection;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void studentsUserName_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form = new MyMusic.mainCollecion(studentsUserName);
            Form.Show();
            //myGame = new XOX.GameUI( playerOneName, playerTwoName);
           // myGame.Show();
        }
    }
}
