using System.ComponentModel.DataAnnotations;

namespace ApiTutoria2022_2.Models
{
    public class Persona
    {
        [Key]
        public int PersonaId { get; set; }
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string NumeroCedula { get; set; } = string.Empty;
        public string Tutor { get; set; } = string.Empty;
        public int DireccionId { get; set; } = 0;
        public string Telefono { get; set; } = string.Empty;
        public string Celular { get; set; } = string.Empty;
        public string Nacionalidad { get; set; } = string.Empty;
        public char Sexo { get; set; } = 'N';
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;
        public string CorreoPersonal { get; set; } = string.Empty;
        public string CorreoInstitucion { get; set; } = string.Empty;
    }
}