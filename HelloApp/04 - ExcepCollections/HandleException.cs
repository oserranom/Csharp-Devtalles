partial class Program
{

    static string? amount; 
    static void HandleException()
    {
        try
        {
            //int number = 10;
            //int result = number / 0;

            Write("Ingrese una cantidad: ");
            amount = ReadLine();

            if (string.IsNullOrEmpty(amount)) return;

            double amountValue = double.Parse(amount);

            WriteLine($"La cantidad introducida es de {amountValue:C}");
        }
        catch (DivideByZeroException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Error: División entre cero");
        }
        catch (FormatException) when (amount?.Contains('$') == true)
        {
            WriteLine("No es necesario usar símbolos de divisas");
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message); 
        }
 
    }
}