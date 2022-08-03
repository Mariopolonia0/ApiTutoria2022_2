using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTutoria2022_2.Models.Dto
{
    public class MateriaOptativaDto
    {
       public int MATeriaAProbada { get; set; }
       public int MATeriPEndiente { get; set; }
       public int MATeriaREquerida { get; set; }

        public MateriaOptativaDto(int MATeriaAProbada, int MATeriaPEndiente, int MATeriaREquerida)
        {
            this.MATeriaAProbada = MATeriaAProbada;
            this.MATeriPEndiente = MATeriPEndiente;
            this.MATeriaREquerida = MATeriaREquerida;
        }

    }
}
