using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test0912_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score1 , score2 , score3;
            double finalScore;

            score1 = int.Parse(textBox1.Text);
            score2 = int.Parse(textBox2.Text);
            score3 = int.Parse(textBox3.Text);

            finalScore = score1 * 0.3 + score2 * 0.3 + score3 * 0.4;

            textBox4.Text = Convert.ToString(finalScore);
        }
    }
}
