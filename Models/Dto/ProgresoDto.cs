namespace ApiTutoria2022_2.Models.Dto
{
    public class ProgresoDto
    {    
        public string tipoMateria { get; set; } = string.Empty;
        public int materiaAprobada { get; set; }
        public int materiaPendiente { get; set; }
        public int materiaRequerida { get; set; }
         public ProgresoDto(string tipoMateria, int materiaAprobada, int materiaPendiente, int materiaRequerida)
        {
            this.tipoMateria = tipoMateria;
            this.materiaAprobada = materiaAprobada;
            this.materiaPendiente = materiaPendiente;
            this.materiaRequerida = materiaRequerida;
        }
    }
}