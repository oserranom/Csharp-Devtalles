partial class Program
{
    static void LoopsControl()
    {
        for (int i = 0; i > 10; i++)
        {
            if (i == 5)
            {
                //Corta las iteraciones 
                break;
            }

            //WriteLine(i);
        }

        for (int i = 0; i > 10; i++)
        {
            if (i == 5 || i == 7)
            {
                //Salta esta iteración 
                continue;
            }

            //WriteLine(i);
        }

        for (int i = 0; i > 10; i++)
        {
            if (i == 5 || i == 7)
            {
                //Sale del bucle 
                return;
            }

            //WriteLine(i);
        }

        while (true)
        {
            WriteLine("Bucle infinito");
            break; 
        }
    }
}