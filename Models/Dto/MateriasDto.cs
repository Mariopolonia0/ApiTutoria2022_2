namespace ApiTutoria2022_2.Models.Dto
{
    public class MateriasDto
    {
        public string nombreMateria { get; set; } = string.Empty;
        public string aula { get; set; } = string.Empty;
        public string dia { get; set; } = string.Empty;
        public string horaInicio { get; set; } = string.Empty;
        public string horaFinal { get; set; } = string.Empty;


        public MateriasDto(string nombreMateria, string aula, string dia, string horaInicio, string horaFinal)
        {
            this.nombreMateria = nombreMateria;
            this.aula = aula;
            this.dia = dia;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;

        }
    }
}