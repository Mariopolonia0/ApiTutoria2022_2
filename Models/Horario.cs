using System.ComponentModel.DataAnnotations;

namespace ApiTutoria2022_2.Models
{
    public class Horario
    {
        [Key]
        public int HorariosId { get; set; } = 0;
        public int SeccionId { get; set; } = 0;
        public string Aula { get; set; } = string.Empty;
        public string Dia { get; set; } = string.Empty;
        public string HoraInicio { get; set; } = string.Empty;
        public string HoraFin { get; set; } = string.Empty;
    }
}