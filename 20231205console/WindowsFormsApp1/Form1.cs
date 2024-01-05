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

        private void Form1_Load(object sender, EventArgs e)
        {
            int no = 10;
            int sum = 32;
            int chicken_num;
            string msg = "";

            for (chicken_num = 0; chicken_num < no; chicken_num++) 
            {
                if (2 * chicken_num + 4 * (no - chicken_num) == sum)
                {
                    msg = " 雞有 : " + chicken_num + "隻" + "\n";
                    msg = msg  +" 兔有 : " + (no - Convert.ToInt32(chicken_num)) + "隻" ;
                    break;
                }
            }
            MessageBox.Show(msg,"雞兔問題解法");
        }
    }
}