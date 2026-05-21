namespace InventarioDeBodega.Services
{
    public class TicketService
    {
        public void GenerarTicket(string nombre, int cantidad)
        {
            string rutaCarpeta = "Tickets";
            Directory.CreateDirectory(rutaCarpeta);
            string nombreArchivo = $"ticket_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            string contenido =
$@"====== TICKET DE RETIRO ======

Producto: {nombre}
Cantidad Retirada: {cantidad}

Fecha: {DateTime.Now}

==============================";
 File.WriteAllText(rutaCompleta, contenido);
        }
    }
}