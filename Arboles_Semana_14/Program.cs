class Program
{
    static void Main()
    {
        ArbolBinario arbol = new ArbolBinario();
        int opcion, valor;
        do
        {
            Console.WriteLine("\n--- MENÚ ÁRBOL BINARIO ---");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Mostrar en Orden");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el valor a insertar: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Insertar(valor);
                    break;
                case 2:
                    Console.Write("Ingrese el valor a buscar: ");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(valor) ? "Valor encontrado" : "Valor no encontrado");
                    break;
                case 3:
                    Console.WriteLine("Recorrido InOrden:");
                    arbol.InOrden();
                    Console.WriteLine();
                    break;
            }
        } while (opcion != 4);
    }
}
