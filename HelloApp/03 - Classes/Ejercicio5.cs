partial class Program
{
    static void ProductSalesDemo()
    {
        Inventory inventory = new();

        Product laptop = new("Laptop", 899.99, 5);
        Product mouse = new("Mouse", 45.99, 10);

        inventory.AddProduct(laptop);
        inventory.AddProduct(mouse);

        inventory.ShowInventory();
        laptop.Sell(1);
        inventory.ShowInventory(); 
    }
}

class Product
{
    public string? Name { get; set; }
    public double Price { get; set; }
    public int? Stock { get; set; }

    public Product(string name, double price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    public void ShowInfo()
    {
        WriteLine($"Producto: {Name}, Precio: {Price}, Stock: {Stock}");
    }

    public bool Sell(int quantity)
    {
        if (quantity <= Stock)
        {
            WriteLine($"Compra realizada: {quantity} unidades de {Name}");
            Stock--; 
            return true;
        }
        WriteLine("Stock insuficiente");
        return false;
    }
}

class Inventory
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void ShowInventory()
    {
        WriteLine("Inventario de productos");

        foreach(var product in products)
        {
            product.ShowInfo();
        }
    }
}