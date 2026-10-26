# 220501097-04-AA1-EV05 — Estructuras de control iterativo

Solución en un solo proyecto de consola C# para el reto de estructuras de control iterativo. El programa ejecuta secuencialmente las tres secciones solicitadas y utiliza el arreglo compartido de calificaciones:

`72, 85, 91, 60, 43, 78, 95, 55, 88, 67`

## Secciones

1. **For y Foreach:** registro ascendente y descendente, promedio del grupo e índices pares.
2. **While y Do-While:** validación de clave con tres intentos y menú interactivo. La clave es `sena2025`.
3. **Break y Continue:** búsqueda de la primera nota reprobatoria, lista y conteo de aprobados, y filtro combinado.

## Ejecución

Requiere el SDK de .NET 10 o compatible. Desde esta carpeta, ejecuta:

```powershell
dotnet run --project .\ControlIterativo.csproj
```

También puedes abrir `Control-Iterativo.slnx` en un IDE compatible.

## Nota sobre la salida de la Sección 3

El código sigue las condiciones escritas: considera aprobada una nota igual o superior a 60 y detiene el filtro combinado al encontrar una nota igual o superior a 95. El fragmento de salida del material difiere en esos dos puntos (muestra 7 aprobados y se detiene en 91).
