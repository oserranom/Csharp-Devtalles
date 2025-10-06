partial class Program
{
    static void PrintMultiplicationTable(int num, int tableLimit = 10) //Valor por defecto 10
    {
        WriteLine($"Tabla de multiplicar del número {num} desde el 1 hasta el {tableLimit} ");

        WriteLine(); 

        for (int i = 1; i <= tableLimit; i++)
        {
            WriteLine($"{num} x {i} = {num * i}");
        }

        WriteLine(); 
    }
}