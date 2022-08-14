using ApiTutoria2022_2.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiTutoria2022_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndiceController
    {
        private readonly Contexto _contexto;

        public IndiceController(Contexto contexto)
        {
            _contexto = contexto;
        }

        [HttpGet("{estudianteId}/{cuatrimestreId}")]
        public IndiceDto GetIndiceDto(int estudianteId, int cuatrimestreId)
        {
            return (from cuatrimestre in _contexto.Cuatrimestre!
                    join indice in _contexto.Indices!
                    on cuatrimestre.CuatrimestreId equals indice.CuatrimestreId
                    where(indice.EstudianteId == estudianteId && indice.CuatrimestreId == cuatrimestreId)
                    select new IndiceDto
                    (
                        cuatrimestre.yeard.ToString(),
                        cuatrimestre.Meses,
                        indice.indicePeriodo,
                        indice.indiceAcumulado
                    )
            ).Single();
        }

    }
}