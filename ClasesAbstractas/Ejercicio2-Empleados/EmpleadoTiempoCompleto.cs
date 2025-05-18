
namespace Semana9
{
    class EmpleadoTiempoCompleto : Empleado
    {
        public double bonoPresentismo = 1000;
        public bool presentismo = false;
        public EmpleadoTiempoCompleto(string nombre, double sueldoBase, bool presentismo) : base(nombre, sueldoBase)
        {
            this.nombre = nombre;
            this.sueldoBase = sueldoBase;
            this.presentismo = presentismo;
        }
        public override void calcularSueldo()
        {
            if (this.presentismo)
            {
                Console.WriteLine($"El sueldo de {this.nombre} es: {this.sueldoBase + this.bonoPresentismo}");
            }
            else
            {
                Console.WriteLine($"El sueldo de {this.nombre} es: {this.sueldoBase}");
            }
        }
    }
}