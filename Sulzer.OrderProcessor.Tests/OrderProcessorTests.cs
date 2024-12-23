using System.Diagnostics;

namespace Sulzer.OrderProcessor.Tests
{
    public class OrderProcessorTests
    {

        [Test]
        public void TestEmptyOrder()
        {
            // Create an empty order
            var emptyOrder = new Order(new List<Item>());

            // Calculate the total
            decimal total = emptyOrder.CalculateTotal();

            // Ensure that the total is 0
            Assert.That(total, Is.EqualTo(0));
        }

        [Test]
        public void TestOrderWithTotal100()
        {
            // Create an order with items that total $100
            var order = new Order(new List<Item>
            {
                new Item("Item 1", 1, 100.00m)
            });

            // Calculate the total
            decimal total = order.CalculateTotal();

            // Ensure that the total is $100
            Assert.That(total, Is.EqualTo(100));
        }

        [Test]
        public void TestLargeOrder()
        {
            // Create a large order with 100,000 items
            var items = new List<Item>();
            for (int i = 0; i < 1000000; i++)
            {
                items.Add(new Item("Item " + i, 3, 10.00m)); // Simulate items with 3 units each
            }

            var largeOrder = new Order(items);

            // Measure the time taken to calculate the total
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            decimal total = largeOrder.CalculateTotal();

            stopwatch.Stop();

            // Ensure that the order total calculation does not take too long
            Console.WriteLine($"Total Order Price: ${total}");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");

            // You can assert something based on expected results, for example:
            Assert.IsTrue(stopwatch.ElapsedMilliseconds < 500, "Calculation should complete in under 1 second");
        }
    }
}