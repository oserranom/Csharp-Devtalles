partial class Program
{
    static void AbstractClass()
    {
        HomeAppliance washer = new WashingMachine() { Brand = "Samsung" };
        HomeAppliance microwave = new Microwave() { Brand = "Taurus" };

        washer.ShowBrand();
        washer.TurnOn();

        microwave.ShowBrand();
        microwave.TurnOn(); 
    }
}

abstract class HomeAppliance
{
    public string? Brand { get; set; }

    public abstract void TurnOn();

    public void ShowBrand()
    {
        WriteLine($"La marca de electrodoméstico es {Brand}");
    }
}

class WashingMachine : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("La lavadora ha iniciado el ciclo de lavado 🫧");
    }
}

class Microwave: HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("El microondas está calentando 🔥"); 
    }
}