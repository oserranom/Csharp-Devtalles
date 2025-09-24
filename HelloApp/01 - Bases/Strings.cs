partial class Program
{
    static void ShowStringType()
    {
        string name = "Juan";
        string msg = "Hola" + name;
        string interpolatedMsg = $"Hola {name}";
        int number = 13;

        Console.WriteLine(interpolatedMsg);

        //String methods:
        Console.WriteLine($"Tu nombre tiene {name.Length} carácteres");
        Console.WriteLine($"Y nombre en mayúsculas se escribe {name.ToUpper()}");
        Console.WriteLine($"{number} pasado a string es {number.ToString()}");

    }
}