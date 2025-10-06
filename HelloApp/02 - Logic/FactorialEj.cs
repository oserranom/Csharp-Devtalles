using System.ComponentModel.DataAnnotations;

partial class Program
{
    static void PrintFactorial(int num)
    {
        WriteLine($"Factorial del número {num}");

        if (num < 0) WriteLine("No se admiten número negativos");

        for (int i = 1; i <= num; i++)
        {
            WriteLine($"{i}! = {Factorial(i)}");
        }
    }

    static int Factorial(int number)
    {
        int result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result; 
    }
}