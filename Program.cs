
namespace Semana9
{
    partial class Program
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
            Console.WriteLine("Ejercicio 3 - Vehiculos");
            Vehiculo[] vehiculos = new Vehiculo[3];
            vehiculos[0] = new Auto();
            vehiculos[1] = new Moto();
            vehiculos[2] = new Camion();
            foreach (Vehiculo v in vehiculos)
            {
                v.MostrarTipo();
                v.Arrancar();
                v.Acelerar();
                Console.WriteLine();
            }
        }
    }
}