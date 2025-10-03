partial class Program
{
    static void Loops()
    {
        //While

        int counter = 1;

        while (counter <= 5)
        {
            //WriteLine($"Iteraçao {counter}");
            counter++;
        }

        // do while

        int number = 0;

        do
        {
            //WriteLine($"Número: {number}");
            number++;
        } while (number < 3);


        //bucles for

        for (int i = 10; i >= 0; i -= 2)
        {

            if (i == 4)
            {
                WriteLine("No queremos imprimir el 4");
                continue; 
            }
            
            WriteLine($"Iteración: {i}");
        }

        //Array foreach;
        string[] fruits = ["Manzana", "Piña", "Melocotón", "Sandía"];

        foreach (var fruit in fruits)
        {
            //WriteLine(fruit);
        }

        //List foreach
        List<string> names = ["Pedro", "Paco", "Susana"];

        foreach (var name in names)
        {
            //WriteLine(name); 
        }
    }
}