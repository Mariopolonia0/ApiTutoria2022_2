using System.ComponentModel.DataAnnotations;

namespace ApiTutoria2022_2.Models
{
    public class AsignaturaAprobada
    {
        [Key]
        public int AsignaturaAprobadaId { get; set; }
        public int AsignaturaId { get; set; }
        public bool Optativa {get; set;} = true;
        public int EstudianteId { get; set; }
    }
}