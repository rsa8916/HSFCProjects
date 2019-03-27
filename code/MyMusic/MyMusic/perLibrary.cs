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
    public partial class perLibrary : Form
    {
        private Student nowStudent;
        public perLibrary(Student aPerson)
        {
            nowStudent = aPerson;
            InitializeComponent();
        }

        private void textBoxSongs_TextChanged(object sender, EventArgs e)
        {
            //a for loop for the array printing out th e each string in differnt lines :)
        }

        private void label2_Click(object sender, EventArgs e)//to idsplay name
        {
          
        }
       public override String ToString()//<-----override thing
        {
          return nowStudent.getName();
        }
        private void perLibrary_Load(object sender, EventArgs e)
        {
            label2.Text = nowStudent.getName();
        }
    }
}
