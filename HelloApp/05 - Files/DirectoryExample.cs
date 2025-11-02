partial class Program
{
    static void DirectoryExample()
    {
        var directoryPath = "./05 - Files/";

        //Crear directorio
        Directory.CreateDirectory($"{directoryPath}/DirExam");

        //Comprobar si existe el directorio
        if (Directory.Exists($"{directoryPath}/DirExam"))
        {
            WriteLine("El directorio ya existe");
        }

        //Borrar directorio
        Directory.Delete($"{directoryPath}/DirExam", recursive: true);


    }
}