using System.Diagnostics.Contracts;

public class Product
{
    private int _productId;
    private string _name;
    private double _pricePerUnit;
    private int _quantity;
    private double _totalProductPrice;

    public Product(int productId, string name, double pricePerUnit, int quantity)
    {
        _productId = productId;
        _name = name;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
        _totalProductPrice = Math.Round(pricePerUnit * quantity, 2);
    }

    public int GetProductId()
    {
        return _productId;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetTotalProductPrice()
    {
        return _totalProductPrice;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}