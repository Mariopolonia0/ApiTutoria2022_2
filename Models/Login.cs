using System.ComponentModel.DataAnnotations;

namespace ApiTutoria2022_2.Models
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }
        public int EstudianteId { get; set; }
        public String Usuario { get; set; } = String.Empty;
        public String Password { get; set; } = String.Empty;
        public Login()
        {
            this.LoginId = 0;
            this.EstudianteId = 0;
        }

    }
}