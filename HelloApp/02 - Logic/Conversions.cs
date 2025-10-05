partial class Program
{
    static void Conversions()
    {
        //Conversion implícita, mantiene toda la info
        int number = 42;
        double decimalNumber = number;
        WriteLine(decimalNumber);

        //Conversion explícita, riesgo de pérdida o incompatibilidad
        double trueDecimalNumber = 42.5;
        int integerNumber = (int)trueDecimalNumber; //trunca el number
        WriteLine(integerNumber);

        // Convert y Parse
        string text = "123";
        int parsedNumber = int.Parse(text); //Parseo sin pérdida de datos
        WriteLine(parsedNumber);

        double otherDecimalNumber = 50.8;
        int convertedNumber = Convert.ToInt32(otherDecimalNumber); //Redondea el number
        WriteLine(convertedNumber); 
    }
}