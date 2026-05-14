using System.Data.SqlTypes;
using InvetarioDeBodega.Logic;
using InvetarioDeBodega.Models;
using InvetarioDeBodega.Helpers;
using System.Runtime.CompilerServices;

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
            Console.WriteLine("4. Cambiar de estado");
            Console.WriteLine("0. Salir. ");

         string opcion =  Console.ReadLine()!;

         switch (opcion)
                {
                case "1":
              AgregarProductoMenu();
                break;
                case "2":
              MostrarProductosMenu();
                break;
                case "3":
              BuscarProductoMenu();
                break;
                case "4":
                CambiarEstadoStockMenu();
                break;

                case "0":
                ejecutando = false;
                break;
                default:
                Console.WriteLine("Opcion Invalida");
                break;
                }
            }
        }



        private void AgregarProductoMenu()
        {
             Console.WriteLine("\n====Agregar Producto====\n");

             string nombre = InputHelper.ReadString("Nombre: ");       
             string categoria = InputHelper.ReadString("categoria: ");    
             int cantidad = InputHelper.ReadInt("Cantidad: ");
             decimal precio = InputHelper.ReadDecimal("Precio: ");

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
        }

       private void MostrarProductosMenu()
        {
          Console.Clear();
          Console.WriteLine("=== INVENTARIO ===\n");
         List<Producto> productos = Invetario.ObtenerProductos();
        foreach (var producto in productos)
           {
             Console.WriteLine($"Nombre: {producto.Nombre}");                    Console.WriteLine($"Categoria: {producto.Categoria}");
             Console.WriteLine($"Cantidad: {producto.Cantidad}");
             Console.WriteLine($"Precio: {producto.Precio}");
            producto.EnStock = producto.Cantidad > 0;
            string estado =
            producto.EnStock
            ? "Disponible"
            : "Fuera de Stock";
            Console.WriteLine($"Estado: {estado}");        
           Console.WriteLine("----------------------");  
           }
           Console.ReadKey();
        }
        private void BuscarProductoMenu()
        {
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
        }
        private void CambiarEstadoStockMenu()
        {
            Console.Clear();
            Console.WriteLine("=== FUERA DE STOCK ===\n");
            Console.Write("Nombre del producto: ");
            string NombreProducto = Console.ReadLine()!;
            Invetario.CambiarEstadoStock(NombreProducto);
            Console.WriteLine("\nProducto marcado fuera de stock.");
            Console.ReadKey();
        }

    }
    
}