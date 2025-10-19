partial class Program
{
    static void Collections()
    {
        List<string> names = ["Luis", "Pedro", "Pablo"];
        names.Add("Anna");
        WriteLine("LIST"); 
        ShowNames(names);
        names.Remove("Luis");

        WriteLine("Hemos eliminado a Luis");
        ShowNames(names);

        //Dictionary es una colección clave-valor
        Dictionary<int, string> students = new()
        {
            {1, "Anna"},
            {2, "Carlos"},
            {3, "Pablo"}
        };
        students.Add(4, "Paco");
        WriteLine("DICTIONARY");
        ShowStudents(students);
        
        //Lista ligera, no admite duplicados
        HashSet<string> users = ["Luis", "Pedro", "Pablo"];
        users.Add("Julio");
        users.Add("Luis");

        WriteLine("HASHSET"); 
        foreach(var user in users)
        {
            WriteLine(user);
        }
    }

    private static void ShowNames(List<string> names)
    {
        foreach (var name in names)
        {
            WriteLine(name);
        }
    }
    
    private static void ShowStudents(Dictionary<int, string> students)
    {
        foreach(var student in students)
        {
            WriteLine($"Clave: {student.Key}, Valor: {student.Value}"); 
        }
    }
}