namespace ApiTutoria2022_2.Models.Dto
{
    public class IndiceDto
    {
        public string? yeard { get; set; }
        public string? Meses { get; set; }
        public string? indicePeriodo { get; set; }
        public string? indiceAcumulado { get; set; }
        public IndiceDto(string? yeard, string? meses, string? indicePeriodo, string? indiceAcumulado)
        {
            this.yeard = yeard;
            this.Meses = meses;
            this.indicePeriodo = indicePeriodo;
            this.indiceAcumulado = indiceAcumulado;
        }
    }
}