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
        public Form1()
        {
            InitializeComponent();
        }
    }
}
