partial class Program
{
    static void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                System.Console.WriteLine("FizzBuzz!");
                continue;
            }
            else if (i % 5 == 0)
            {
                System.Console.WriteLine("Buzz");
                continue;
            }
            else if (i % 3 == 0)
            {
                System.Console.WriteLine("Fizz");
                continue; 
            }
            else
            {
                System.Console.WriteLine(i);
            }
        }
    }
}