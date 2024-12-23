namespace Sulzer.OrderProcessor
{
    public class Order
    {
        public List<Item> Items { get; set; }
        public Order(List<Item> items)
        {
            Items = items;
        }
        public decimal CalculateTotal()
        {
            // Calculate total price of items before order-wide discount
            decimal totalPrice = Items.Sum(item => item.GetItemPrice());

            // Apply 5% discount on the total order price if it's greater than $100
            if (totalPrice > 100)
            {
                totalPrice *= 0.95m;
            }

            return totalPrice;
        }
    }
}
