partial class Program
{
    static void BusSalesDemo()
    {
        Bus mercedes = new("Merceces-Benz", "Citaro", 1997, 50_000, 0);
        Bus ikarus = new("Ikarus", "260", 1972, 25_000, 0);
        Bus tata = new("Tata", "1510", 1998, 32_000, 0);

        Fleet flota = new();
        flota.AddBuss(mercedes);
        flota.AddBuss(ikarus);
        flota.AddBuss(tata);

        flota.ShowFleetInfo();

        mercedes.Drive(1500);
        ikarus.Drive(850);
        tata.Drive(2250);

        flota.ShowFleetInfo(); 
    }
}

class Bus
{
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public double? Price { get; set; }
    public int TotalKilometers { get; set; }

    public Bus(string brand, string model, int year, double price, int totalKilometers)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
        TotalKilometers = totalKilometers;
    }

    public void Drive(int km)
    {
        TotalKilometers += km;
        WriteLine($"El vehiculo se ha conducido durante {km} Km, Odómetro: {TotalKilometers}");
    }

    public double? ShowPrice()
    {
        return Price;
    }

    public void ShowInfo()
    {
        WriteLine($"Bus: {Brand} {Model} del {Year} | Km totales: {TotalKilometers}"); 
    }

}

class Fleet
{
    private List<Bus> buses = new List<Bus>();

    public void AddBuss(Bus bus)
    {
        buses.Add(bus);
        WriteLine($"Se ha añadido el vehiculo {bus.Brand} {bus.Model} a la flota.");
    }
    
    public void ShowFleetInfo()
    {
        WriteLine("Flota de autobuses:");

        foreach(var bus in buses)
        {
            bus.ShowInfo(); 
        }
    }
}