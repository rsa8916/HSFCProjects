using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUI
{
    public partial class Form1 : Form
    {
        Person p1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p1 = new Person("unassinged");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1.setName(nameBox.Text);
            p1.setAge(Convert.ToInt32(ageBox.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameBox.Text = p1.getName();
            ageBox.Text = p1.getAge().ToString();
        }
    }
}
