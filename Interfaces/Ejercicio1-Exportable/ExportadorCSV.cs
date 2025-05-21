
namespace Semana9
{
    partial class Program
    {
        public class ExportadorCSV : IExportable
        {
            public void Exportar(string contenido)
            {
                Console.WriteLine($" Se exporta en formato CSV {contenido}");
            }
        }
    }
}