using System.Data.SqlTypes;
using InvetarioDeBodega.Logic;
using InvetarioDeBodega.Models;

namespace InvetarioDeBodega.Menus
{
    public class Menu
    {
        private InvetarioLogic Invetario;

        public Menu()
        {
            Invetario = new InvetarioLogic();
        }
     public void MostrarMenu()
        {
           bool ejecutando = true;
           while ( ejecutando )
            {
            Console.Clear();

            Console.WriteLine("==== INVENTARIO ====");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Mostrar productos");
            Console.WriteLine("3. Buscar producto");
            Console.WriteLine("4. Salir");

         string opcion =  Console.ReadLine()!;

         switch (opcion)
                {
                case "1":
                Console.WriteLine("\n====Agregar Producto====\n");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine()!;

                Console.Write("Categoria: ");
                string categoria = Console.ReadLine()!;

                Console.Write("Cantidad: ");
                int cantidad = int.Parse(Console.ReadLine()!);

                Console.Write("Precio: ");
                decimal precio = decimal.Parse(Console.ReadLine()!);

                Producto nuevoProducto = new Producto
                {
                    Nombre = nombre,
                    Categoria = categoria,
                    Cantidad = cantidad,
                    Precio = precio,
                    EnStock = true
                };
                Invetario.AgregarProductos(nuevoProducto);
                Console.WriteLine("\nProducto agregado Correctamente.");
                Console.ReadKey();
                break;
                case "2":
                Console.Clear();

                Console.WriteLine("=== INVENTARIO ===\n");
                List<Producto> productos = Invetario.ObtenerProductos();

                foreach (var producto in productos)
                   {
                    Console.WriteLine($"Nombre: {producto.Nombre}");
                    Console.WriteLine($"Categoria: {producto.Categoria}");
                    Console.WriteLine($"Cantidad: {producto.Cantidad}");
                    Console.WriteLine($"Precio: {producto.Precio}");

                   Console.WriteLine("----------------------");  
                   }
                   Console.ReadKey();
                break;
                case "3":
                Console.WriteLine("==== Buscar Producto ===\n");

                Console.Write("Ingrese el nombre: ");
                string Nombre = Console.ReadLine()!;

                Producto? productoEncontrado = Invetario.BuscarProductoPorNombre(Nombre);
                if (productoEncontrado != null)
                    {
                     Console.WriteLine("\nPRODUCTO ENCONTRADO:\n");

                     Console.WriteLine($"Nombre: {productoEncontrado.Nombre}");
                     Console.WriteLine($"Categoria: {productoEncontrado.Categoria}");
                     Console.WriteLine($"Cantidad: {productoEncontrado.Cantidad}");
                     Console.WriteLine($"Precio: {productoEncontrado.Precio}");        
                    }
                else
                    {
                     Console.WriteLine("\nProducto no encontrado. ");       
                    } 
                    Console.ReadKey();
                break;
                case "4":
                ejecutando = false;
                break;
                default:
                Console.WriteLine("Opcion Invalida");
                break;
                }
            }
        }

    }
    
}