using ApiTutoria2022_2.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace ApiTutoria2022_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaObligatoriaController : ControllerBase
    {
        private readonly Contexto _contexto;

        public MateriaObligatoriaController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<MateriaObligatoriaDto> GetMateriaObligatoria(int MateriaAprobada)
        {
            return (from materia in _contexto.MateriasObligatorias
                    where (materia.MateriaAprobada == MateriaAprobada)
                    select new MateriaObligatoriaDto(materia.MateriaAprobada, materia.MateriaPendiente, materia.MateriaRequerida)
                ).ToList();

        }
    }
}
