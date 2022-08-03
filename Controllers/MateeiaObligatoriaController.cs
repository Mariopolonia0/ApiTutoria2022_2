using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTutoria2022_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateeiaObligatoriaController : ControllerBase
    {
        private readonly Contexto _contexto;

        public MateeiaObligatoriaController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<MateriaObligatoriaDto> GetMateriaObligatoria(int MateriaAprobada)
        {
            return (from MateiaObligatoria in _contexto.MateriaOptativa
                    where (MAteriaObligatoria.MateriaAprobada == materiaAprobada)
                    select new MAteriaObligatoria(materiaAprobada.MateriaAprobada, materiaAprobada.MateriaPendiente, materiaAprobada.MateriaRequerida)
                ).ToList();

        }
    }
}
