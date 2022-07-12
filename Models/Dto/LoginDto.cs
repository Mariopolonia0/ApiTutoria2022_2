namespace ApiTutoria2022_2.Models.Dto
{
    public class LoginDto
    {     
        public int estudianteId { get; set; }
        public string nombreEstudiante { get; set; } = String.Empty;
        public string matricula { get; set; } = String.Empty;

        public LoginDto(int estudianteId, string nombres, string matricula)
        {
            this.estudianteId = estudianteId;
            this.nombreEstudiante = nombres;
            this.matricula = matricula;
        }
    }
}