partial class Program
{
    static void InventoryManager()
    {
        //Menú
        string option;
        Console.WriteLine("1. Comprar producto \n2.Salir");
        Console.WriteLine("Introduzca una opción: ");
        option = Console.ReadLine()!;

        switch (option)
        {
        case "1":

            string[] products = ["Monitor", "Mouse", "Teclado"];
            int[] stock = [10, 25, 30];
            double[] prices = [250.50, 20.50, 45];

            Console.WriteLine("INVENTARIO DE PRODUCTOS");
            Console.WriteLine("___________________________________________________________________\n"); 
            
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: {prices[i]}");
                Console.WriteLine("___________________________________________________________________\n");
            }

            Console.WriteLine("\nIntroduzca el producto que desea comprar");
            string? searchedProduct = Console.ReadLine();

            Console.WriteLine("\nIntroduzca la cantidad que desea comprar");
            int? quantity = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
                {
                    if (quantity <= stock[i])
                    {
                        double? total = quantity * prices[i];
                        Console.WriteLine($"Compra realizada, total a pagar: {total}");

                        stock[i] = (int)stock[i] - (int)quantity;
                        Console.WriteLine("INVENTARIO DE PRODUCTOS");
                        Console.WriteLine("___________________________________________________________________\n"); 
                        
                        for (int a = 0; a < products.Length; a++)
                        {
                            Console.WriteLine($"Producto: {products[a]}, Stock: {stock[a]}, Precio: {prices[a]}");
                            Console.WriteLine("___________________________________________________________________\n");
                        }
                        return; 
                    }
                    else
                    {
                        Console.WriteLine("No disponemos de stock suficiente para ese producto");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Producto no disponible");
                    return; 
                }
            }

                break; 

            case "2":
                Console.WriteLine("Hasta la vista... Baby");
                break;

            default:
                Console.WriteLine("Opción no disponible");
                break;

        }

    }
}