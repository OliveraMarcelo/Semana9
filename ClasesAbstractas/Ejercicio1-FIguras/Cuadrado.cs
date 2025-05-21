
namespace Semana9
{
    class Cuadrado : Figura
    {
        public double lado = 0;
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }
        public override void calcularArea()
        {
            double area = lado * lado;
            Console.WriteLine($"El área del cuadrado es: {area}");
        }
    }
}