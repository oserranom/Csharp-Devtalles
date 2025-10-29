partial class Program
{
    static void FileExample()
    {
        string path = "./05 - Files/example.txt";

        //Lee todo el archivo en un solo string
        var content = File.ReadAllText("./05 - Files/example.txt");
        //WriteLine(content); 

        //Lee el archivo linea por linea y lo guarda en un array de strings. 
        var lines = File.ReadAllLines(path);
        foreach (var line in lines)
        {
            WriteLine(line);
        }

        //Copia documento
        File.Copy(path, "./05 - Files/examplecopied.txt", overwrite: true);

        //Borra documento
        File.Delete("./05 - Files/examplecopied.txt"); 
    }
}