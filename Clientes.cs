
namespace Semana9
{
    partial class Program
    {
        public class Clientes : IApiRest
        {
            public void Get(int id)
            {
                Console.WriteLine($"Obteniendo cliente con ID: {id}");
            }
            public void Post(string nuevoElemento)
            {
                Console.WriteLine($"Agregando nuevo cliente: {nuevoElemento}");
            }
            public void Put(int id, string cambio)
            {
                Console.WriteLine($"Actualizando cliente con ID: {id} a {cambio}");
            }
            public void Delete(int id)
            {
                Console.WriteLine($"Eliminando cliente con ID: {id}");
            }
        }
    }
}