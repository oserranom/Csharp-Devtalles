partial class Program
{
    static void Linq()
    {
        List<int> numbers = [1, 2, 3, 4, 5];
        List<int> evenNumbers = [];

        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        //Sintaxis de consulta con LINQ
        var evenNumbersQuery = from num in numbers where num % 2 == 0 select num;

        //Sintaxis de método con LINQ
        var evenNumbersMethod = numbers.Where(n => n % 2 == 0);

        foreach (var number in evenNumbers)
        {
            WriteLine(number);
        }

        foreach (var number in evenNumbersQuery)
        {
            WriteLine(number);
        }

        foreach (var number in evenNumbersMethod)
        {
            WriteLine(number);
        }





        //Consultas simples
        List<MarvelCharacter> characters = new List<MarvelCharacter>
        {
        new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
        new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
        new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
        new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
        new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
        new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
        };

        WriteLine("Personajes que pertenecen al team Avengers");
        //Query
        var avengersQuery = from c in characters where c.Team == "Avengers" select $"{c.Alias} ({c.Name})";
        //Method
        var avengersMethod = characters.Where(c => c.Team == "Avengers");

        foreach (var character in avengersQuery)
        {
            WriteLine(character);
        }

        foreach (var character in avengersMethod)
        {
            WriteLine($"{character.Alias} ({character.Name})"); 
        }
    }
}

class MarvelCharacter
{
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
}

