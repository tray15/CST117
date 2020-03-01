using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    class InventoryManager
    {
        //private InventoryItem[] m_CurrentInventory;
        private List<InventoryItem> m_CurrentInventory = new List<InventoryItem>();

        public InventoryManager()
        {
            //this.m_CurrentInventory = new InventoryItem[0];
            this.m_CurrentInventory = new List<InventoryItem>();

        }

        public void AddItem(InventoryItem item)
        {
            /*
            // check to see if the inventory already contains an item with that name
            if (this.m_CurrentInventory.Any(x => x.Name == item.Name))
                return;

             resize array
            Array.Resize(ref this.m_CurrentInventory, this.m_CurrentInventory.Length + 1);

            this.m_CurrentInventory[this.m_CurrentInventory.Length - 1] = item;
            */
            if (this.m_CurrentInventory.Any(x => x.Name == item.Name))
                return;
            this.m_CurrentInventory.Add(item);
        }
        public void editItem(int oldIndex, InventoryItem item)
        {
            this.m_CurrentInventory[oldIndex] = item;
        }
        public void RemoveItem(InventoryItem item)
        {
            /*
            var index = Array.IndexOf(this.m_CurrentInventory, item);
            if (index < 0)
                //return;

            this.m_CurrentInventory[index] = null;

            this.m_CurrentInventory = this.m_CurrentInventory.Where((source, idx) => idx != index).ToArray();
            */
            this.m_CurrentInventory.Remove(item);

        }
        public void restock(InventoryItem item)
        {
            if (item.Quantity < item.Par)
            {
                int temp = item.Quantity;
                item.Quantity += item.Par - temp;
                //Console.WriteLine(item.Quantity);
            } else if (item.Quantity >= item.Par)
            {
                string message = item.Name + " stock is maxed. Order not placed.";
                string title = "Error";
                MessageBox.Show(message, title);
                //Console.WriteLine("Stock is maxed. Order not placed.");
            }
        }
        public void displayItems()
        { 
            foreach (var item in this.m_CurrentInventory)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public List<InventoryItem> getInventoryList()
        {
            return this.m_CurrentInventory;
        }
        public InventoryItem ItemLookUp(string name, decimal price, int quantity, int par, string description)
        {
            foreach (var item in m_CurrentInventory)
            {
                if (item.Name == name && item.Price == price && item.Quantity == quantity && item.Par == par && item.Description == description)
                {
                    return item;
                }
            }
            return null;
        }
        public List<InventoryItem> search(string itemName, int quantity = 0)
        {
            var results = this.m_CurrentInventory.Where(x => x.Name.ToLower().Contains(itemName.ToLower()));
            if (quantity != 0)
            {
                results = results.Union(this.m_CurrentInventory.Where(x => x.Quantity.Equals(quantity)));
            }

            return results.ToList();
        }
        public int getIndex(InventoryItem item)
        {
            return this.m_CurrentInventory.IndexOf(item);
        }
    }
}
