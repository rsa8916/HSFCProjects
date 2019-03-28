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
        public Student thePerson;//created my student
        public Form1()
        {
            InitializeComponent();
            
        }
      
        private void studentsUserName_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            //need to store the users name
            name = studentsUserName.Text;//allocating users name to name
            thePerson = new Student(name);//allocating the name to the person

            //and check if they are the on the 'system'
            //opening a new form aka main collection
            music = new mainCollecion(thePerson);//constructer
            //passing though the the users name to te second class
            music.Show();

            
        }
       
        
    }
}
