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
    public partial class mainCollecion : Form
    {
        private perLibrary songs;
        public mainCollecion()
        {
            InitializeComponent();
        }

        private void goToLibrary_Click(object sender, EventArgs e)
        {
            songs = new perLibrary();
            songs.Show();
        }
    }
}
