
namespace Semana9
{
    partial class Program
    {
        public abstract class Vehiculo
        {
            public abstract void Arrancar();
            public virtual void MostrarTipo() {
                Console.WriteLine(this.GetType().Name);
            }
            public void Acelerar()
            {
                Console.WriteLine("Aceleramos o khe!");
            }
        }
    }
}