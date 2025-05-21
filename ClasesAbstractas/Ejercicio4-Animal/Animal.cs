
namespace Semana9
{
    partial class Program
    {
        public abstract class Animal
        {
            public abstract void EscucharSonido();
            public void MostrarTipo()
            {
                Console.WriteLine($"El sonido del {this.GetType().Name} es: ");
            }
        }
    }
}