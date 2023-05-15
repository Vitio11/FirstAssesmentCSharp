public class Banana : Fruta
{
    public string Variedad {get; set;}
    public Banana(string nombre, string variedad) : base(nombre) {
        Variedad = variedad;
    }

    public override string Descripcion()
    {
        return  $"La fruta {Nombre} es de variedad {Variedad} Tiene un sabor dulce y es ideal para comer fresca o para hacer zumo.";
    }
}