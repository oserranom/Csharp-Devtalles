partial class Program
{
    static void ListDictionary()
    {
        //List

        List<string> names = new List<string> { "Ana", "Carlos", "Juan" };
        names.Add("Lucia");

        System.Console.WriteLine($"Total de nombres: {names.Count}");

        System.Console.WriteLine("Nombres almacenados: ");
        foreach (var name in names)
        {
            System.Console.WriteLine(name);
        }

        names.Remove("Ana");
        bool isPresent = names.Contains("Ana");

        System.Console.WriteLine($"Ana está en la lista? {isPresent}");


        //Dictionary

        Dictionary<int, string> students = new Dictionary<int, string>
        {
            {1, "Ana"},
            {2, "Felipe"},
            {3, "Elena"}
        };

        foreach (var student in students)
        {
            System.Console.WriteLine(student.Key + ". " + student.Value);
        }

    }
}