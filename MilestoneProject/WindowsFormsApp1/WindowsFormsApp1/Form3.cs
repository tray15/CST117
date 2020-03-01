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
    public partial class Form3 : Form
    {
        public InventoryItem ItemToEdit { get; private set; }
        public int oldIndex { get; private set; }
        public Form3(InventoryItem itemToEdit)
        {
            InitializeComponent();
            this.ItemToEdit = itemToEdit;
            textBox1.Text = itemToEdit.Name;
            textBox2.Text = itemToEdit.Price.ToString();
            textBox3.Text = itemToEdit.Quantity.ToString();
            textBox4.Text = itemToEdit.Par.ToString();
            textBox5.Text = itemToEdit.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = new InventoryItem(textBox1.Text, Decimal.Parse(textBox2.Text, System.Globalization.NumberStyles.AllowCurrencySymbol | System.Globalization.NumberStyles.Number), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text);

            this.ItemToEdit = item;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
