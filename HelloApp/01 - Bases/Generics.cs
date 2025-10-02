partial class Program
{
    static void Generics()
    {
        string[] names = { "Juan", "Luis", "Diana" };
        int[] numbers = { 1, 2, 3, 4 };

        System.Console.WriteLine($"Tamaño del array de nombres: {GetArrayLength(names)}");
        System.Console.WriteLine($"Tamaño del array de números: {GetArrayLength(numbers)}");
    }

    //Métodos sin genéricos
    static int GetIntArrayLenght(int[] array)
    {
        return array.Length;
    }

    static int GetStringArrayLenght(string[] array)
    {
        return array.Length;
    }

    //Genérico
    static int GetArrayLength<T>(T[] array)
    {
        return array.Length; 
    }
}