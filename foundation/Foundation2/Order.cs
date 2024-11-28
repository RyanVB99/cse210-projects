public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public float TotalCost(List<Product> products)
    {
        int shippingCost;
        if (_customer.IsInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 15;
        }
        float totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.TotalCost();
        }
        return totalCost + shippingCost;
    }

    static string CreatePackingLabel(List<Product> products)
    {
        string packingLabel = "";
        foreach (var product in products)
        {
            packingLabel += product.GetPackingLabelInfo() + "\n";
        }
        return packingLabel;
    }

    public string CreateShippingLabel() {
        return _customer.GetShippingLabelInfo();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void Display()
    {
        Console.WriteLine("Order Details:");
        Console.WriteLine("Customer Details:");
        _customer.Display();
        Console.WriteLine("Product Details:");
        foreach (var product in _products)
        {
            product.Display();
        }
        Console.WriteLine("Total Cost: " + TotalCost(_products));
        Console.WriteLine("Packing Label:");
        Console.WriteLine(CreatePackingLabel(_products));
    }

    public Order(Customer customer)
    {
        _customer = customer;
    }
}