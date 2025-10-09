partial class Program
{
    static void AnnonymousFunctions()
    {
        WriteLine(square(5));
        WriteLine(lambdaSquare(4));

        List<int> numbers = [1, 2, 3, 4, 5];
        
        //Función lambda en listas
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        foreach (var even in evenNumbers) {
            WriteLine(even); 
        }
    }

    //Función anónima
    static Func<int, int> square = delegate (int number)
    {
        return number * number;
    };

    //Función lambda, JS vibes
    static Func<int, int> lambdaSquare = x => x * x;
}