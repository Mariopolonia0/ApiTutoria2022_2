using System.ComponentModel.DataAnnotations;

namespace ApiTutoria2022_2.Models
{
    public class Inscripcion
    {
        [Key]
        public int InscripcionId { get; set; } = 0;
        public int EstudianteId { get; set; } = 0;
        public DateTime FechaRegistrada { get; set; } = DateTime.Now;
        public DateTime FechaInicioTrimestre { get; set; } = DateTime.Now;
        public DateTime FechaFinalTrimestre { get; set; } = DateTime.Now;
        public bool UltimaInscripcion { get; set; } = true;

    }
}