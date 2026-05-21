using InventarioDeBodega.Logic;
using InventarioDeBodega.Models;
using InventarioDeBodega.Helpers;
namespace InventarioDeBodega.Menus
{
    public class Menu
    {
        private InventarioLogic Inventario;

        public Menu()
        {
            Inventario = new InventarioLogic();
        }
     public void MostrarMenu()
        {
           bool ejecutando = true;
           while ( ejecutando )
            {
            Console.Clear();

            ConsoleHelper.Title("INVENTARIO");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Mostrar productos");
            Console.WriteLine("3. Buscar producto");
            Console.WriteLine("4. Cambiar de estado");
            Console.WriteLine("5. Retirar Productos");
            Console.WriteLine("6. Agregar Stock");
            Console.WriteLine("7. Editar Producto");
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
                case"5":
                RetirarProductoMenu();
                break;
                case"6":
                AgregarStockMenu();
                break;
                case"7":
                EditarProductoMenu();
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
             ConsoleHelper.Title("\nAgregar Producto\n");

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
                bool agregado = Inventario.AgregarProductos(nuevoProducto);
                if (!agregado)
                {
                    ConsoleHelper.Error("Este producto ya existe");
                    Console.ReadKey();
                    return;
                }
                ConsoleHelper.Success("\nProducto agregado Correctamente.");
                Console.ReadKey();
        }

       private void MostrarProductosMenu()
        {
          Console.Clear();
          ConsoleHelper.Title("=== INVENTARIO ===\n");
         List<Producto> productos = Inventario.ObtenerProductos();
         if (productos.Count == 0)
            {
                ConsoleHelper.Warning("No hay Productos Registrados.");
                Console.ReadKey();
                return;
            }
        foreach (var producto in productos)
           {
             Console.WriteLine($"Nombre: {producto.Nombre}");                   
              Console.WriteLine($"Categoria: {producto.Categoria}");
             Console.WriteLine($"Cantidad: {producto.Cantidad}");
             Console.WriteLine($"Precio: {producto.Precio}");
            if (producto.EnStock)
                {
                 ConsoleHelper.Success("Estado: Disponible");    
                }
                else
                {
                 ConsoleHelper.Warning("Estado: Fuera de stock");   
                } 
           }
           Console.ReadKey();
        }
        private void BuscarProductoMenu()
        {
            Console.Clear();
            ConsoleHelper.Title("==== Buscar Producto ===\n");

                string Nombre = InputHelper.ReadString("Ingrese el nombre: ");

                Producto? productoEncontrado = Inventario.BuscarProductoPorNombre(Nombre);
                if (productoEncontrado != null)
                {
               ConsoleHelper.Success("\nPRODUCTO ENCONTRADO:\n");
               Console.WriteLine($"Nombre: {productoEncontrado.Nombre}");
               Console.WriteLine($"Categoria: {productoEncontrado.Categoria}");
               Console.WriteLine($"Cantidad: {productoEncontrado.Cantidad}");
               Console.WriteLine($"Precio: {productoEncontrado.Precio}");  
               if (productoEncontrado.EnStock)
                {
                 ConsoleHelper.Success("Estado: Disponible");    
                }
                else
                {
                 ConsoleHelper.Warning("Estado: Fuera de stock");   
                } 
              Console.ReadKey();
            }
        }
        private void CambiarEstadoStockMenu()
        {
            Console.Clear();
            ConsoleHelper.Title("=== FUERA DE STOCK ===\n");
            string NombreProducto = InputHelper.ReadString("Nombre del producto: ");
            Inventario.CambiarEstadoStock(NombreProducto);
            ConsoleHelper.Warning("\nProducto marcado fuera de stock.");
            Console.ReadKey();
        }
       private void RetirarProductoMenu()
        {
            Console.Clear();
            ConsoleHelper.Title("=== RETIRAR PRODUCTO ===\n");

            string nombre = InputHelper.ReadString("Nombre del producto: ");

            int cantidad = InputHelper.ReadInt("Cantidad a Retirar: ");

            bool retiroExitoso = Inventario.RetirarProducto(nombre, cantidad);

            if (retiroExitoso)
            {
                Console.WriteLine("\nRetiro exitoso. ");
            }
            else
            {
               Console.WriteLine("\nNo se pudo realizar el retiro. ");
            }
            Console.ReadKey();
        }
        private void AgregarStockMenu()
        {
             Console.Clear();
            ConsoleHelper.Title("=== AGREGAR STOCK ===\n");

            string nombre = InputHelper.ReadString("Nombre del producto: ");

            int cantidad = InputHelper.ReadInt("Cantidad a Ingresar: ");

            bool AgregarExitoso = Inventario.AgregarStock(nombre, cantidad);

            if (AgregarExitoso)
            {
                ConsoleHelper.Success("\nSTOCK AGREGADO ");
            }
            else
            {
             ConsoleHelper.Error("\nNo se pudo agregar stock.");
             }  
            Console.ReadKey();
        }
        private void EditarProductoMenu()
        {
            Console.Clear();
            ConsoleHelper.Title("Editar Producto");
            string nombreActual = InputHelper.ReadString("Nombre del producto: ");

            string nuevoNombre = InputHelper.ReadString("Nuevo Nombre: ");
            string nuevaCategoria = InputHelper.ReadString("Nuevo Categoria: ");
            int nuevaCantidad = InputHelper.ReadInt("Nueva Cantidad: ");
            decimal nuevoPrecio = InputHelper.ReadDecimal("Nuevo precio: ");

            bool editado = Inventario.EditarProducto( 
                nombreActual, nuevoNombre, nuevaCategoria,
                nuevaCantidad, nuevoPrecio
            );
            if (editado)
            {
                ConsoleHelper.Success("\nProductoEditado Correctamente.");
            }
            else
            {
                ConsoleHelper.Error("\nProducto no encontrado.");
            }
            Console.ReadKey();
        }
    }
    
}