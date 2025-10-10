partial class Program
{
    static void Methods()
    {
        Car car = new Car();
        car.Model = "Yaris";
        car.Year = 2022;
        WriteLine(car.ShowInfo());

        car.ShowMessage("Cambiando de modelo");
        car.ChangeModel("Patrol");
        WriteLine(car.ShowInfo());

        Car.GeneralInfo(); 
    }
}

class Car
{
    public string? Model { get; set; }
    public int? Year { get; set; }
    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }

    public string ShowInfo()
    {
        return $"Vehiculo {Model}, año {Year}";
    }

    //Sobrecarga de método
    public void ShowMessage() => WriteLine("Este es un automóvil");
    public void ShowMessage(string message) => WriteLine(message); 

    //Métodos estáticos
    public static void GeneralInfo()
    {
        WriteLine("EL automóvil es un medio de transporte"); 
    }
}