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
    
    public partial class Form1 : Form
    {

        private mainCollecion music; //need this to create a object aka a button to open a new form
        public String name;
        
        public Form1()
        {
            InitializeComponent();
        }
      
        private void studentsUserName_TextChanged(object sender, EventArgs e)
        {
            //need to store the users name
            name = studentsUserName.Text;
           
            //and check if they are the on the 'system'

        }
        public void setName(String name)
        {
            this.Name = name;
        } 
        public String getName()
        {
            return name;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            //opening a new form aka main collection
            music = new mainCollecion();
            music.Show();

            
        }
        //this creates a new student but its proberly in the wronge place
        Student Rose = new Student();
    }
}
