

namespace InventoryApp
{
    public class InventoryItem
    {

        private string name;
        private decimal price;
        private int quantity;
        private string description;

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }


        /*
         * create an item in inventory
         */
        public InventoryItem(string name, decimal price, int quantity, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Description = description;
        }

    }
}
