class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ DE EJERCICIOS ---");
            Console.WriteLine("1. Uso de HashSet para eliminar duplicados");
            Console.WriteLine("2. Uso de SortedSet para ordenar elementos");
            Console.WriteLine("3. Uso de Dictionary para almacenar edades");
            Console.WriteLine("4. Uso de Dictionary para conteo de palabras");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Ejercicio1_HashSet();
                        break;
                    case 2:
                        Ejercicio2_SortedSet();
                        break;
                    case 3:
                        Ejercicio3_Dictionary();
                        break;
                    case 4:
                        Ejercicio4_ConteoPalabras();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingrese un número válido.");
            }

        } while (opcion != 5);
    }

    // Ejercicio 1: Uso de HashSet para eliminar duplicados
    static void Ejercicio1_HashSet()
    {
        Console.WriteLine("\nEjercicio 1: HashSet para eliminar duplicados");

        // HashSet solo almacena valores únicos
        HashSet<int> numeros = new HashSet<int> { 10, 20, 30, 10 };

        Console.WriteLine("Elementos únicos en el conjunto:");
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }
    }

    // Ejercicio 2: Uso de SortedSet para ordenar elementos
    static void Ejercicio2_SortedSet()
    {
        Console.WriteLine("\nEjercicio 2: SortedSet para ordenar elementos");

        // SortedSet ordena los elementos de forma automática
        SortedSet<string> estudiantes = new SortedSet<string> { "Carlos", "Ana", "Pedro", "Luis", "Ana" };

        Console.WriteLine("Lista de estudiantes ordenados:");
        foreach (string estudiante in estudiantes)
        {
            Console.WriteLine(estudiante);
        }
    }

    // Ejercicio 3: Uso de Dictionary para almacenar edades
    static void Ejercicio3_Dictionary()
    {
        Console.WriteLine("\nEjercicio 3: Dictionary para almacenar edades");

        // Diccionario que asocia nombres con edades
        Dictionary<string, int> edades = new Dictionary<string, int>
        {
            { "Juan", 25 },
            { "María", 30 },
            { "Carlos", 22 },
            { "Ana", 28 }
        };

        Console.WriteLine("Edades de las personas:");
        foreach (var persona in edades)
        {
            Console.WriteLine($"{persona.Key} tiene {persona.Value} años.");
        }

        // Buscar una clave específica
        Console.Write("\nIngrese un nombre para consultar la edad: ");
        string clave = Console.ReadLine();

        if (edades.ContainsKey(clave))
        {
            Console.WriteLine($"La edad de {clave} es {edades[clave]} años.");
        }
        else
        {
            Console.WriteLine("Nombre no encontrado.");
        }
    }

    // Ejercicio 4: Uso de Dictionary para conteo de palabras
    static void Ejercicio4_ConteoPalabras()
    {
        Console.WriteLine("\nEjercicio 4: Dictionary para conteo de palabras");

        string[] palabras = { "casa", "perro", "gato", "perro", "casa", "casa", "gato" };
        Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

        // Contar la frecuencia de cada palabra
        foreach (string palabra in palabras)
        {
            if (contadorPalabras.ContainsKey(palabra))
            {
                contadorPalabras[palabra]++;
            }
            else
            {
                contadorPalabras[palabra] = 1;
            }
        }

        // Mostrar resultados
        Console.WriteLine("Frecuencia de palabras:");
        foreach (var entrada in contadorPalabras)
        {
            Console.WriteLine($"{entrada.Key}: {entrada.Value}");
        }
    }
}