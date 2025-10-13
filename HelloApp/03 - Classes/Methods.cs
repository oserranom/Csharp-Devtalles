partial class Program
{
    static void Methods()
    {   
        //Constructor por defecto
        // Car car = new Car();
        // car.Model = "Yaris";
        // car.Year = 2022;
        // WriteLine(car.ShowInfo());

        // car.ShowMessage("Cambiando de modelo");
        // car.ChangeModel("Patrol");
        // WriteLine(car.ShowInfo());

        // Car.GeneralInfo(); 

        //Using Constructor:
        Car sportCar = new Car("Ferrari", 2020);
        WriteLine(sportCar.ShowInfo());

        //Sintáxis simplificada:
        //Car collectionCar = new Car { Model = "Cadillac", Year = 1980 }; //Error hay que ver por qué

        //Lista de objetos
        List<Car> cars = new()
        {
            new Car("Duster", 2020),
            new Car("Stepway", 2019),
            new Car("Captur", 2021)

        };

        WriteLine("Listado de automóviles");
        foreach(var cochesito in cars)
        {
            WriteLine(cochesito.ShowInfo());
        }
    }
}

class Car
{
    public string? Model { get; set; }
    public int? Year { get; set; }

    //Constructor
    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    //Destructor (~)
    ~Car()
    {
        WriteLine("Destructor activado. Recurso liberado.");
    }

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