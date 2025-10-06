using System.Globalization; 

partial class Program
{
    static void ConvertionsDataTime()
    {
        //Formato local
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-ES");

        int friends = int.Parse("101");
        double price = 25.50;

        DateTime birthDay = DateTime.Parse("2 Marzo 2025");

        WriteLine($"Tengo {friends} amigos para invitar a mi fiesta");
        WriteLine($"La celebración de mi cumpleaños será el día {birthDay}");
        WriteLine($"Formato largo {birthDay:D}");
        WriteLine($"El precio de la entrada es de: {price:C}");

        
    }
}