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

            if (double.TryParse(amount, out double amountValue))
            {
                WriteLine($"La cantidad introducida es de {amountValue:C}");
            }
            else
            {
                WriteLine("La cantidad no es convertible a un número");
            }

            //double amountValue = double.Parse(amount);

            ValidateAge(16);

        }
        catch (DivideByZeroException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Error: División entre cero");
        }
        catch (FormatException) when (amount?.Contains('$') == true)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("No es necesario usar símbolos de divisas");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine(ex.Message);
        }
        finally
        {
            Console.ResetColor(); 
            WriteLine("Esto forma parte del bloque finally, se ejecuta siempre"); 
        }

    }
    
    static void ValidateAge(int age)
    {
        if(age < 18)
        {
            throw new ArgumentException("La edad debe ser mayor a 18");
        }
    }
}