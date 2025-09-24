partial class Program
{
    static void ShowNumericTypes()
    {
        int integerNumber = 42; //Enteros
        double decimalNumber = 3.1416d; //Decimales de mayor precisión (double precision)
        float floatingNumber = 274f; //Decimales de menor precisión
        long longNumber = 300_200_100L; //Nums muy grandes, permite separar con "_" para legibilidad
        decimal financialNumber = 99.99m; //Decimales de mayor precisión, usado para cálculos financieros

        Console.WriteLine($"Entero (int): {integerNumber}");
        Console.WriteLine($"Decimal (double): {decimalNumber}");
        Console.WriteLine($"Decimal de menor precisión (float): {floatingNumber}");
        Console.WriteLine($"Entero de gran tamaño (long): {longNumber}");
        Console.WriteLine($"Decimal de máxima precisión (decimal): {financialNumber}");

    }
}