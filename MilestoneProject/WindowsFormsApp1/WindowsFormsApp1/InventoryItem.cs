

namespace InventoryApp
{
    public class InventoryItem
    {

        private string name;
        private decimal price;
        private int quantity;
        private int par;
        private string description;

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Par { get; set; }
        public string Description { get; set; }


        /*
         * create an item in inventory
         */
        public InventoryItem(string name, decimal price, int quantity, int par, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Par = par;
            this.Description = description;
        }

        public override string ToString() {
            return string.Format(string.Format("Item Name: {0}, Price: {1}, Quantity: {2}, Par: {3}, Description: {4}", Name, Price, Quantity, Par, Description));
        }

    }
}
