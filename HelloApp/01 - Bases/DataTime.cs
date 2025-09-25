partial class Program
{
    static void ShowTime()
    {
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;
        DateTime oneWeekAgo = now.AddDays(-7);
        DateTime customDate = new DateTime(2025, 3, 2);
        DayOfWeek weekDay = now.DayOfWeek;


        Console.WriteLine($"Momento actual: {now}");
        Console.WriteLine($"Fecha actual: {today.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Hace una semana era: {oneWeekAgo.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Fecha customizada: {customDate}");
        Console.WriteLine($"Día de la semana: {weekDay}");

    }
}