using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text==null)
            {
                Console.WriteLine("ID is Required");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text==null)
            {
                Console.WriteLine("Name is Required");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //if @ is included in the email address, then it is valid
            if (!textBox5.Text.Contains("@"))
            {
                Console.WriteLine("Email is Invalid");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
