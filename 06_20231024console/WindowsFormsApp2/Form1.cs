using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "hello") {
                label1.Text = "hello";
            }
            else { 
                label1.Text = "try typeing hello";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a  = int.Parse(textBox2.Text);
            if (a>50) {
                label2.Text = "老了不好";
            }
            else {
                label2.Text = "年輕真好";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string color = comboBox1.SelectedItem.ToString();

            switch (color)
            {
                case "red": this.BackColor = Color.Red; break;
                case "green": this.BackColor = Color.Green; break;
                case "bule": this.BackColor = Color.Blue; break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool a = checkBox1.Checked;
            label3.Text = a ? "checked" : "not checked ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string input = textBox3.Text;
            string message = string.IsNullOrEmpty(input) ? "enter someing " : "you end " + input;
            label4.Text = message;
        }
    }
}
