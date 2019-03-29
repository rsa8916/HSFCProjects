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
    
        String[] Tracks = { "someone you loved - Lewis Capaldi", "giant - Calvin Harris & Rag'N'Bone Man", "dont call me up - Mabel", "break up with your girlfriend im bored - Ariana Grande", "dancing with a stranger - Sam SMith & Naormani", "7 rings - Ariana Grande ", "sucker - Jonas brothers ", "disaster - Dave ft Hus", " streatham - Dave", " just you and i - Tom Walker", " location - Dave ft Burna Boy", " walk me home - Pink ", "im so tierd - Lauva& Troy Sivan", " options - NSG ft Tion Wayne" };
        public perLibrary(Student aPerson)
        {
            nowStudent = aPerson;
            InitializeComponent();
        }
        

        private void textBoxSongs_TextChanged(object sender, EventArgs e)
        {

            //a for loop for the array printing out th e each string in differnt lines :)

            // textBoxSongs.Text = nowStudent.getMyCOllection();// doesnt work needs the array to be split up into seperate arrays

            for (int i=0; 1<14; i++) //for (initializer; test-exspression; updater)

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
