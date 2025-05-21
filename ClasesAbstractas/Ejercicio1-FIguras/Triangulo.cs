
namespace Semana9
{
    class Triangulo : Figura
    {
        public double baseTriangulo = 0;
        public double altura = 0;
        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }
        public override void calcularArea()
        {
            double area = this.baseTriangulo * this.altura / 2;
            Console.WriteLine($"El área del triángulo es: {area}");
        }
    }
}