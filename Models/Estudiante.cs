using System.ComponentModel.DataAnnotations;

namespace ApiTutoria2022_2.Models
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }
        public int CarreraId { get; set; }
        public int PersonaId { get; set; }
        public String Matricula { get; set; } = string.Empty;
        public float BalanceTotal { get; set; }
        public float BalancePendiente { get; set; }
    }
}
