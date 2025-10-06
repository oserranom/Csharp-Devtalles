partial class Program
{
    static double CalculateArea(double width, double height)
    {
        return width * height; 
    }

    static string EvaluateNumber(int number)
    {
        if (number > 0)
        {
            return "positivo";
        }
        else if (number < 0)
        {
            return "negativo";
        }
        else
        {
            return "Cero"; 
        }
    }
    static void Functions()
    {
        var area = CalculateArea(4.5, 2.23);
        WriteLine($"El área es {area}");

        var evaluation = EvaluateNumber(-45);
        WriteLine($"El número es {evaluation}"); 
    }
}