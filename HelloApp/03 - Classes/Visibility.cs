partial class Program
{
    static void Visibility()
    {
        Jedi jedi = new();
        jedi.PowerLevel = 5000;
        jedi.LightsaberColor = "Azul";
        jedi.UseForce();

        //jedi.PrivateField => Error
        //jedi.ProtectedField => Error

        jedi.RevealSecrets();

        Sith sith = new();
        sith.ShowProtected();

        sith.PowerLevel = 400;
        sith.LightsaberColor = "red";
        sith.UseForce(); 

    }    
}

interface IforceUser
{
    int PowerLevel { get; set; }
    string LightsaberColor { get; set; }

    void UseForce(); 

}

class Jedi:IforceUser
{
    //Acceso desde cualquier clase
    public string PublicField = "Soy un Jedi y mi poder es conocido";

    //Acceso solo desde la clase
    private string PrivateField = "Mis pensamientos mas profundos son privados";

    //Acceso desde la clase y clases heredadas
    protected string ProtectedField = "El lado oscuro no debe conocer mis secretos";

    public int PowerLevel { get; set; }
    public string? LightsaberColor { get; set; }

    public void UseForce()
    {
        WriteLine($"Soy un Jedi con un sable color {LightsaberColor} y mi nivel de poder es {PowerLevel}");
    }

    private void Meditate()
    {
        WriteLine("Estoy en profunda meditación con la fuerza");
    }

    protected void Train()
    {
        WriteLine("Estoy entrenando para ser mejor jedi");
    }

    public void RevealSecrets()
    {
        //Acceso desde dentro de la clase 
        WriteLine(ProtectedField);
        WriteLine(PrivateField);
    }
}

class Sith : Jedi, IforceUser
{
    public new void UseForce()
    {
        WriteLine($"Soy un Sith y mi color de sable es {LightsaberColor}, mi nivel de poder es {PowerLevel}");
    }
    public void ShowProtected()
    {
        WriteLine(ProtectedField);
        Train(); 
    }
}