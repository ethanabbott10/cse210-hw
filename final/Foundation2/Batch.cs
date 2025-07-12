public class Batch
{
    private List<Order> _orders = new List<Order>();

    public Batch() { }

    public void DisplayOrders()
    {
        Console.Clear();

        foreach (Order order in _orders)
        {
            Console.WriteLine();
            order.DisplayOrder();
            Console.WriteLine();
        }
    }

    public void AddOrder(Order order)
    {
        _orders.Add(order);
    }
}