partial class Program
{
    static void Properties()
    {
        Animal animal = new Animal("Bosque");
        animal.Species = "Lobo";
        animal.Age = 5;

        WriteLine($"El animal {animal.Species} vive en {animal.Habitat}, su edad media es de {animal.Age} y se cosnidera un {animal.Category}"); 
    }
}

class Animal
{
    public string Species { get; set; } = "Desconocida";
    public string Category { get; } = "Vertebrado";
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("La edad debe ser positiva");
            }

            age = value;
        }
    }
    
    public string Habitat { get; }
    public Animal(string habitat)
    {
        Habitat = habitat; 
    }
}