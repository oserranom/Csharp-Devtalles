partial class Program
{
    static void Loops()
    {
        //While

        int counter = 1;

        while (counter <= 5)
        {
            WriteLine($"Iteraçao {counter}");
            counter++;
        }

        // do while

        int number = 0;

        do
        {
            WriteLine($"Número: {number}");
            number++; 
        } while (number < 3); 
    }
}