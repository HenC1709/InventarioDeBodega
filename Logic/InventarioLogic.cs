using InvetarioDeBodega.Models;
using InvetarioDeBodega.Services;

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
    }
}