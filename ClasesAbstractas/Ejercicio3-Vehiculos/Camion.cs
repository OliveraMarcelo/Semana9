
namespace Semana9
{
    partial class Program
    {
        public class Camion : Vehiculo
        {
            public override void Arrancar()
            {
                Console.WriteLine("Arranca Camion");
            }
            public override void MostrarTipo()
            {
                Console.WriteLine("Soy un camion");
            }
        }
    }
}