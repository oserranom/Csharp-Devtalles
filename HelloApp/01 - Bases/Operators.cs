partial class Program
{
    static void Operators()
    {
        int number = 15;
        bool isEven = number % 2 == 0;
        bool isGreaterThanTen = number > 0;

        if (isEven && isGreaterThanTen)
        {
            Console.WriteLine($"El número {number} es par y mayor a 10");
        }
        else if (!isEven && isGreaterThanTen)
        {
            Console.WriteLine($"El número {number} es impar y mayor a 10");
        }
        else
        {
            Console.WriteLine($"El número {number} es impar y menor a 10");
        }

        //Operador ternario (?:)
        int age = 21;
        string category = age > 18 ? "Adulto" : "Menor";
        Console.WriteLine($"La persona es {category}"); 

    }
}