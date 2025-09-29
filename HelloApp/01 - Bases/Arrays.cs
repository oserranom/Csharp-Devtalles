using System.Runtime.ExceptionServices;

partial class Program
{
    static void Arrays()
    {
        //Declaración con constructor y asignación por índices
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 2;
        //...

        //declaración con asignación directa. 
        int[] numbers2 = [5, 10, 15, 20, 25, 30];

        Console.WriteLine("Array completo: ");

        foreach (var num in numbers2)
        {
            Console.Write(num + " ");
        }

        //Recorrido inverso
        Console.WriteLine($"\nÚltimo elemento {numbers2[^1]}");
        Console.WriteLine($"Penúltimo elemento {numbers2[^2]}");

        //SubArrays
        int[] firsThree = numbers2[..3];
        int[] fromIndexTwo = numbers2[2..];

        Console.WriteLine("\nSubarray primeros tres elementos: ");
        foreach (var number in firsThree)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\nSubarray últimos elementos: ");
        foreach (var num in fromIndexTwo)
        {
            Console.Write(num + " ");
        }

    }
}