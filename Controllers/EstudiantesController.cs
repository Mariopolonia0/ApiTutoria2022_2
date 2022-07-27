using ApiTutoria2022_2.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace ApiTutoria2022_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EstudiantesController : ControllerBase
    {
        private readonly Contexto _contexto;

        public EstudiantesController(Contexto contexto)
        {
            _contexto = contexto;
        }

        [HttpPost]
        public List<EstudiantesDto> GetEstudiantes(int estudianteId)
        {
            return (from estudiante in _contexto.Estudiantes
                    where (estudiante.EstudianteId == estudianteId)
                    select new EstudiantesDto(estudiante.EstudianteId, estudiante.CarreraId, estudiante.PersonaId, estudiante.Matricula, estudiante.BalanceTotal, estudiante.BalancePendiente)
                 ).ToList();
        }
    }
}