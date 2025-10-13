partial class Program
{
    static void BusSalesDemo()
    {

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


}