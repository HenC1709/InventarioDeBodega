using InvetarioDeBodega.Models;
using InvetarioDeBodega.Services;
using System.Linq;

namespace InvetarioDeBodega.Logic
{
    public class InvetarioLogic
    {
        // Lista de inventario
        private List<Producto> Productos;
        // servicio Json
        private JsonService JsonService;
        // constructor
        public InvetarioLogic()
        {
             JsonService = new JsonService();

             Productos = JsonService.CargarProductos();
        }
        //Agregar Productos

        public void AgregarProductos(Producto producto)
        {
            
            Productos.Add(producto);
             
             ActualizarEstadoStock(producto);

            JsonService.GuardarProductos(Productos);
        }
        // Obtener productos 
         private void ActualizarEstadoStock(Producto producto)
        {
            producto.EnStock = producto.Cantidad > 0;
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
                JsonService.GuardarProductos(Productos);
            }
        }
       
    }
}