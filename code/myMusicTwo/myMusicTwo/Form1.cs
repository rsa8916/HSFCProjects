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
        int nextFreeLocation = 0;
        string[] tracks = new string[14];
        CheckBox[] boxes;
        String line;


        public Form1()
        {
            InitializeComponent();

            StringReader reader = new StringReader(fileContent);
            while ((line = reader.ReadLine()) != null)
            {
                tracks[nextFreeLocation] = line;
                nextFreeLocation++;
            }

            boxes = new CheckBox[15];
            for (int i = 0; 1 < 14; i++)
            {
               boxes[i] = new CheckBox();
               boxes[i].Text = line;

            }
           
            
        }

        
        private void allocatingButtons()
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e) //load button
        {
            listBox1.Items.Clear();// cleared of "listBox1"
            //my old text boxs
          //  if (checkBox1.Checked)//condtion
          //      listBox1.Items.Add(checkBox1.Text);//adding acdc 
           // if (checkBox2.Checked)
          //      listBox1.Items.Add(checkBox2.Text);//ect
          //  if (checkBox3.Checked)
          //      listBox1.Items.Add(checkBox3.Text);
          //  if (checkBox4.Checked)
         //       listBox1.Items.Add(checkBox4.Text);


           
        }

        private void button2_Click(object sender, EventArgs e)//clear button
        {
            listBox1.Items.Clear();//clearing the list box :)
                                   // checkBox1.Checked = false;
                                   // checkBox2.Checked = false;
                                   // checkBox3.Checked = false;
                                   //checkBox4.Checked = false;
            for (int n = 0; n < 14; n++)
            {
                boxes[n].Checked = false;//clears the check boxes 
            }
            
        }




    }
}
