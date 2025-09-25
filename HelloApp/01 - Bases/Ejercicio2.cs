partial class Program
{
    static void CalculateSalary()
    {
        Console.WriteLine("Introduce tu nombre: ");
        string name = Console.ReadLine();

        Console.WriteLine("Introduce el número de horas trabajadas este mes: ");
        string inputHours = Console.ReadLine();
        double workedHours = double.Parse(inputHours);

        Console.WriteLine("Introduce tu tarifa por hora: ");
        string inputPrice = Console.ReadLine();
        double price = double.Parse(inputPrice);

        Console.WriteLine($"El sueldo de {name} para este mes es de {workedHours * price} €");

    }
}