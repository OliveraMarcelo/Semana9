
namespace Semana9
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //CLASES ABSTRACTAS
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
            Console.WriteLine("Ejercicio 4 - Animales");
            Animal[] animales = new Animal[3];
            animales[0] = new Loro();
            animales[1] = new Gato();
            animales[2] = new Leon();
            foreach (Animal a in animales)
            {
                a.MostrarTipo();
                a.EscucharSonido();
                Console.WriteLine();
            }
            //INTERFACES
            Console.WriteLine("Ejercicio 1 - Interfaz exportador");
            string contenido = "Este es el informe de las personas encuestadas.";
            IExportable[] exportadores = new IExportable[3];
            exportadores[0] = new ExportadorExcel();
            exportadores[1] = new ExportadorPDF();
            exportadores[2] = new ExportadorCSV();
            foreach (IExportable exportador in exportadores)
            {
                exportador.Exportar(contenido);
            }
            Console.WriteLine("Ejercicio 2 - Interfaz IVehiculo");
            IVehiculo[] ivehiculos = new IVehiculo[3];
            ivehiculos[0] = new CAuto();
            ivehiculos[1] = new CMoto();
            ivehiculos[2] = new CBicicleta();
            foreach (IVehiculo v in ivehiculos)
            {
                v.Conducir();
                Console.WriteLine();
            }
        }
        public interface IApiRest
        {
            public void Get(int id);
            public void Post(string nuevoElemento);
            public void Put(int id, string cambio);
            public void Delete(int id);
        }
        public class Clientes : IApiRest
        {
            public void Get(int id)
            {
                Console.WriteLine($"Obteniendo cliente con ID: {id}");
            }
            public void Post(string nuevoElemento)
            {
                Console.WriteLine($"Agregando nuevo cliente: {nuevoElemento}");
            }
            public void Put(int id, string cambio)
            {
                Console.WriteLine($"Actualizando cliente con ID: {id} a {cambio}");
            }
            public void Delete(int id)
            {
                Console.WriteLine($"Eliminando cliente con ID: {id}");
            }
        }
    }
}