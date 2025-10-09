partial class Program
{
    static void Tuples()
    {
        (int, string) myTuple = (42, "Hola");
        WriteLine($"Número: {myTuple.Item1}, Texto: {myTuple.Item2}");

        (int Number, string Text) myTuple2 = (21, "Esto es otra tupla");
        WriteLine($"Número: {myTuple2.Number}, Texto: {myTuple2.Text}");

        //Invocando la function con tuplas
        var operations = Operations(20, 10);
        WriteLine($"Suma: {operations.Sum}, Resta: {operations.Subtraction}");

        //Desestructurando
        (int sum, int subtraction) = Operations(25, 15);
        WriteLine($"Suma: {sum}, Resta: {subtraction}"); 
    }


    //Function con tuplas
    static (int Sum, int Subtraction) Operations(int a, int b)
    {
        return (a + b, a - b);
    }
}