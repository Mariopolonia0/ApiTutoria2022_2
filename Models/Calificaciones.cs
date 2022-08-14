using System.ComponentModel.DataAnnotations;

namespace ApiTutoria2022_2.Models
{
    public class Calificaciones
    {
        [Key]
        public int CalificacionesId { get; set; }
        public int CuatrimestreId { get; set; }
        public int EstudianteId { get; set; }
        public int AsignaturaId { get; set; }
        public int Nota { get; set; }
        public string? Calificacion { get; set; }
        
    }
}