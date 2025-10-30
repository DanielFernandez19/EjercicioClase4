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
}
else
{
    Console.WriteLine("Lista de productos comprados:");
    foreach (var itemProducto in productos)
    {
        Console.WriteLine(itemProducto);
    }
}

#endregion

#region 5
var matriz5x5 = new char[5, 5];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (j % 2 == 0)
        {
            matriz5x5[i, j] = 'P';
            Console.Write(matriz5x5[i, j] + " ");
        }
        else
        {
            matriz5x5[i, j] = 'I';
            Console.Write(matriz5x5[i, j] + " ");
        }
    }
    Console.WriteLine();
}

#endregion

#region 6
int[,] temperaturaMayo = new int[5, 7];
string diaXSemanaMaxima = "";
string diaXSemanaMinima = "";
int temperaturaMaxima = 0;
int temperaturaMinima = 0;
int temperaturaPromedio = 0;
string diaXMesMaxima = "";
int temperaturaMaximaMes = 0;

Random random6 = new Random();

Console.WriteLine("Temperaturas de Mayo (L-D):");
Console.WriteLine(" Lu  Ma  Mi  Ju  Vi  Sa  Do");
Console.WriteLine(" --------------------------");

int dia = 1;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        if (dia <= 31)
        {
            temperaturaMayo[i, j] = random6.Next(7, 39);
            Console.Write($" {temperaturaMayo[i, j]:D2} ");
        }
        else
        {
            Console.Write("-- ");
        }
        dia++;
    }
    Console.WriteLine();
}

for (int semana = 0; semana < 5; semana++)
{
    for (int diaSemana = 0; diaSemana < 7; diaSemana++)
    {
        int temperaturaActual = temperaturaMayo[semana, diaSemana];
        if (temperaturaActual == 0)
        {
            continue;
        }

        if (temperaturaActual > temperaturaMaxima)
        {
            temperaturaMaxima = temperaturaActual;
            string nombreDia = diaSemana switch
            {
                0 => "Lunes",
                1 => "Martes",
                2 => "Miércoles",
                3 => "Jueves",
                4 => "Viernes",
                5 => "Sábado",
                6 => "Domingo",
                _ => "Día desconocido"
            };
            diaXSemanaMaxima = $"{nombreDia} {semana * 7 + diaSemana + 1}";
        }

        if (temperaturaMinima == 0 || temperaturaActual < temperaturaMinima)
        {
            temperaturaMinima = temperaturaActual;
            string nombreDia = diaSemana switch
            {
                0 => "Lunes",
                1 => "Martes",
                2 => "Miércoles",
                3 => "Jueves",
                4 => "Viernes",
                5 => "Sábado",
                6 => "Domingo",
                _ => "Día desconocido"
            };
            diaXSemanaMinima = $"{nombreDia} {semana * 7 + diaSemana + 1}";
        }

        if (temperaturaActual > temperaturaMaximaMes)
        {
            temperaturaMaximaMes = temperaturaActual;
            string nombreDia = diaSemana switch
            {
                0 => "Lunes",
                1 => "Martes",
                2 => "Miércoles",
                3 => "Jueves",
                4 => "Viernes",
                5 => "Sábado",
                6 => "Domingo",
                _ => "Día desconocido"
            };
            diaXMesMaxima = $"{nombreDia} {semana * 7 + diaSemana + 1}";
        }
        temperaturaPromedio += temperaturaActual;
    }

    Console.WriteLine($"Semana {semana + 1}:");
    Console.WriteLine($"La temperatura más alta de la semana fue el {diaXSemanaMaxima}: {temperaturaMaxima}°C");
    Console.WriteLine($"La temperatura más baja registrada fue el {diaXSemanaMinima}: {temperaturaMinima}°C");
    Console.WriteLine($"Temperatura promedio de la semana: {temperaturaPromedio / 7}°C");
    Console.WriteLine("----------------------------------------");
    temperaturaPromedio = 0;
    temperaturaMinima = 0;
    temperaturaMaxima = 0;
}

Console.WriteLine("Resumen del mes:");
Console.WriteLine($"La temperatura más alta de Mayo fue el {diaXMesMaxima}: {temperaturaMaximaMes}°C");
#endregion

#region 7
int[,] tablasMultiplicar = new int[10, 10];

for (int i = 0; i < 10; i++)
{
    tablasMultiplicar[0, i] = i;
    tablasMultiplicar[i, 0] = i;
}

for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        tablasMultiplicar[i, j] = i * j;
    }
}

Console.WriteLine("Tablas de multiplicar del 1 al 9:");
Console.WriteLine("----------------------------------");

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write($"{tablasMultiplicar[i, j],4}");
    }
    Console.WriteLine();
}
#endregion

#region 8
char[,] matrizJuego = new char[10, 10];
Random random8 = new Random();
int cantidadX = random8.Next(1, 51);
int aciertos = 0;
int fallos = 0;
List<(int, int)> posicionesX = new();

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        matrizJuego[i, j] = '*';
    }
}

for (int i = 0; i < cantidadX; i++)
{
    int fila, columna;
    do
    {
        fila = random8.Next(0, 10);
        columna = random8.Next(0, 10);
    } while (matrizJuego[fila, columna] == 'X');

    matrizJuego[fila, columna] = 'X';
    posicionesX.Add((fila, columna));
}

Console.WriteLine($"Hay {cantidadX} X's escondidas. Tienes 3 intentos fallidos permitidos.");

while (fallos < 3 && aciertos < cantidadX)
{
    Console.WriteLine($"Aciertos: {aciertos} - Fallos: {fallos}");
    Console.Write("Ingrese fila (0-9): ");
    if (!int.TryParse(Console.ReadLine(), out int fila) || fila < 0 || fila > 9)
    {
        Console.WriteLine("Fila inválida. Debe ser un número entre 0 y 9.");
        continue;
    }

    Console.Write("Ingrese columna (0-9): ");
    if (!int.TryParse(Console.ReadLine(), out int columna) || columna < 0 || columna > 9)
    {
        Console.WriteLine("Columna inválida. Debe ser un número entre 0 y 9.");
        continue;
    }

    if (matrizJuego[fila, columna] == 'X')
    {
        Console.WriteLine("¡Acertaste!");
        aciertos++;
    }
    else
    {
        Console.WriteLine("Fallaste.");
        fallos++;
    }
}

Console.WriteLine("Juego terminado!");
if (aciertos == cantidadX)
{
    Console.WriteLine("¡Felicitaciones! Encontraste todas las X's");
}
else
{
    Console.WriteLine("Se acabaron tus intentos");
}

Console.WriteLine("Matriz completa:");
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(matrizJuego[i, j] + " ");
    }
    Console.WriteLine();
}
#endregion

#region 9
Dictionary<string, double> calificaciones = new();
string opcion9;

do
{
    Console.Clear();
    Console.WriteLine("1. Agregar alumno y nota");
    Console.WriteLine("2. Ver promedio general");
    Console.WriteLine("3. Ver mejor y peor nota");
    Console.WriteLine("4. Salir");
    Console.Write("Elija una opción: ");

    opcion9 = Console.ReadLine();

    switch (opcion9)
    {
        case "1":
            Console.Clear();
            Console.Write("Ingrese nombre del alumno: ");
            string nombre = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("Nombre inválido");
                Thread.Sleep(1500);
                break;
            }

            Console.Write("Ingrese nota: ");
            if (!double.TryParse(Console.ReadLine(), out double nota) || nota < 0 || nota > 10)
            {
                Console.WriteLine("Nota inválida. Debe ser entre 0 y 10");
                Thread.Sleep(1500);
                break;
            }

            calificaciones[nombre] = nota;
            Console.WriteLine("Alumno agregado correctamente");
            Thread.Sleep(1500);
            break;

        case "2":
            Console.Clear();
            if (calificaciones.Count == 0)
            {
                Console.WriteLine("No hay alumnos registrados");
                Thread.Sleep(1500);
                break;
            }
            double promedio9 = calificaciones.Values.Average();
            Console.WriteLine($"El promedio general del curso es: {promedio9:F2}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            break;

        case "3":
            Console.Clear();
            if (calificaciones.Count == 0)
            {
                Console.WriteLine("No hay alumnos registrados");
                Thread.Sleep(1500);
                break;
            }
            var mejorAlumno = calificaciones.MaxBy(x => x.Value);
            var peorAlumno = calificaciones.MinBy(x => x.Value);

            Console.WriteLine($"Mejor nota: {mejorAlumno.Key} con {mejorAlumno.Value}");
            Console.WriteLine($"Peor nota: {peorAlumno.Key} con {peorAlumno.Value}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            break;

        case "4":
            Console.Clear();
            Console.WriteLine("¡Hasta luego!");
            Thread.Sleep(1500);
            break;

        default:
            Console.WriteLine("Opción inválida");
            Thread.Sleep(1500);
            break;
    }
} while (opcion9 != "4");
#endregion

#region 10
Queue<string> filaClientes = new();
string opcion10;

do
{
    Console.Clear();
    Console.WriteLine("Sistema de Gestión de Fila");
    Console.WriteLine("1. Agregar cliente a la fila");
    Console.WriteLine("2. Atender próximo cliente");
    Console.WriteLine("3. Ver estado de la fila");
    Console.WriteLine("4. Salir");
    Console.WriteLine("----------------------------------");
    Console.Write("Elija una opción: ");

    opcion10 = Console.ReadLine();

    switch (opcion10)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Agregar Cliente");
            Console.Write("Ingrese nombre del cliente: ");
            string nombre = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("Nombre inválido");
                Thread.Sleep(1500);
                break;
            }

            filaClientes.Enqueue(nombre);
            Console.WriteLine($"Cliente '{nombre}' agregado a la fila");
            Console.WriteLine($"Posición en la fila: {filaClientes.Count}");
            Thread.Sleep(1500);
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("Atender Cliente");
            if (filaClientes.Count == 0)
            {
                Console.WriteLine("No hay clientes en espera");
                Thread.Sleep(1500);
                break;
            }

            string clienteAtendido = filaClientes.Dequeue();
            Console.WriteLine($"¡Atendiendo a: {clienteAtendido}!");
            Console.WriteLine($"Clientes restantes en espera: {filaClientes.Count}");
            Thread.Sleep(1500);
            break;

        case "3":
            Console.Clear();
            Console.WriteLine("Estado de la Fila");
            if (filaClientes.Count == 0)
            {
                Console.WriteLine("No hay clientes en espera");
                Thread.Sleep(1500);
                break;
            }

            Console.WriteLine($"Total de clientes en fila: {filaClientes.Count}");
            Console.WriteLine("Orden de atención:");
            Console.WriteLine("------------------");
            int posicion = 1;
            foreach (var cliente in filaClientes)
            {
                Console.WriteLine($"{posicion}. {cliente}");
                posicion++;
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            break;

        default:
            Console.WriteLine("Opción inválida");
            Thread.Sleep(1500);
            break;
    }
} while (opcion10 != "4");
#endregion


