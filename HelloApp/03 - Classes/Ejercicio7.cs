using System.Reflection.Metadata.Ecma335;

partial class Program
{
    static void Employees()
    {
        List<Employee> empleados = new();

        empleados.Add(new TeamLeader("Carlos", 5000));
        empleados.Add(new Developer("Anna", 4000));
        empleados.Add(new TeamLeader("Laura", 6000));
        empleados.Add(new Developer("Oscar", 3500)); 

        WriteLine("LISTA DE EMPLEADOS:"); 
        foreach(var empleado in empleados)
        {
            empleado.ShowInfo(); 
        }
    }
}

class Employee
{
    public Employee(string name, double salary, string position)
    {
        Name = name;
        Salary = salary;
        Position = position;
    }
    protected string? Name { get; set; }
    protected double Salary { get; set; }
    protected string? Position { get; set; }

    public virtual double CalculateBonus()
    {
        return Salary * 0.05;
    }

    public void ShowInfo()
    {
        WriteLine($"{Name} ({Position}, {Salary}, Bonus: {CalculateBonus():C}) ");
    }
}

class TeamLeader : Employee
{
    public TeamLeader(string name, double salary) : base(name, salary, "Team Leader"){}
    public override double CalculateBonus()
    {
        return Salary * 0.1;
    }
}

class Developer : Employee
{
    public Developer(string name, double salary):base(name, salary, "Developer"){}
    public override double CalculateBonus()
    {
        return Salary * 0.07;
    }
}