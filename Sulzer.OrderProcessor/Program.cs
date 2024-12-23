using Sulzer.OrderProcessor;

public class Program
{
    public static void Main()
    {
        // Input
        var order = new Order(new List<Item>
        {
            new Item("Laptop", 1, 1000.00m),
            new Item("Mouse", 3, 25.00m),
            new Item("Keyboard", 1, 100.00m)
        });
        
        Console.WriteLine("Total Order Price: $" + order.CalculateTotal());
    }
}