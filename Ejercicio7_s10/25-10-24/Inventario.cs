using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _25_10_24
{
    public struct Venta
    {
        public int ProductID;
        public int Cantidad;
        public int Precio;

        public Venta(int productID, int cantidad, int precio)
        {
            ProductID = productID;
            Cantidad = cantidad;
            Precio = precio;
        }
    }

    internal class Inventario
    {
        private const string archivoVentas = "ventas.dat";

        // Agregar una nueva venta al archivo
        public void AgregarVenta(Venta venta)
        {
            if (IdExiste(venta.ProductID))
            {
                Console.WriteLine("El ID del producto ya existe. No se puede agregar la venta.");
                return;
            }

            using (FileStream mArchivosEscritor = new FileStream(archivoVentas, FileMode.Append, FileAccess.Write))
            using (BinaryWriter Escritor = new BinaryWriter(mArchivosEscritor))
            {
                Escritor.Write(venta.ProductID);
                Escritor.Write(venta.Cantidad);
                Escritor.Write(venta.Precio);
            }

            Console.WriteLine("Venta agregada.");
        }

        // Comprobar si el ID del producto ya existe
        public bool IdExiste(int productId)
        {
            if (File.Exists(archivoVentas))
            {
                using (FileStream mArchivosLector = new FileStream(archivoVentas, FileMode.Open, FileAccess.Read))
                using (BinaryReader Lector = new BinaryReader(mArchivosLector))
                {
                    while (mArchivosLector.Position != mArchivosLector.Length)
                    {
                        int id = Lector.ReadInt32();
                        Lector.ReadInt32(); // Leer cantidad (no se necesita)
                        Lector.ReadInt32(); // Leer precio (no se necesita)

                        if (id == productId)
                        {
                            return true; // El ID ya existe
                        }
                    }
                }
            }

            return false; // El ID no existe
        }

        // Obtener estadísticas de las ventas
        public void MostrarEstadisticas()
        {
            int totalVentas = 0;
            int ventaMasAlta = 0;
            int ventaMasBaja = int.MaxValue;

            if (File.Exists(archivoVentas))
            {
                using (FileStream mArchivosLector = new FileStream(archivoVentas, FileMode.Open, FileAccess.Read))
                using (BinaryReader Lector = new BinaryReader(mArchivosLector))
                {
                    while (mArchivosLector.Position != mArchivosLector.Length)
                    {
                        int productId = Lector.ReadInt32();
                        int cantidad = Lector.ReadInt32();
                        int precio = Lector.ReadInt32();

                        int totalVenta = cantidad * precio;
                        totalVentas += totalVenta;

                        if (totalVenta > ventaMasAlta)
                            ventaMasAlta = totalVenta;

                        if (totalVenta < ventaMasBaja)
                            ventaMasBaja = totalVenta;
                    }
                }
            }

            // Manejar casos donde no hay ventas
            if (ventaMasBaja == int.MaxValue)
                ventaMasBaja = 0;

            // Imprimir resultados
            Console.WriteLine($"Total de ventas: {totalVentas}");
            Console.WriteLine($"Venta más alta: {ventaMasAlta}");
            Console.WriteLine($"Venta más baja: {ventaMasBaja}");
        }
    }
}



