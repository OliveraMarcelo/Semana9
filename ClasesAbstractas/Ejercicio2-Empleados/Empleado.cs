
namespace Semana9
{
    class Empleado
    {
        public string nombre;
        public double sueldoBase;
        public Empleado(string nombre, double sueldoBase)
        {
            this.nombre = nombre;
            this.sueldoBase = sueldoBase;
        }
        public virtual void calcularSueldo()
        {
            Console.WriteLine(this.sueldoBase);
        }
    }
}