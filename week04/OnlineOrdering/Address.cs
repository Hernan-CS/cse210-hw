public class Address
{
    /* Encapsulation application */
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    /* Constructor with parameters, then assigned to properties so I can pass values through */
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    /* Checks if it's from USA by convertir the text to lowercase and compare it with "usa", it'll return true or false. */
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    /* Method to display the full address */
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}