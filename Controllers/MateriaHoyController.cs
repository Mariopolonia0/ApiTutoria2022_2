using ApiTutoria2022_2.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiTutoria2022_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaHoyController : ControllerBase
    {
        private readonly Contexto _contexto;
        public MateriaHoyController(Contexto contexto)
        {
            _contexto = contexto;
        }
       
        [HttpGet("{estudianteId}")]
        public List<MateriasDto> GetMateriasHoy(int estudianteId)
        {
            string dia = DateTime.Now.ToString("dddd");
            return (from estudiante in _contexto.Estudiantes
                    join inscripciones in _contexto.Inscripciones!
                    on estudiante.EstudianteId equals inscripciones.EstudianteId
                    join inscripcionesDetalle in _contexto.InscripcionDetalles!
                    on inscripciones.InscripcionId equals inscripcionesDetalle.InscripcionId
                    join asignatura in _contexto.Asignaturas!
                    on inscripcionesDetalle.AsignaturaId equals asignatura.AsignaturaId
                    join secciones in _contexto.Secciones!
                    on asignatura.AsignaturaId equals secciones.AsignaturaId
                    join horario in _contexto.Horarios!
                    on secciones.SeccionId equals horario.SeccionId
                    where (estudiante.EstudianteId == estudianteId && horario.Dia == dia)
                    select new MateriasDto(asignatura.Nombre, horario.Dia, horario.Aula, horario.HoraInicio, horario.HoraFin)
                 ).ToList();
        }
        
    }
}