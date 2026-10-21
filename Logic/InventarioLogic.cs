using InventarioDeBodega.Services;
using InventarioDeBodega.Models;
using System.Linq;

namespace InventarioDeBodega.Logic
{
    public class InventarioLogic
    {
        // Lista de inventario
        private List<Producto> Productos;
        // servicio Json
        private JsonService JsonService;
        // constructor
        public InventarioLogic()
        {
             JsonService = new JsonService();

             Productos = JsonService.CargarProductos();
        }
        //Agregar Productos

        public bool AgregarProductos(Producto producto)
        {
            Producto? existente = BuscarProductoPorNombre(producto.Nombre);
            if (existente != null)
            {
                return false;
            }

            Productos.Add(producto);
             
             ActualizarEstadoStock(producto);

            JsonService.GuardarProductos(Productos);
            return true;
        }
        // Obtener productos 
         private void ActualizarEstadoStock(Producto producto)
        {
            producto.EnStock = producto.Cantidad > 0;

            producto.Activo = producto.Cantidad > 0;
        }
      public List<Producto> ObtenerProductos()        
        {
            return Productos;
        }
       public Producto? BuscarProductoPorNombre(string nombre)
        {
            return Productos.FirstOrDefault
            (p => p.Nombre.Trim().ToLower() ==
            nombre.Trim().ToLower()
            );
        }
        public void CambiarEstadoStock(string nombre)
        {
            Producto? producto = BuscarProductoPorNombre(nombre);
            if (producto != null)
            {
                producto.EnStock = false;
                producto.Activo = false;
                JsonService.GuardarProductos(Productos);
            }
        }
       public bool RetirarProducto(string nombre, int cantidad)
        {
            Producto? producto = BuscarProductoPorNombre(nombre);

            if (producto == null)
            {
                return false;
            }
            if (cantidad > producto.Cantidad)
            {
                return false;
            }
        
            producto.Cantidad -= cantidad;
            
            ActualizarEstadoStock(producto);
            JsonService.GuardarProductos(Productos);
            return true;
        }
        public bool AgregarStock(string nombre, int cantidad)
        {
            Producto? producto = BuscarProductoPorNombre(nombre);
             if (producto == null)
            {
                return false;
            }
            if (cantidad <= 0)
            {
                return false;
            }
            producto.Cantidad += cantidad;

            ActualizarEstadoStock(producto);
            JsonService.GuardarProductos(Productos);
            return true;
        }
        public bool EditarProducto(string nombreActual,
    string nuevoNombre,
    string nuevaCategoria,
    int nuevaCantidad,
    decimal nuevoPrecio)
        {
            Producto? producto = BuscarProductoPorNombre(nombreActual);
            if (producto == null)
            {
                return false;
            }
            producto.Nombre = nuevoNombre;
            producto.Categoria = nuevaCategoria;
            producto.Cantidad = nuevaCantidad;
            producto.Precio = nuevoPrecio;

            ActualizarEstadoStock(producto);
            JsonService.GuardarProductos(Productos);
            return true;
        }
    }
}