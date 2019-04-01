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
        private perLibrary songs;
        public String[] userSong = new String[14];
        Form1 theForm = new Form1();

        



        public mainCollecion(Student aStudent)//passing in aStudent 
        {
           
            currentStudent = aStudent ;
           
            InitializeComponent();
        }
       
        private void goToLibrary_Click(object sender, EventArgs e)
        {
            //currentStudent = new Student(userSong[13]);
            songs = new perLibrary(currentStudent);

            songs.Show();

           
        }

        
        
        public override  String ToString()//<-----override thing
        {
          return currentStudent.getName();
        }


        private void mainCollecion_Load(object sender, EventArgs e)
        {

            stuName.Text = currentStudent.getName(); //displays name enterd by user
            currentStudent.setName(stuName.Text);
        }

        private void stuName_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)///someone you loved 
        {
            //need to add track array location one to userSong array
            //OR just add a strng to array
            userSong[0] = Tracks[0];
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//
        {
            userSong[1] = Tracks[1];
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)//
        {
            userSong[2] = Tracks[2];
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)//
        {
            userSong[3] = Tracks[3];
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)//
        {
            userSong[4] = Tracks[4];
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)//
        {
            userSong[5] = Tracks[5];
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)//
        {
            userSong[6] = Tracks[6];
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)//
        {
            userSong[7] = Tracks[7];
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)//
        {
            userSong[8] = Tracks[8];
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)//
        {
            userSong[9] = Tracks[9];
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)//
        {
            userSong[10] = Tracks[10];
        }
        private void checkBox12_CheckedChanged(object sender, EventArgs e)//
        {
            userSong[11] = Tracks[11];
        }
        private void checkBox13_CheckedChanged(object sender, EventArgs e)//
        {
            userSong[12] = Tracks[12];
        }
        private void checkBox14_CheckedChanged(object sender, EventArgs e)//
        {
            userSong[13] = Tracks[13];
        }
        
    }
}
    

