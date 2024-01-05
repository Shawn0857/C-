using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtHeight.MaxLength = 3;  //設最多只能輸入3位數
            Txtweight.ReadOnly = true;  //設為唯讀不能輸入
            TxtHeight.TabIndex = 0;  //設為第一個停駐焦點
            TxtHeight.Text = "170";  //設定預設值  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            int height = Convert.ToInt32(TxtHeight.Text);  //字串轉成整數
            double weight = (height - 170) * 0.6 + 62;  //計算標準體重
            Txtweight.Text = weight.ToString("f1") + "公斤";  //顯示標準體重
            TxtHeight.Focus();  //將停駐焦點移到TxtHeight
            */


            try
            {
                int height = Convert.ToInt32(TxtHeight.Text);
                double weight = (height - 170) * 0.6 + 62;
                Txtweight.Text = weight.ToString("f1") + "公斤";
            }
            catch 
            {
                Txtweight.Text = "請輸入整數";
                TxtHeight.Clear();
            }
            TxtHeight.Focus();
        }
    }
}
