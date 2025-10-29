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

#endregion

#region 4

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