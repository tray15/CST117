using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject5
{
    public partial class Form1 : Form
    {
        public static int luckyNum = 0;
        public static int year = 0;
        public static int month = 0;
        public static int day = 0;
        public Form1()
        {
            InitializeComponent();

            var years = new List<int>();
            for (int i = 1940; i <= DateTime.Now.Year; i++)
            {
                years.Add(i);
            }
            foreach (var year in years)
            {
                comboBox1.Items.Add(year.ToString());
            }

            string[] months =
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            for (int i = 0; i < 12; i++)
            {
                comboBox2.Items.Add(months[i].ToString());
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            year = Convert.ToInt32(comboBox1.SelectedItem);
            month = comboBox2.SelectedIndex + 1;
            day = Convert.ToInt32(comboBox3.SelectedItem);

            luckyNum = year/250 + month + day - 7;

            Form2 form2 = new Form2();
            form2.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateDays();
        }
        private void calculateDays()
        {
            comboBox3.Items.Clear();
            var days = DateTime.DaysInMonth(Convert.ToInt32(comboBox1.SelectedItem), (Convert.ToInt32(comboBox2.SelectedIndex + 1)));
            for (int i = days; i > 0; i--)
            {
                comboBox3.Items.Add(days);
                days--;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            calculateDays();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
