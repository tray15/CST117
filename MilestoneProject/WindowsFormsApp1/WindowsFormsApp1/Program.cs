using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    static class Program
    {
        public static Form1 form1;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form1 = new Form1());

            //Console testing methods
            /*
            Console.WriteLine("Test");
            InventoryManager im = new InventoryManager();
            InventoryItem i1 = new InventoryItem("item1", 120.00m, 30, 100, "item1 Test");
            InventoryItem i2 = new InventoryItem("item2", 20.00m, 40, 300, "item2 Test");
            InventoryItem i3 = new InventoryItem("item3", 220.00m, 50, 110, "item3 Test");
            InventoryItem i4 = new InventoryItem("item4", 500.00m, 150, 150, "item4 Test");
            im.AddItem(i1);
            im.displayItems();
            Console.WriteLine("item1 added!");
            im.AddItem(i2);
            im.displayItems();
            Console.WriteLine("item2 added!");
            im.AddItem(i3);
            im.displayItems();
            Console.WriteLine("item3 added!");
            im.AddItem(i4);
            im.displayItems();
            Console.WriteLine("item4 added!");
            im.RemoveItem(i3);
            Console.WriteLine("item3 removed!");
            im.displayItems();
            im.nameSearch("item2");
            im.nameSearch("item3");
            im.quantitySearch(30);
            im.quantitySearch(35);
            im.restock(i1);
            im.restock(i4);
            */

        }
    }
}