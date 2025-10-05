partial class Program
{
    static void LoopGame()
    {
        int counter = 0;

        WriteLine("🎮 Pulse cualquier tecla para aumentar el contador");
        WriteLine("🔴 Pulsa ESC para salir. \n");

        while (true)
        {
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                WriteLine("Fin del juego");
                WriteLine($"Enhorabuena has pulsado {counter} veces alguna tecla");
                break; 
            }
            counter++; 
        }
    }
}