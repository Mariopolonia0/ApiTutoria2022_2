namespace ApiTutoria2022_2.Models
{
    public class Transaccion
    {
        public int TransaccionId { get; set; }
        public int EstudianteId { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; }
        public decimal Movimiento { get; set; }
        public decimal Estado { get; set; }
    }
}