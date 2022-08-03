using ApiTutoria2022_2.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiTutoria2022_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgresoController : ControllerBase
    {
        private readonly Contexto _contexto;

        public ProgresoController(Contexto contexto)
        {
            _contexto = contexto;
        }

        [HttpGet("{estudianteId}")]
        public List<ProgresoDto> GetProgreso(int estudianteId)
        {
            var list = new List<ProgresoDto>();
            var estudiante = _contexto.Estudiantes!.Single(estudiante => estudiante.EstudianteId == estudianteId);
            var carrera = _contexto.Carreras!.Where(carrera => carrera.CarreraId == estudiante.CarreraId).Single();

            var cantidadAsignaturaAprobadaObligatoria = _contexto.AsignaturaAprobadas!.Where(
                asignaturaaprobada => asignaturaaprobada.EstudianteId == estudiante.EstudianteId
                && asignaturaaprobada.Optativa == true).Count();

            var cantidadAsignaturaAprobadaOptativa = _contexto.AsignaturaAprobadas!.Where(
            asignaturaaprobada => asignaturaaprobada.EstudianteId == estudiante.EstudianteId
            && asignaturaaprobada.Optativa == false).Count();

            var asignaturaPendienteObligatoria = carrera.cantidadMateriaObligatorias - cantidadAsignaturaAprobadaObligatoria;
            var asignaturaPendienteOptativa = carrera.cantidadMateriaOptativas - cantidadAsignaturaAprobadaOptativa;

            list.Add(new ProgresoDto("Materia Obligatorias", cantidadAsignaturaAprobadaObligatoria, asignaturaPendienteObligatoria, carrera.cantidadMateriaObligatorias));
            list.Add(new ProgresoDto("Materia Optativas", cantidadAsignaturaAprobadaOptativa, asignaturaPendienteOptativa, carrera.cantidadMateriaOptativas));
            return list;
        }
    }
}
