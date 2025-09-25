partial class Program
{
    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(1991, 12, 30);
        TimeSpan difference = DateTime.Now - birthDate;

        Console.WriteLine($"Has vivido {difference.Days} días"); 

    }
}