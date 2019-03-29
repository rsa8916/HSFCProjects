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
        int i = 0;
        public String[] nowArray = new String[14];//??????
        //StringBuilder letterGuessedCorrect = new StringBuilder();// ithink i need string builder to add to my array
        public perLibrary(Student aPerson)
        {
            nowArray = aPerson.getMyCOllection();
            nowStudent = aPerson;
            InitializeComponent();
        }
       
        private void textBoxSongs_TextChanged(object sender, EventArgs e)
        {

            //a for loop for the array printing out th e each string in differnt lines :)
            // textBoxSongs.Text = nowStudent.getMyCOllection();// doesnt work needs the array to be split up into seperate arrays

            for (i=0; 1<14; i++)
            {
                if (nowArray[i] == "")
                    i++;
                else
                {
                    textBoxSongs.Text = nowArray[i];//i need to figure out how to get to the next line of the multi line textbox
                    i++;
                }
            }


        }

        private void perLibrary_Load(object sender, EventArgs e)
        {
            label2.Text = nowStudent.getName();
        }
        private void label2_Click(object sender, EventArgs e)//to idsplay name
        {

        }
    }
}
