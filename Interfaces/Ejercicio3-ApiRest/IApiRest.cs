
namespace Semana9
{
    partial class Program
    {
        public interface IApiRest
        {
            public void Get(int id);
            public void Post(string nuevoElemento);
            public void Put(int id, string cambio);
            public void Delete(int id);
        }
    }
}