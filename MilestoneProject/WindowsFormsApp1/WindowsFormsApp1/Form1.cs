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
    public partial class Form1 : Form
    {
        private static Form1 context = new Form1();
        public static Form1 Context { get { return context; } }
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void addToList(InventoryItem item)
        {
            listView1.Items.Add(new ListViewItem(new string[] {item.Name, Convert.ToString(item.Price), Convert.ToString(item.Quantity), item.Description} ));
        }
    }
}
