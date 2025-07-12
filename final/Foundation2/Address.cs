public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _inUs;
    private string _labelString;

    public Address(string address)
    {
        string[] parts = address.Split(", ");
        _streetAddress = parts[0];
        _city = parts[1];
        _state = parts[2];
        _country = parts[3];
        _labelString = $"{_streetAddress}\n{_city}, {_state}, {_country}";
        if (_country == "USA")
        {
            _inUs = true;
        }

        else
        {
            _inUs = false;
        }
    }

    public bool GetInUS()
    {
        return _inUs;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }
}