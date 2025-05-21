
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
            Console.WriteLine("Ejercicio 3 - Vehiculos");
            Vehiculo[] vehiculos = new Vehiculo[3];
              vehiculos[0] = new Auto();
              vehiculos[1] = new Moto();
              vehiculos[2] = new Camion();
              foreach (Vehiculo v in vehiculos)
              {
                  v.MostrarTipo();
                  v.Arrancar();
                  Console.WriteLine();
              }
        }
        public abstract class Vehiculo
        {
            public abstract void Arrancar();
            public abstract void MostrarTipo();
            public void Acelerar()
            {
                Console.WriteLine("Aceleramos o khe!");
            }
        }
        public class Auto : Vehiculo
        {
            public override void Arrancar()
            {
                Console.WriteLine("Arranca la Auto");
            }

            public override void MostrarTipo()
            {
                Console.WriteLine("Soy un Auto");
            }
        }
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
        public class Camion : Vehiculo
        {
            public override void Arrancar()
            {
                Console.WriteLine("Arranca Camion");
            }
            public override void MostrarTipo()
            {
                Console.WriteLine("Soy un camion");
            }
        }
    }
}