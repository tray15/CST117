

namespace InventoryApp
{
    public class InventoryItem
    {
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
            return string.Format(string.Format("{0} {1} {2} {3} {4}", Name, Price, Quantity, Par, Description));
        }

    }
}
