
namespace Semana9
{
    class Circulo : Figura
    {
        public double radio = 0;
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public override void calcularArea()
        {
            double radio = Convert.ToDouble(this.radio);
            double area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine($"El área del círculo es: {area}");
        }
    }
}