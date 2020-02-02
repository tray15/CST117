using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            l_result.Visible = false;
            l_answer.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int oddNumber = 1;
            double pi = 0.0;
            int userNumber = 0;

            Int32.TryParse(tb_userNumber.Text, out userNumber);
            for (int i = 1; i <= userNumber; i++)
            {
                double currentNum = 0.0;
                if (i % 2 == 0)
                {
                    currentNum = (double)-4 / oddNumber;
                } else
                {
                    currentNum = (double)4 / oddNumber;
                }

                oddNumber = oddNumber + 2;
                pi = pi + currentNum;
                string result = pi.ToString();
                l_result.Text = "Approximate value of pi after " + userNumber + " terms";
                l_result.Visible = true;
                l_answer.Text = "= " + result;
                l_answer.Visible = true;
            }
        }
    }
}
