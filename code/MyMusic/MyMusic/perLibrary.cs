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
        
        String[] Tracks = { "someone you loved - Lewis Capaldi", "giant - Calvin Harris & Rag'N'Bone Man", "dont call me up - Mabel", "break up with your girlfriend im bored - Ariana Grande", "dancing with a stranger - Sam SMith & Naormani", "7 rings - Ariana Grande ", "sucker - Jonas brothers ", "disaster - Dave ft Hus", " streatham - Dave", " just you and i - Tom Walker", " location - Dave ft Burna Boy", " walk me home - Pink ", "im so tierd - Lauva& Troy Sivan", " options - NSG ft Tion Wayne" };
        List<String> nowArray;

        //StringBuilder letterGuessedCorrect = new StringBuilder();// ithink i need string builder to add to my array
        public perLibrary(Student aPerson)
        {

            listBox1.Items.Clear();
            InitializeComponent();
            nowArray = aPerson.getMyCOllection().ToList<String>(); // converts to array to list
            nowStudent = aPerson;
            label2.Text = nowStudent.getName();

        }
    
       
        

        private void textBoxSongs_TextChanged(object sender, EventArgs e)
        {

            //a for loop for the array printing out th e each string in differnt lines :)

            // textBoxSongs.Text = nowStudent.getMyCOllection();// doesnt work needs the array to be split up into seperate arrays
            //envirment.newLine
             //for (initializer; test-exspression; updater)

             
            textBoxSongs.Text = nowArray[13];//i need to figure out how to get to the next line of the multi line textbox
      

        }

        private void perLibrary_Load(object sender, EventArgs e)
        {
            label2.Text = nowStudent.getName();
        }
        private void label2_Click(object sender, EventArgs e)//to idsplay name
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//my list box
        {
           
        }
    }
}
