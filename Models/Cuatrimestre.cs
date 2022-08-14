using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTutoria2022_2.Models
{
    public class Cuatrimestre
    {
        [Key]
        public int CuatrimestreId { get; set; }
        public int yeard { get; set; }
        public int numeroCuatrimestre { get; set; }
    }
}
