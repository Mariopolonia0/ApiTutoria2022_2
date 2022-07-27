using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTutoria2022_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EstudiantesControlle : ControllersBase
    {
        private readonly Contexto _contexto;
        public EstudiantesControlle(Contexto contexto)
        {
            _contexto = contexto;
        }
        [HttpPost]
        public List<EstudiantesDto> GetEstudiantes(int estudianteId)
        {
            return 
                ).ToList();
        }

    }
}
