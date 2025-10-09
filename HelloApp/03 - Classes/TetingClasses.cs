partial class Program
{
    static void TestingClasses()
    {
        Vehicle toyota = new Vehicle();
        toyota.Brand = "Toyota";
        toyota.Model = "Corolla";
        toyota.Year = 2006;

        Vehicle honda = new Vehicle { Brand = "Honda", Model = "Civic", Year = 2009 };

        Vehicle nissan = new Vehicle("Nissan", "Skyline", 2002);

        toyota.ShowInfo();
        honda.ShowInfo();
        nissan.ShowInfo();

    }
}

class Vehicle
{
    //Propiedades
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }

    //Constructor method
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year; 
    }

    //Constructor vacío para no romper el código anterior de instanciación de clases sin constructor 
    public Vehicle() { }

    //Métodos
    public void ShowInfo()
    {
        WriteLine($"Este vehículo es un {Brand} {Model} del {Year}");
    }
}