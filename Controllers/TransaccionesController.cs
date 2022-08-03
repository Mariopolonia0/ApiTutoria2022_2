using ApiTutoria2022_2.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiTutoria2022_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransaccionesController : ControllerBase
    {
        private readonly Contexto _contexto;

        public TransaccionesController(Contexto contexto)
        {
            _contexto = contexto;
        }

        [HttpGet("{estudianteId}")]
        public List<TransaccionDto> GetListaTransacciones(int estudianteId)
        {
            var list = new List<TransaccionDto>();
            foreach (var item in _contexto.Transaccion!.Where(transaccion => transaccion.EstudianteId == estudianteId)
                        .OrderByDescending(transaccion => transaccion.FechaRegistro))
            {
                list.Add(new TransaccionDto(item.Descripcion, item.FechaRegistro, item.Movimiento, item.Estado));
            }
            return list;
        }
    }
}