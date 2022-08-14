using System.ComponentModel.DataAnnotations;

namespace ApiTutoria2022_2.Models
{
    public class Indice
    {
        [Key]
        public int IndiceId { get; set; }
        public int CuatrimestreId { get; set; }
        public int EstudianteId { get; set; }
        public string? indicePeriodo { get; set; }
        public string? indiceAcumulado { get; set; }
    }
}