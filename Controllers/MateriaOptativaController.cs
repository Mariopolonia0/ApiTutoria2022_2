using ApiTutoria2022_2.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace ApiTutoria2022_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaOptativaController : ControllerBase
    {
        private readonly Contexto _contexto;

        public MateriaOptativaController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<MateriaOptativaDto> GetMateriaOptativa(int materiaAprobada)
        {
            return (from materia in _contexto.MateriasOptativas
                    where (materia.MateriaAprobada == materiaAprobada)
                    select new MateriaOptativaDto(materia.MateriaAprobada, materia.MateriaPendiente, materia.MateriaRequerida)
                 ).ToList();
        }
    }
}