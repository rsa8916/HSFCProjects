using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackQueueProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stacks s1 = new Stacks(100);
        int i;
        Boolean switchQueue = true;

        private void button1_Click(object sender, EventArgs e)//push
        {
            i = Convert.ToInt32(textBox1.Text);
            s1.Push(i);

            if(switchQueue == false)
            {
                button1.Text = "EnQueue";
            }
        }

        private void button2_Click(object sender, EventArgs e)//pop
        {
            s1.Pop();
            textBox1.Text = s1.GetTop().ToString();
            if(switchQueue == false)
            {
                button2.Text = "DeQueue";

            }
            else
        }

        private void button3_Click(object sender, EventArgs e)//switch to queue button
        {
            switchQueue = false;
            if (switchQueue == false)
            {
                button2.Text = "DeQueue";

            }
            else
        }
    }
}
