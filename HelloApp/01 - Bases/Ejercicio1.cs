partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrice = 749.99;
        double totalAmount = quantitySold * unitPrice;

        Console.WriteLine($"Producto: {product}");
        Console.WriteLine($"Unidades vendidas: {quantitySold}");
        Console.WriteLine($"Total ventas: {totalAmount:C}"); 
    }
}