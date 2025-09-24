partial class Program
{
    static void DataTypes()
    {
        int integer = 42;
        double decimalNumber = 3.1416;
        bool isTrue = true;
        char character = 'c';
        string text = "Hola mundo";

        //Estoy usando raw string literals aquí (""")
        Console.WriteLine($"""
            Entero: {integer}, Decimal: {decimalNumber}, Boolean: { isTrue }, 
            Cáracter: {character}, String: {text}
         """);
    }
}