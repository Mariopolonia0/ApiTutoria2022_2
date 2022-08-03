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
    public class MateriaOptativaController : ControllerBase
    {
        private readonly Contexto _contexto;

        public MateeiaObligatoriaController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<MateriaOptativaDto> GetMateriaOptativa(int materiaAprobada)
        {

            return (from MAteiaOptativa in _contexto.MateriaOptativa
                    where (MAteriaOptativa.MateriaAprobada == materiaAprobada)
                    select new MAtreiaOptativa(materiaAprobada.MateriaAprobada, materiaAprobada.MateriaPendiente, materiaAprobada.MateriaRequerida)
                 ).ToList();

        }
    }
}
