#region 1
int[] Notas = { 10, 8, 9, 10, 9, 8, 9, 8, 10, 10 };
int total = 0;
Console.WriteLine($"Notas de examenes");
for (int i = 0; i < Notas.Length; i++)
{
    total += Notas[i];
    Console.WriteLine($"Examen {i + 1}: {Notas[i]}");
}
decimal promedio = total / Notas.Length;

Console.WriteLine($"El promedio es: {promedio}");

#endregion

#region 2
int[] Edades = { 15, 16, 17, 15, 16, 17, 15, 16, 17, 15,
                 16, 17, 15, 16, 25, 30, 35, 28, 42, 38 };
int cantidadMayores = 0;
int cantidadMenores = 0;

foreach (var edad in Edades)
{
    if (edad >= 18)
    {
        cantidadMayores++;
    }
    else
    {
        cantidadMenores++;
    }
}
Console.WriteLine($"Son {cantidadMayores} personas mayores de edad y {cantidadMenores} personas menores de edad ");
#endregion

#region 3

string[] nombres = { "Ana", "Juan", "Maximiliano", "Ev", "Alejandro", "Leo", "Elizabeth", "Ed", "Christopher", "Sol" };

string nombreMasCorto = nombres[0];
string nombreMasLargo = nombres[0];

foreach (string nombre in nombres)
{
    if (nombre.Length < nombreMasCorto.Length)
    {
        nombreMasCorto = nombre;
    }

    if (nombre.Length > nombreMasLargo.Length)
    {
        nombreMasLargo = nombre;
    }
}

Console.WriteLine($"El Nombre más corto: {nombreMasCorto} ({nombreMasCorto.Length} letras)");
Console.WriteLine($"El Nombre más largo: {nombreMasLargo} ({nombreMasLargo.Length} letras)");

#endregion

#region 4
List<string> productos = ["leche", "pan", "huevos", "arroz"];
List<string> productosEliminados = [];
List<string> productosAgregados = [];
string producto = "";
do
{
    Console.WriteLine("Ingrese el nombre del producto (o 'fin' para terminar):");
    producto = Console.ReadLine();

    if (producto.ToLower().Trim() == "fin")
    {
        break;
    }

    if (string.IsNullOrWhiteSpace(producto))
    {
        Console.WriteLine("El nombre del producto no puede estar vacío. Intente nuevamente.");
        continue;
    }

    if (productos.Contains(producto.TrimEnd()))
    {
        Console.WriteLine($"{producto} ya ha sido ingresado. sera eliminado");
        productosEliminados.Add(producto);
        productos.Remove(producto);

        Thread.Sleep(800);
        Console.Clear();
        continue;
    }

    productos.Add(producto.ToLower().TrimStart().TrimEnd());
    productosAgregados.Add(producto.ToLower().TrimStart().TrimEnd());
    Console.WriteLine($"Producto '{producto}' agregado.");
    Thread.Sleep(800);
    Console.Clear();

} while (true);

Console.Clear();

if (productosAgregados.Count == 0)
{
    Console.WriteLine("No se han ingresado productos.");

}
else
{
    Console.WriteLine("Lista de productos ingresados:");
    foreach (var agregado in productosAgregados)
    {
        Console.WriteLine(agregado);
    }
}

if (productosEliminados.Count == 0)
{
    Console.WriteLine("No se han eliminado productos.");
}
else
{
    foreach (var Eliminado in productosEliminados)
    {
        Console.WriteLine(Eliminado);
    }
}

if (productos.Count == 0)
{
    Console.WriteLine("No quedan productos en la lista.");
    return;
}else
{
    Console.WriteLine("Lista de productos comprados:");
    foreach (var itemProducto in productos)
    {
        Console.WriteLine(itemProducto);
    }
}

#endregion

#region 5

#endregion

#region 6

#endregion

#region 7

#endregion

#region 8

#endregion

#region 9

#endregion

#region 10

#endregion