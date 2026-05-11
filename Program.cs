using InvetarioDeBodega.Models;
using InvetarioDeBodega.Services;

JsonService jsonService = new JsonService();

// Crear Lista

List<Producto> productos = new List<Producto>();

// agregar Producto 
productos.Add(new Producto
{
    Nombre = "Arroz",
    Categoria = "Granos",
    Cantidad = 10,
    Precio = 4500
});
//Guardar 
jsonService.GuardarProductos(productos);
Console.WriteLine("Productos Guardados. ");

// Cargar 
List<Producto> ProductosCargados = jsonService.CargarProductos();

Console.WriteLine("\nPRODUCTOS CARGADOS ");

foreach (var producto in ProductosCargados)
{
    Console.WriteLine($"Nombre: {producto.Nombre}");
    Console.WriteLine($"Categoria: {producto.Categoria}");
    Console.WriteLine($"Cantidad: {producto.Cantidad}");
    Console.WriteLine($"Precio: {producto.Precio}");
    Console.WriteLine("--------------------------");
}