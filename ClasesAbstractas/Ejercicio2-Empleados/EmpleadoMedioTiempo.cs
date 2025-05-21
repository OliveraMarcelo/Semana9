
namespace Semana9
{
    class EmpleadoMedioTiempo : Empleado
    {
        public double bonoExtra = 700;
        public bool extra = false;
        public EmpleadoMedioTiempo(string nombre, double sueldoBase, bool extra) 
        {
            this.nombre = nombre;
            this.sueldoBase = sueldoBase;
            this.extra = extra;
        }
        public override void calcularSueldo()
        {
            if (this.extra)
            {
                Console.WriteLine($"El sueldo de {this.nombre} es: {this.sueldoBase + this.bonoExtra}");
            }
            else
            {
                Console.WriteLine($"El sueldo de {this.nombre} es: {this.sueldoBase}");
            }
        }
    }
}