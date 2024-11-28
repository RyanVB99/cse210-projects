public class Customer
{
    private string _name;
    private Address _address;
    public bool IsInUSA() {
        if (_address.IsUSA()) {
            return true;
        }
        return false;
    }

    public string GetShippingLabelInfo()
    {
        return _name + "\n" + _address.GetAddress();
    }
    public void Display(){
        Console.WriteLine("Customer Name: " + _name);
        Console.WriteLine("Customer Address: " + _address.GetAddress());
        Console.WriteLine("Is in USA: " + IsInUSA());
    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
}