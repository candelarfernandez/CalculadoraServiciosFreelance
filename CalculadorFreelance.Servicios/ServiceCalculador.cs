using CalculadorFreelance.Entidades;

namespace CalculadorFreelance.Servicios
{
    public interface IServiceCalculador
    {
        public void Calcular(Calculador calculador);
        public List<Calculador> ObtenerResultados();
    }
    public class ServiceCalculador : IServiceCalculador
    {
        private static List<Calculador> lista = new List<Calculador>();
        public ServiceCalculador()
        {
            
        }
        public void Calcular(Calculador calculador)
        {
            calculador.montoTotal = calculador.horas * calculador.valorHora;
            lista.Add(calculador);
        }

        public List<Calculador> ObtenerResultados()
        {
            return lista.ToList();
        }
    }
}
