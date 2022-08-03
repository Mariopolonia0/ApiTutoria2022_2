namespace ApiTutoria2022_2.Models.Dto
{
    public class TransaccionDto
    {
        public string Descripcion { get; set; } = string.Empty;
        public DateTime fechaRealizado { get; set; }
        public Decimal transaccion { get; set; }
        public Decimal estado { get; set; }
        public TransaccionDto(string descripcion, DateTime fechaRealizado, decimal transaccion, decimal estado)
        {
            Descripcion = descripcion;
            this.fechaRealizado = fechaRealizado;
            this.transaccion = transaccion;
            this.estado = estado;
        }
    }
}