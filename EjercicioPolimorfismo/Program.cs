using System;

namespace EjercicioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de diferentes tipos de zapatos
            Zapato[] zapatos = new Zapato[]
            {
                new ZapatoDeportivo("Nike", 1500),
                new ZapatoFormal("Gucci", 5000),
                new ZapatoCasual("Vans", 1200)
            };

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("=== Menú Tienda de Zapatos ===");
                Console.WriteLine("1. Ver detalles de todos los zapatos");
                Console.WriteLine("2. Aplicar descuento a un zapato específico");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        VerDetalles(zapatos);
                        break;
                    case "2":
                        AplicarDescuento(zapatos);
                        break;
                    case "3":
                        salir = true;
                        Console.WriteLine("Saliendo de la tienda. ¡Gracias por su visita!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void VerDetalles(Zapato[] zapatos)
        {
            Console.WriteLine("=== Detalles de los Zapatos ===");
            foreach (var zapato in zapatos)
            {
                zapato.Describir();
            }
        }

        static void AplicarDescuento(Zapato[] zapatos)
        {
            Console.WriteLine("Seleccione el tipo de zapato para aplicar descuento:");
            for (int i = 0; i < zapatos.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {zapatos[i].Marca} - L{zapatos[i].Precio}");
            }
            Console.Write("Ingrese el número del zapato: ");
            if (int.TryParse(Console.ReadLine(), out int seleccion) && seleccion > 0 && seleccion <= zapatos.Length)
            {
                zapatos[seleccion - 1].AplicarDescuento();
            }
            else
            {
                Console.WriteLine("Selección inválida. Intente nuevamente.");
            }
        }
    }
}
