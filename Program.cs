using System.Globalization;

int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

// SECCIÓN 1: FOR Y FOREACH
Console.WriteLine("=== REGISTRO DE CALIFICACIONES ===");
for (int indice = 0; indice < calificaciones.Length; indice++)
{
    Console.WriteLine($"Estudiante {indice + 1}: {calificaciones[indice]}");
}

Console.WriteLine("\n=== ORDEN DESCENDENTE ===");
for (int indice = calificaciones.Length - 1; indice >= 0; indice--)
{
    Console.WriteLine($"Estudiante {indice + 1}: {calificaciones[indice]}");
}

int sumaTotal = 0;
foreach (int calificacion in calificaciones)
{
    sumaTotal += calificacion;
}

double promedio = (double)sumaTotal / calificaciones.Length;
Console.WriteLine("\n=== PROMEDIO DEL GRUPO ===");
Console.WriteLine($"Suma total: {sumaTotal}");
Console.WriteLine($"Promedio: {promedio.ToString("F1", CultureInfo.InvariantCulture)}");

Console.WriteLine("\n=== POSICIONES PARES ===");
for (int indice = 0; indice < calificaciones.Length; indice += 2)
{
    Console.WriteLine($"Posición par: {calificaciones[indice]}");
}

// SECCIÓN 2: WHILE Y DO-WHILE
Console.WriteLine("\n=== CONTROL DE ACCESO ===");
const string clave = "sena2025";
int intentos = 0;
string claveIngresada = "";

while (claveIngresada != clave && intentos < 3)
{
    Console.Write("Ingresa la clave: ");
    claveIngresada = Console.ReadLine() ?? "";

    if (claveIngresada != clave)
    {
        intentos++;
        Console.WriteLine($"Clave incorrecta. Intentos restantes: {3 - intentos}");
    }
}

if (claveIngresada != clave)
{
    Console.WriteLine("Acceso bloqueado.");
}
else
{
    Console.WriteLine("Acceso concedido.");

    int calificacionMasAlta = calificaciones[0];
    foreach (int calificacion in calificaciones)
    {
        if (calificacion > calificacionMasAlta)
        {
            calificacionMasAlta = calificacion;
        }
    }

    int opcion;
    do
    {
        Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
        Console.WriteLine("1. Ver promedio del grupo");
        Console.WriteLine("2. Ver calificación más alta");
        Console.WriteLine("3. Salir");
        Console.Write("Elige una opción: ");

        if (!int.TryParse(Console.ReadLine(), out opcion))
        {
            opcion = 0;
        }

        switch (opcion)
        {
            case 1:
                Console.WriteLine($"Promedio del grupo: {promedio.ToString("F1", CultureInfo.InvariantCulture)}");
                break;
            case 2:
                Console.WriteLine($"Calificación más alta: {calificacionMasAlta}");
                break;
            case 3:
                Console.WriteLine("Hasta luego.");
                break;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
    }
    while (opcion != 3);
}

// SECCIÓN 3: BREAK Y CONTINUE
Console.WriteLine("\n=== PRIMERA CALIFICACIÓN REPROBATORIA ===");
for (int indice = 0; indice < calificaciones.Length; indice++)
{
    if (calificaciones[indice] < 60)
    {
        Console.WriteLine($"Encontrada en posición {indice + 1}: {calificaciones[indice]}");
        break;
    }
}

Console.WriteLine("\n=== ESTUDIANTES APROBADOS ===");
int totalAprobados = 0;
foreach (int calificacion in calificaciones)
{
    if (calificacion < 60)
    {
        continue;
    }

    Console.WriteLine($"Aprobado: {calificacion}");
    totalAprobados++;
}
Console.WriteLine($"Total aprobados: {totalAprobados}");

Console.WriteLine("\n=== FILTRO COMBINADO ===");
for (int indice = 0; indice < calificaciones.Length; indice++)
{
    int calificacion = calificaciones[indice];

    if (calificacion >= 95)
    {
        Console.WriteLine($"Búsqueda detenida al encontrar: {calificacion}");
        break;
    }

    if (calificacion < 70)
    {
        continue;
    }

    Console.WriteLine($"Calificación procesada: {calificacion}");
}
