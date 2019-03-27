using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;//you need this for file handling
using MyMusic.Properties;//i need this to access you resources
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMusic
{
   
    public partial class mainCollecion : Form
    {
        //need to create an array of all the tracks.
        String[] Tracks = { "someone you loved - Lewis Capaldi", "giant - Calvin Harris & Rag'N'Bone Man", "dont call me up - Mabel", "break up with your girlfriend im bored - Ariana Grande", "dancing with a stranger - Sam SMith & Naormani", "7 rings - Ariana Grande ", "sucker - Jonas brothers ", "disaster - Dave ft Hus", " streatham - Dave", " just you and i - Tom Walker", " location - Dave ft Burna Boy", " walk me home - Pink ", "im so tierd - Lauva& Troy Sivan", " options - NSG ft Tion Wayne" };
        private Student currentStudent;
   //an array that hold the text file of all the tracks <---------   I think is right
        private perLibrary songs;
        
        public mainCollecion(Student aStudent)
        {
            currentStudent = aStudent ;
            InitializeComponent();
        }

        private void goToLibrary_Click(object sender, EventArgs e)
        {
            songs = new perLibrary();
            songs.Show();
        }

        private void textFileBox_TextChanged(object sender, EventArgs e)
        {
            //this is what i did on text files
            //im trying to get the textFileBox to display the music in resources
            //  textFileBox = Tracks.DisplayResources();
           // textFileBox.Update();

            // a idea... textFileBox.Text = File.ReadAllText(music);
            // this is all on TEXT FILES that Mark did
            //  string fileContent = Resources.music;

            // StringReader reader = new StringReader(fileContent);

            // read in the strings and store in my tracksarray 

            // String line;

            // while ((line = reader.ReadLine()) != null)

            //  {



            //   tracks[nextFreeLocation] = line;

            //     nextFreeLocation++;

        }

        private void mainCollecion_Load(object sender, EventArgs e)
        {
            stuName.Text = currentStudent.ToString(); //<-----------Displayed MyMusic.Student do and overide
        }

        private void stuName_Click(object sender, EventArgs e)
        {

           
        }
  
       
    }
}
    

