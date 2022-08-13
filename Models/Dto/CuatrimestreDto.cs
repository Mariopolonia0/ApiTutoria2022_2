using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTutoria2022_2.Models.Dto
{
    public class CuatrimestreDto
    {
        public int año { get; set; }
        public int numerocuatrimestre { get; set; }
        public int nota { get; set; }
        public string asignaturacuatrimestre { get; set; }
        public string calificaciones { get; set; }

        public CuatrimestreDto(int año, int numerocuatrimestre, int nota, string asignaturacuatrimestre, string calificaciones)
        {
            this.año = año;
            this.numerocuatrimestre = numerocuatrimestre;
            this.nota = nota;
            this.asignaturacuatrimestre = asignaturacuatrimestre;
            this.calificaciones = calificaciones;
        }
    }
}
