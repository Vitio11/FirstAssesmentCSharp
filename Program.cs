using static System.Console;
Clear();
Write("Ingrese el tipo de fruta (manzana, banana o naranja): ");
string? tipo = ReadLine();

Fruta? fruta = null;


switch (tipo!.ToLower())
{
    case "manzana":
    Write($"Ingrese la variedad de la {tipo}: ");
        string? variedad = ReadLine();
        fruta = new Manzana("Manzana", variedad!);
        break;

    case "banana":
        Write($"Ingrese la madurez de la {tipo}: ");
        string? madurez = ReadLine();
        fruta = new Banana("Banana", madurez!);
        break;

    case "naranja":
        Write($"Ingrese el dulzor de la {tipo}: ");
        string? dulzor = ReadLine();
        fruta = new Naranja("Naranja", dulzor!);
        break;

    default:
        WriteLine("Tipo de fruta no válido");
        break;
}

if (fruta != null)
{
    WriteLine(fruta.Descripcion());
}
Write("Entre cualquier tecla");
ReadKey();
