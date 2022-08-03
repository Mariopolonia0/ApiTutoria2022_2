using System.ComponentModel.DataAnnotations;

namespace ApiTutoria2022_2.Models
{
    public class Carrera
    {
        [Key]
        public int CarreraId { get; set; }
        public int FacultadId { get; set; }
        public int DirectorId { get; set; }
        public string Nombre { get; set; } = string.Empty;
    }
}