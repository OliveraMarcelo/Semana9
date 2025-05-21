
namespace Semana9
{
    partial class Program
    {
        public class Auto : Vehiculo
        {
            public override void Arrancar()
            {
                Console.WriteLine("Arranca Auto");
            }

            public override void MostrarTipo()
            {
                Console.WriteLine("Soy un Auto");
            }
        }
    }
}