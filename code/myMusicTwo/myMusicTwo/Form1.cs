using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myMusicTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

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
    }
}
