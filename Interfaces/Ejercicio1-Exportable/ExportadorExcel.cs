
namespace Semana9
{
    partial class Program
    {
        public class ExportadorExcel : IExportable
        {
            public void Exportar(string contenido)
            {
                Console.WriteLine($" Se exporta en formato Excel {contenido}");
            }
        }
    }
}