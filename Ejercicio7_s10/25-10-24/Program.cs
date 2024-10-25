using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace _25_10_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario registro = new Inventario();
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Agregar venta");
                Console.WriteLine("2. Mostrar estadísticas de ventas");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Ingrese el ID del producto: ");
                        int productId = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la cantidad: ");
                        int cantidad = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el precio: ");
                        int precio = int.Parse(Console.ReadLine());

                        // Validar que cantidad y precio sean positivos
                        if (cantidad <= 0 || precio <= 0)
                        {
                            Console.WriteLine("La cantidad y el precio deben ser números positivos. Intente nuevamente.");
                            continue;
                        }
                        else
                        {
                            Venta nuevaVenta = new Venta
                            {
                                ProductID = productId,
                                Cantidad = cantidad,
                                Precio = precio
                            };

                            registro.AgregarVenta(nuevaVenta);
                        }
                        break;

                    case "2":
                        Console.Clear();
                        // Mostrar estadísticas
                        registro.MostrarEstadisticas();
                        break;

                    case "3":
                        // Salir del programa
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.Clear();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
