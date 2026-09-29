// ============================================================

// SISTEMA DE INVENTARIO - Clase 1.1

// Estado: Mensaje de bienvenida

// ============================================================

using System.Reflection; // Importar el espacio de nombres para trabajar con ensamblados

var assembly = Assembly.GetExecutingAssembly(); // Obtener información del ensamblado actual
var version = assembly.GetName().Version; // Obtener la versión del ensamblado

if (args.Length > 0)
{
    switch (args[0].ToLower())
    {
        case "--help":
            MostrarAyuda();
            Environment.Exit(0);
            break;

        case "--version":
            Console.WriteLine($"InventarioApp v[{version}]");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine($"Error: Comando desconocido '{args[0]}'");
            Console.WriteLine("use --help para ver los comandos disponibles.");
            Environment.Exit(2);
            break;
    }
}

MostrarBanner();

//Modo interactivo si no hay argumentos

Console.Write("Ingrese un comando (o salir para terminar): ");
string? entrada = Console.ReadLine(); //STDIN

if (string.IsNullOrWhiteSpace(entrada) || entrada.ToLower() == "salir")
{
    Console.WriteLine("Hasta Luego"); //STDOUT
    Environment.Exit(0);
}

/*
Console.WriteLine();
Console.WriteLine("Estructura del proyecto:");
Console.WriteLine(" InventarioApp/");
Console.WriteLine("     |-- Program.cs");
Console.WriteLine("     |-- InventarioApp.csproj");
Console.WriteLine("     |--gitignore");
Console.WriteLine("     |--README.md");
Console.WriteLine("     |--src/");
Console.WriteLine("         |--Models/ (Proxima clase)");
Console.WriteLine("Configuracion .csproject: Define el proyecto y sus dependencias.");
Console.WriteLine("Carpeta src/ creada para organizar el código fuente.");
Console.WriteLine("Metadatos configurados");
Console.WriteLine();
Console.WriteLine("Proximos pasos: Checkpoint");
*/


//======================== FUNIONES =======================

void MostrarBanner()
{
    Console.WriteLine("╔══════════════════════════════════════╗");
    Console.WriteLine("║   SISTEMA DE GESTIÓN DE INVENTARIO   ║");
    Console.WriteLine("╚══════════════════════════════════════╝");
    Console.WriteLine();
    Console.WriteLine($"Versión del sistema: {version}");
    Console.WriteLine($".NET Version: {Environment.Version}");
    Console.WriteLine();
}

void MostrarAyuda()
{
    Console.WriteLine("USO: InventarioApp [comando] [opciones]");
    Console.WriteLine();
    Console.WriteLine("COMANDOS:");
    Console.WriteLine("  --help, -h         Muestra esta ayuda");
    Console.WriteLine("  --version, -v      Muestra la versión");
    Console.WriteLine();
    Console.WriteLine("EJEMPLOS:");
    Console.WriteLine("  dotnet run -- --help");
    Console.WriteLine("  dotnet run -- --version");
}