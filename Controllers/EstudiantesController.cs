using ApiTutoria2022_2.Models.Dto;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("{estudianteId}")]
        public EstudiantesDto GetEstudiantes(int estudianteId)
        {
            return (from estudiante in _contexto.Estudiantes
                    join persona in _contexto.Personas!
                    on estudiante.PersonaId equals persona.PersonaId
                    join carrera in _contexto.Carreras!
                    on estudiante.CarreraId equals carrera.CarreraId
                    where (estudiante.EstudianteId == estudianteId)
                    select new EstudiantesDto(
                        persona.Nombres + " " + persona.Apellidos,
                        carrera.Nombre,
                        persona.CorreoInstitucion,
                        persona.Nacionalidad,
                        persona.Tutor,
                        persona.Celular
                    )
                ).Single();
        }
    }
}