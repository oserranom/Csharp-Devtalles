partial class Program
{
    public static void Inheritance()
    {
        Student student = new() { Name = "Harry Potter", House = "Gryffindor" };
        Professor professor = new() { Name = "Severus Snape", Subject = "Pociones" };

        student.Greet();
        student.ShowHouse();

        professor.Greet();
        professor.MySubject(); 
    }
}

class Character
{
    public string? Name { get; set; }

    public virtual void Greet()
    {
        WriteLine($"Hola, soy {Name}");
    }
}

class Student : Character
{
    public string? House { get; set; }

    public void ShowHouse()
    {
        WriteLine($"Pertenezco a la casa {House} en Hogwarts");
    }
}

class Professor: Character
{
    public string? Subject { get; set; }

    public void MySubject()
    {
        WriteLine($"Enseño {Subject}");
    }
}