using CalculadorFreelance.Entidades;
using System.ComponentModel.DataAnnotations;

namespace CalculadorFreelance.Models
{
    public class CalculadorModel : Calculador
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [Range(0, 160, ErrorMessage = "La cantidad total de horas debe estar entre 0 y 150")]
        public int horas { get; set; }
        [Range(1000, 10000, ErrorMessage = "El valor hora debe estar entre 1000 y 10000")]
        public int valorHora { get; set; }
        public int montoTotal { get; set; }
        public CalculadorModel() { }
        public CalculadorModel(Calculador calculador)
        {
            nombre = calculador.nombre;
            horas = calculador.horas;
            valorHora = calculador.valorHora;
            montoTotal = calculador.montoTotal;
        }
     

    }
}
