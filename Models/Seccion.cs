using System.ComponentModel.DataAnnotations;

namespace ApiTutoria2022_2.Models
{
    public class Seccion
    {
        [Key]
        public int SeccionId { get; set; } = 0;
        public int DocenteId { get; set; } = 0;
        public int AsignaturaId { get; set; } = 0;

    }
}