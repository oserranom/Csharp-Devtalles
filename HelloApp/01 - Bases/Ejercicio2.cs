partial class Program
{
    static void CalculateSalary()
    {
        Console.WriteLine("CALCULADORA DE SALARIO"); 
        Console.Write("Introduce tu nombre: ");
        string? name = Console.ReadLine();

        Console.Write("Introduce el número de horas trabajadas este mes: ");
        double workedHours = double.Parse(Console.ReadLine()!);

        Console.Write("Introduce tu tarifa por hora: ");
        double price = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"El sueldo de {name} para este mes es de {workedHours * price} €");

    }
}