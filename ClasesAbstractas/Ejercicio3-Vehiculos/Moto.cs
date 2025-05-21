
namespace Semana9
{
    partial class Program
    {
        public class Moto : Vehiculo
        {
            public override void Arrancar()
            {
                Console.WriteLine("Arranca la moto");


            }

            public override void MostrarTipo()
            {
                Console.WriteLine("Soy una moto");
            }
        }
    }
}