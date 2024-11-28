public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    public bool IsUSA() {
        if (_country == "USA") {
            return true;
        }
        return false;
    }

    public string GetAddress()
    {
        return _streetAddress + "\n" + _city + "\n" + _stateOrProvince + "\n" + _country;
    }
    public void Display(){
        Console.WriteLine("Street Address: " + _streetAddress);
        Console.WriteLine("City: " + _city);
        Console.WriteLine("State/Province: " + _stateOrProvince);
        Console.WriteLine("Country: " + _country);
        Console.WriteLine("Is in USA: " + IsUSA());
    }

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
}