public class Product
{
    /* Encapsulation application */
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    /* Constructor with its parameters, later assigned properties to pass values through */
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    /* Method to calculate the total cost by multiplying price by quantity */
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    /* Method to return the format how the packing label it's going to be shown */
    public string GetPackingLabel()
    {
        return $"{_name} x{_quantity} (ID: {_productId})";
    }
}