using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using myMusicTwo.Properties;

namespace myMusicTwo
{
    public partial class Form1 : Form
    {
        string fileContent = Resources.music;
        public Form1()
        {
            InitializeComponent();
            StringReader reader = new StringReader(fileContent);
        }

      //  String line;
        
           //   while ((line = reader.ReadLine()) != null) 

          //    { 


        
         //              tracks[nextFreeLocation] = line; 

            //           nextFreeLocation++; 

          // }
          

    private void button1_Click(object sender, EventArgs e) //load button
        {
            listBox1.Items.Clear();// cleared of "listBox1"

            if (checkBox1.Checked)//condtion
                listBox1.Items.Add(checkBox1.Text);//adding acdc 
            if (checkBox2.Checked)
                listBox1.Items.Add(checkBox2.Text);//ect
            if (checkBox3.Checked)
                listBox1.Items.Add(checkBox3.Text);
            if (checkBox4.Checked)
                listBox1.Items.Add(checkBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)//clear button
        {
            listBox1.Items.Clear();//clearing the list box :)
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

       

         

        // read in the strings and store in my tracksarray 

         
        
        // Whilst we would normally associate a file with a path e.g.C:/users/mbr this technique is rarely portable as all of our paths are different. 


        //It is better instead to put the file in Resources and access it from there




        //first create your file using notepad, enter your titles, one per line; now save as music.txt





        //In Visual Studio, once you've created your project go to:  

        // Project -> <name of project> properties -> Resources

        // choose Files from the pull down

        //Add existing file(then browse to a file e.g.music) that you have already created 



        // add these to Using at the top 

        //  using System.IO;                // You need this for file handling //done

        //   using MyMusic.Properties;   // You need this to access your Resources //done





        //  string fileContent = Resources.music;

        //  StringReader reader = new StringReader(fileContent);

        // read in the strings and store in my tracksarray 

        //  String line;  

        //      while ((line = reader.ReadLine()) != null) 

        //      { 



        //                  tracks[nextFreeLocation] = line; 

        //                nextFreeLocation++; 

        //} 
    }
}
