using System.Globalization;

partial class Program
{
    static void DaysUntilBirthDate()
    {
        Console.WriteLine("Introduce tu fecha de nacimiento (dd/mm/aaaa): ");
        string birthDateString = Console.ReadLine()!;
        DateTime birthDate = DateTime.ParseExact(birthDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        DateTime currentDate = DateTime.Now.Date;
        DateTime nextBirthday = new DateTime(currentDate.Year, birthDate.Month, birthDate.Day);

        if (nextBirthday < currentDate)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        int daysRemaining = (nextBirthday - currentDate).Days;

        Console.WriteLine($"Faltan {daysRemaining} días para tu próximo cumpleaños."); 
    }
}