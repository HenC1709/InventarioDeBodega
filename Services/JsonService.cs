using Newtonsoft.Json;
using InventarioDeBodega.Models;
using System.Text.Json.Serialization;

namespace InventarioDeBodega.Services
{
    public class JsonService
    {
        private readonly string ruta = "Data/productos.json";

        //Guardar Cambios!!!!!!!!!!!
        public void GuardarProductos(List<Producto> productos)
        {
            string json = JsonConvert.SerializeObject(productos, Formatting.Indented);

            File.WriteAllText(ruta, json);
        }
        //CargarProductos
        public List<Producto> CargarProductos()
        {
            if (!File.Exists(ruta))
            {
                return new List<Producto>();
            }

            string json = File.ReadAllText(ruta);

            List<Producto>? productos = JsonConvert.DeserializeObject<List<Producto>>(json);

            return productos ?? new List<Producto>();
        }
    }
}