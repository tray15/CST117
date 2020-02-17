using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int caloriesFromFat = 0;
        int caloriesFromCarbs = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            caloriesFromFat = FatCalories(Int32.Parse(textBox1.Text));
            caloriesFromCarbs = CarbCalories(Int32.Parse(textBox2.Text));

            label2.Text = "Calories from fat: " + Convert.ToString(caloriesFromFat);
            label4.Text = "Calories from carbs: " + Convert.ToString(caloriesFromCarbs);
            label5.Text = "Total calories: " + Convert.ToString(caloriesFromFat + caloriesFromCarbs);
            

        }

        private int FatCalories(int caloriesFromFat)
        {
            return caloriesFromFat * 9;                                                                                                                                                                                                                                                                                                                                                                                                                                                                             FatCalories                                                                                                                                                                                                                                                                                         
        }

        private int CarbCalories(int caloriesFromCarbs)
        {
            return caloriesFromCarbs * 4;
        }
    }
}
