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
        InventoryManager im = new InventoryManager();

        public Form1()
        {
            InitializeComponent();
            InventoryItem i = new InventoryItem("Test", 12.22M, 10, 100, "Test desc");
            InventoryItem i2 = new InventoryItem("two", 2.00M, 2, 200, "Two desc");
            InventoryItem i3 = new InventoryItem("Three", 3.00M, 3, 300, "Three desc");
            InventoryItem i4 = new InventoryItem("Four", 4.00M, 4, 400, "Four desc");
            InventoryItem i5 = new InventoryItem("Five", 5.00M, 5, 500, "Five desc");

            InventoryItem[] items = { i, i2, i3, i4, i5 };
            foreach (var item in items)
            {
                im.AddItem(item);
                listView1.Items.Add(new ListViewItem(new string[] { item.Name, Convert.ToString(item.Price), Convert.ToString(item.Quantity), item.Par.ToString(), item.Description }));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        //remove item
        private void button2_Click(object sender, EventArgs e)
        {
            //get item parameters
            ListViewItem i = listView1.SelectedItems[0];
            i.Remove();

            string name = i.SubItems[0].Text;

            string priceString = i.SubItems[1].Text;
            decimal price;
            Decimal.TryParse(priceString, out price);

            string quantityString = i.SubItems[2].Text;
            int quantity;
            Int32.TryParse(quantityString, out quantity);

            string parString = i.SubItems[3].Text;
            int par;
            Int32.TryParse(parString, out par);
            string description = i.SubItems[4].Text;

            //select item by parameter
            var item = this.im.ItemLookUp(name, price, quantity, par, description);
            this.im.RemoveItem(item);

        }

        //reorder button
        private void button4_Click(object sender, EventArgs e)
        {
            //get item parameters
            ListViewItem i = listView1.SelectedItems[0];

            string name = i.SubItems[0].Text;

            string priceString = i.SubItems[1].Text;
            decimal price;
            Decimal.TryParse(priceString, out price);

            string quantityString = i.SubItems[2].Text;
            int quantity;
            Int32.TryParse(quantityString, out quantity);

            string parString = i.SubItems[3].Text;
            int par;
            Int32.TryParse(parString, out par);
            string description = i.SubItems[4].Text;
            //select item by parameter
            var item = this.im.ItemLookUp(name, price, quantity, par, description);

            this.im.restock(item);
            i.SubItems[2].Text = item.Quantity.ToString();

        }
        //search by name or quantity
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var results = new List<InventoryItem>();

            // check to see if the current text is empty
            if (!string.IsNullOrEmpty(this.textBox1.Text))
            {
                var input = this.textBox1.Text;
                var itemName = input;
                var maybeQuantity = 0;

                // try and parse the text as a number, if it is, we can use this as the quantity
                int.TryParse(input, out maybeQuantity);

                // search for the item in our current inventory
                results = this.im.search(itemName, maybeQuantity);
            }

            // if we didn't have any results, set results to all items
            if (results.Count == 0)
            {
                results = this.im.getInventoryList();
            }

            // clear everything from the list view, we have stuff to add either way
            this.listView1.Items.Clear();

            // loop and add
            foreach (var item in results)
            {
                listView1.Items.Add(new ListViewItem(new string[] { item.Name, Convert.ToString(item.Price), Convert.ToString(item.Quantity), item.Par.ToString(), item.Description }));
            }
        }
        public void addToList(InventoryItem item)
        {
            im.AddItem(item);
            listView1.Items.Add(new ListViewItem(new string[] { item.Name, Convert.ToString(item.Price), Convert.ToString(item.Quantity), item.Par.ToString(), item.Description }));
        }
        //edit item
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem i = listView1.SelectedItems[0];

                string name = i.SubItems[0].Text;

                string priceString = i.SubItems[1].Text;
                decimal price;
                Decimal.TryParse(priceString, out price);

                string quantityString = i.SubItems[2].Text;
                int quantity;
                Int32.TryParse(quantityString, out quantity);

                string parString = i.SubItems[3].Text;
                int par;
                Int32.TryParse(parString, out par);

                string description = i.SubItems[4].Text;

                var item = this.im.ItemLookUp(name, price, quantity, par, description);
                //save old index to
                var oldIndex = this.im.getIndex(item);

                var form3 = new Form3(item);
                var dialogResult = form3.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    im.editItem(oldIndex, form3.ItemToEdit);

                    listView1.Items.Clear();

                    var inventoryList = im.getInventoryList();

                    foreach (var items in inventoryList)
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { items.Name, Convert.ToString(items.Price), Convert.ToString(items.Quantity), items.Par.ToString(), items.Description }));
                    }
                }
            }
        }
    }
}