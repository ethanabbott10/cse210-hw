using System.ComponentModel;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _totalOrderPrice;
    private double _shippingCost;
    private string _packingLablel;
    private string _shippingLabel;

    public Order() { }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void SetTotalOrderPrice()
    {
        foreach (Product product in _products)
        {
            _totalOrderPrice += product.GetTotalProductPrice();
        }

        _totalOrderPrice += _shippingCost;
    }

    public void DisplayOrder()
    {
        SetShippingLabel();
        Console.WriteLine();
        SetPackingLabel();
        Console.WriteLine();
        Console.WriteLine(GetTotalOrderPrice());
        Console.WriteLine();
    }

    public double GetTotalOrderPrice()
    {
        return _totalOrderPrice;
    }

    public void SetPackingLabel()
    {
        foreach (Product product in _products)
        {
            _packingLablel = _packingLablel + $"{product.GetProductId}: " + $"{product.GetName}" + "\n";
        }

    }

    public void SetShippingLabel()
    {
        _shippingLabel = $"{_customer.GetName()}\n{_customer.GetAddress().GetStreetAddress()}\n{_customer.GetAddress().GetCity()}, {_customer.GetAddress().GetState()}, {_customer.GetAddress().GetCountry}";
    }
}