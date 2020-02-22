using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    class InventoryManager
    {
        private InventoryItem[] m_CurrentInventory;

        public InventoryManager()
        {
            this.m_CurrentInventory = new InventoryItem[0];
        }

        public void AddItem(InventoryItem item)
        {
            // check to see if the inventory already contains an item with that name
            if (this.m_CurrentInventory.Any(x => x.Name == item.Name))
                return;

            // resize array
            Array.Resize(ref this.m_CurrentInventory, this.m_CurrentInventory.Length + 1);

            this.m_CurrentInventory[this.m_CurrentInventory.Length - 1] = item;
        }
        public void RemoveItem(InventoryItem item)
        {
            var index = Array.IndexOf(this.m_CurrentInventory, item);
            if (index < 0)
                return;

            this.m_CurrentInventory[index] = null;

            this.m_CurrentInventory = this.m_CurrentInventory.Where((source, idx) => idx != index).ToArray();
        }
        public void restock(InventoryItem item)
        {
            if (item.Quantity < item.Par)
            {
                int temp = item.Quantity;
                item.Quantity += item.Par - temp;
                Console.WriteLine(item.Quantity);
            } else if (item.Quantity <= item.Par)
            {
                Console.WriteLine("Stock is maxed. Order not placed.");
            }
        }
        public void displayItems()
        {
            foreach (var item in this.m_CurrentInventory)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void nameSearch(String name)
        {
            bool foundName = false;
            var search = this.m_CurrentInventory.Where(i => i.Name.Contains(name));
            foreach (var result in search)
            {
                Console.WriteLine("Items with name " + name + " found: {0}", result);
                foundName = true;
            } 
            if (foundName == false)
            {
                Console.WriteLine("No items found with name: " + name + ".");
            }
        }
        public void quantitySearch(int quantity)
        {
            bool foundItem = false;
            var search = this.m_CurrentInventory.Where(i => i.Quantity.ToString().Contains(quantity.ToString()));
            foreach (var result in search)
            {
                Console.WriteLine("Items with quantity " + quantity + "  found: {0}", result);
                foundItem = true;
            }
            if (foundItem == false)
            {
                Console.WriteLine("No items found with quantity of " + quantity + ".");
            }
        }
    }
}
