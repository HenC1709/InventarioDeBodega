namespace InventarioDeBodega.Models
{
    public class Producto
    {
       public string Nombre { get; set; } ="";
       public string Categoria { get; set; } ="";
       public int Cantidad { get; set; }
       public decimal Precio { get; set; }
       public bool EnStock { get; set; }
       public bool Activo { get; set; } = true;
    }
}