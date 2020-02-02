using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int secondsInAMinute = 60;
            const int secondsInAnHour = 3600;
            const int secondsInADay = 86400;
            double enteredSeconds = Double.Parse(textBox1.Text);
            double days = 0;
            double hours = 0;
            double minutes = 0;
            double seconds = 0;
            double remainingSeconds;


            if (string.IsNullOrWhiteSpace(textBox1.Text))
                return;

            try
            {
                if (enteredSeconds >= secondsInADay)
                {
                    days = enteredSeconds / secondsInADay;
                    remainingSeconds = enteredSeconds % secondsInADay;

                    if (remainingSeconds >= secondsInAnHour)
                    {
                        hours = remainingSeconds / secondsInAnHour;
                        remainingSeconds = remainingSeconds % secondsInAnHour;

                        if (remainingSeconds >= secondsInAMinute)
                        {
                            minutes = remainingSeconds / secondsInAMinute;
                            remainingSeconds = remainingSeconds % secondsInAMinute;
                            seconds = remainingSeconds;
                        }
                    } else if (remainingSeconds >= secondsInAMinute)
                    {
                        minutes = remainingSeconds / secondsInAMinute;
                        remainingSeconds = remainingSeconds % secondsInAMinute;
                        seconds = remainingSeconds;
                    } else
                    {
                        seconds = remainingSeconds;
                    }
                }
                label3.Text = string.Format("{0:0} day(s) {1:0} hour(s) {2:0} minute(s) {3:0} second(s)", (int)days, (int)hours, (int)minutes, (int)seconds);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
