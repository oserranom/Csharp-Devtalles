partial class Program
{
    static void HandleNullables()
    {
        //No nulificable
        string firstName = "Carlos";

        //Nulificable
        string? lastName = null;


        Console.WriteLine($"Nombre: {firstName}");

        if (lastName != null)
        {
            Console.WriteLine($"Apellido: {lastName}");
        }
        else
        {
            Console.WriteLine("No hay valor en el campo apellido");
        }

        //Operador de coalescencia "??"
        Console.WriteLine($"Apellido: {lastName ?? "Apellido no especificado"}");
        //Operador de acceso nulo seguro ?.
        string? text = null;
        Console.WriteLine(text?.Length); //No rompe el código con el error
        Console.WriteLine("Sigue ejecutando"); 

    }
}