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
            double n1;
            double n2;
            try
            {
                n1 = double.Parse(textBox1.Text);
                n2 = double.Parse(textBox2.Text);
            }
            catch
            {
                label4.Text = "erroe";
                return;
            }
            switch (textBox3.Text)
            {
                case "+": label4.Text = "结果 " + (n1 + n2);break;
                case "-": label4.Text = "结果 " + (n1 - n2); break;
                case "*": label4.Text = "结果 " + n1 * n2; break;
                case "/": 
                    if(n2!=0)
                        label4.Text = "结果 " + n1 / n2;
                    else
                        label4.Text = "error"; break;
                default:label4.Text = "error";break;
            }
        }
    }
}
