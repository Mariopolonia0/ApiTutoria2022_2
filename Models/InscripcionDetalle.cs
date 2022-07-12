using System.ComponentModel.DataAnnotations;

namespace ApiTutoria2022_2.Models
{
    public class InscripcionDetalle
    {
        [Key]
        public int InscripcionDetalleId { get; set; } = 0;
        public int InscripcionId { get; set; } = 0;
        public int AsignaturaId { get; set; } = 0;
    }
}