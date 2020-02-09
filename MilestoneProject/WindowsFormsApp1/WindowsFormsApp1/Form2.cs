using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InventoryItem i = new InventoryItem(textBox1.Text, Decimal.Parse(textBox2.Text, System.Globalization.NumberStyles.AllowCurrencySymbol | System.Globalization.NumberStyles.Number), Convert.ToInt32(textBox3.Text), textBox4.Text);
            Program.form1.addToList(i);
            this.Close();
        }
    }
}
