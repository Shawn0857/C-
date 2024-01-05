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

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            int threshold = 10;
            int userInput = int.Parse(textBoxInput.Text);
            if (userInput > threshold) {
                labelComparison.Text = "greater than 10";
            }
            else {
                labelComparison.Text = "10 or less";
            }
        }

        private void buttonLogical_Click(object sender, EventArgs e)
        {
            bool check1 = checkBoxA.Checked;
            bool check2 = checkBoxB.Checked;
            if (check1 && check2)
            {
                labelLogicResult.Text = "both boxes are checkes";
            }
            else {
                labelLogicResult.Text = "at least one box is unchecked";
            }
        }

        private void buttonTernary_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textBoxAge.Text);
            string eligibility = (age >= 18) ? "you are eligibility to vote" : "you are not eligibility to vote";
            labelEligible.Text = eligibility;
        }

        private void buttonlncrement_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBoxValue.Text);
            number++;
            textBoxValue.Text = number.ToString();
        }

        private void buttonDecrement_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBoxValue.Text);
            number--;
            textBoxValue.Text = number.ToString();
        }
    }
}
