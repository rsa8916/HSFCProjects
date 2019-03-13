using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolRecords
{
    public partial class Form1 : Form
    {
        private Form2 myForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BUTTON_Click(object sender, EventArgs e)
        {
            Person p1 = new Person("Rose Addison", 17);
           // Student s1 = new Student("Bill Smith", 17, theDOS.Teacher);
            Address a1 = new Address("HIghbrook", "Kingsthorn", "Herefordshire", "HR2 8AW");
            myForm = new SchoolRecords.Form2(Person, Student);
            myForm.Show();
        }
    }
}
