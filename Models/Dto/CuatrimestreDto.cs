using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTutoria2022_2.Models.Dto
{
    public class CuatrimestreDto
    {
        public string NumeroCuatrimestre { get; set; }
        public string? NombreMateria { get; set; }
        public string? Nota {get; set;}
        public string? Calificacion {get; set;}
        public CuatrimestreDto(string numeroCuatrimestre, string? nombreMateria, string? nota, string? calificacion)
        {
            NumeroCuatrimestre = numeroCuatrimestre;
            NombreMateria = nombreMateria;
            Nota = nota;
            Calificacion = calificacion;
        }
    }
}
