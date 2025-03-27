public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsInUsa()
    {
        if(_country.ToUpper() == "USA")
        {
            return true;
        }
        return false;
    }

    public string get_full_address()
    {
        return $"{_street}, {_city}, {_stateOrProvince}, {_country}";
    }
}