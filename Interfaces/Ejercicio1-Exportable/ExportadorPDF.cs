
namespace Semana9
{
    partial class Program
    {
        public class ExportadorPDF : IExportable
        {
            public void Exportar(string contenido)
            {
                Console.WriteLine($" Se exporta en formato PDF {contenido}");
            }
        }
    }
}