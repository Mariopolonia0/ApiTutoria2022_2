using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTutoria2022_2.Models
{
    public class MateriaObligatoria
    {
        [Key]
        public int MateriaAprobada { get; set; }
        public int MateriaPendiente { get; set; }
        public int MateriaRequerida { get; set; }
    }
}
