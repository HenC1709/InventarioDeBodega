using System.IO.Compression;
using InvetarioDeBodega.Logic;
using InvetarioDeBodega.Models;
using InvetarioDeBodega.Services;

InvetarioLogic invetario = new InvetarioLogic();

// agregar Producto 
/* invetario.AgregarProductos(new Producto
{
    Nombre = "Aceite",
    Categoria = "Cocina",
    Cantidad = 8,
    Precio = 23400
}); */  
// Cargar 
List<Producto> productos = invetario.ObtenerProductos();

Producto? productoEncontrado = invetario.BuscarProductoPorNombre("Arroz");

if (productoEncontrado != null)
{
    Console.WriteLine("\nPRODUCTO ENCONTRAOD:");
    Console.WriteLine(productoEncontrado.Nombre);
}
else
{
    Console.WriteLine("PRODUCTO SIN EXISTENCIA. ");
}

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