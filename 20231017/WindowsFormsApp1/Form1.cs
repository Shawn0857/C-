using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value1 = 5;
            int value2 = 10;
            label1.Text = (value1 + value2).ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = (trackBar1.Value*5).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string firstName = "join";
            string lastName = "Doe";
            label3.Text = firstName + "" + lastName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isChecked = checkBox1.Checked;
            label4.Text = isChecked.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int val = int.Parse(textBox1.Text);
            label5.Text = (val * 10).ToString();
        }
    }
}
