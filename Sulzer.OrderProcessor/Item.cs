namespace Sulzer.OrderProcessor
{
    public class Item
    {
        private string Name { get; set; }
        private int Quantity { get; set; }
        private decimal UnitPrice { get; set; }

        public Item(string name, int quantity, decimal unitPrice)
        {
            Name = name;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
        
        public decimal GetItemPrice()
        {
            decimal itemTotal = Quantity * UnitPrice;

            // Apply 10% discount if quantity is 3 or more
            if (Quantity >= 3)
            {
                itemTotal *= 0.9m;
            }

            return itemTotal;
        }
    }
}
