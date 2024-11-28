public class Product
{
    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;

    public float TotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingLabelInfo()
    {
        return _name + "\n" + _price + "\n" + _quantity;
    }

    public void Display(){
        Console.WriteLine("Product Name: " + _name);
        Console.WriteLine("Product ID: " + _productId);
        Console.WriteLine("Product Price: " + _price);
        Console.WriteLine("Product Quantity: " + _quantity);
        Console.WriteLine("Total Cost: " + TotalCost());
    }

    public Product(string name, int productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
}