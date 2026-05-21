namespace InventarioDeBodega.Helpers
{
    public static class InputHelper
    {
        public static int ReadInt(string mensaje)
        {
            int valor;
            while (true)
            {
                Console.Write(mensaje);
                bool valido = int.TryParse(Console.ReadLine(), out valor);

                if (valido)
                {
                    return valor;
                }
                Console.WriteLine("valor invalido.\n");
            }
        }

        public static decimal ReadDecimal(string mensaje)
        {
            decimal valor;
            while (true)
            {
                Console.Write(mensaje);
                bool valido = decimal.TryParse(Console.ReadLine(), out valor);

                if (valido)
                {
                    return valor;
                }
                Console.WriteLine("Valor Invalido.\n");
            }
        }
        public static string ReadString(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string texto = Console.ReadLine()!;
                if (!string.IsNullOrEmpty(texto))
                {
                    return texto;
                }
                Console.WriteLine("Texto invalido.\n");
            }
        }
    }
}