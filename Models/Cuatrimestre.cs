using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTutoria2022_2.Models
{
    public class Cuatrimestre
    {
        [Key]
        public int Año { get; set; }
        public int NumeroCuatrimestre { get; set; }
        public int Nota { get; set; }
        public string AsignaturaCuatrimeste { get; set; }
        public string Calificacion { get; set; }
    }
}
