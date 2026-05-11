using InvetarioDeBodega.Logic;
using InvetarioDeBodega.Models;
using InvetarioDeBodega.Services;

InvetarioLogic invetario = new InvetarioLogic();

// agregar Producto 
invetario.AgregarProductos(new Producto
{
    Nombre = "Aceite",
    Categoria = "Cocina",
    Cantidad = 8,
    Precio = 23400
});
// Cargar 
List<Producto> productos = invetario.ObtenerProductos();

// MOSTRAR LO GUARDADO
Console.WriteLine("PRODUCTOS CARGADOS:\n ");

foreach (var producto in productos)
{
    Console.WriteLine($"Nombre: {producto.Nombre}");
    Console.WriteLine($"Categoria: {producto.Categoria}");
    Console.WriteLine($"Cantidad: {producto.Cantidad}");
    Console.WriteLine($"Precio: {producto.Precio}");
    Console.WriteLine("--------------------------");
}