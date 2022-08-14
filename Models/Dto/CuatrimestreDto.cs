using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTutoria2022_2.Models.Dto
{
    public class CuatrimestreDto
    {
        public int CuatrimestreId { get; set; }
        public string NumeroCuatrimestre { get; set; }
        public string? NombreMateria { get; set; }
        public string? Nota { get; set; }
        public string? Calificacion { get; set; }
        public CuatrimestreDto(int id, string numeroCuatrimestre, string? nombreMateria, string? nota, string? calificacion)
        {
            this.CuatrimestreId = id;
            this.NumeroCuatrimestre = numeroCuatrimestre;
            this.NombreMateria = nombreMateria;
            this.Nota = nota;
            this.Calificacion = calificacion;
        }
    }
}
