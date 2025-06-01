public class Customer
{
    /* Encapsulation application */
    private string _name;
    private Address _address;

    /* Constructor with its parameters, then assigned to properties */
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    /* Returns the value of _name */
    public string GetName()
    {
        return _name;
    }

    /* Returns the value of _address (An object) */
    public Address GetAddress()
    {
        return _address;
    }

    /* It checks if it is from US or not by calling it on the _address object */
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}