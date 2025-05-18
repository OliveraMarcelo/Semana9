
namespace Semana9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1 - Figuras");
            Cuadrado cuadrado = new Cuadrado(5);
            cuadrado.calcularArea();
            Triangulo triangulo = new Triangulo(10, 10);
            triangulo.calcularArea();
            Circulo circulo = new Circulo(5);
            circulo.calcularArea();
            Console.WriteLine("Ejercicio 2 - Empleados");
            Empleado empleadoTiempoCompleto = new EmpleadoTiempoCompleto("Pedro", 60000, true);
            empleadoTiempoCompleto.calcularSueldo();
            Empleado empleadoMedioTiempo = new EmpleadoMedioTiempo("Maria", 40000, true);
            empleadoMedioTiempo.calcularSueldo();
        }
    }
}