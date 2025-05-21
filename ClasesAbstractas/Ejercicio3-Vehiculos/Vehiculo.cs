
namespace Semana9
{
    partial class Program
    {
        public abstract class Vehiculo
        {
            public abstract void Arrancar();
            public abstract void MostrarTipo();
            public void Acelerar()
            {
                Console.WriteLine("Aceleramos o khe!");
            }
        }
    }
}