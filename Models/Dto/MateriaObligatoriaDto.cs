using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTutoria2022_2.Models.Dto
{
    public class MateriaObligatoriaDto
    {
        
        public int materiaAprobada { get; set; }
        public int materiaPendiente { get; set; }
        public int materiaRequerida { get; set; }

        public MateriaObligatoriaDto(int materiaAprobada, int materiaPediente, int materiaRequerida)
        {
            this.materiaAprobada = materiaAprobada;
            this.materiaPendiente = materiaPendiente;
            this.materiaRequerida = materiaRequerida;
        }
    }
}
