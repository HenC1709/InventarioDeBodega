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

            JsonService.GuardarProductos(Productos);
        }
        // Obtener productos
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
    }
}