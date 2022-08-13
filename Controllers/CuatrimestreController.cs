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
    public class CuatrimestreController : ControllerBase
    {
        private readonly Contexto _contexto;
        public CuatrimestreController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public List<CuatrimestreDto> GetListaCuatrimestre(int año)
        {
            var list = new List<CuatrimestreDto>();
            foreach (var item in _contexto.Cuatrimestre!.Where(cuatrimestre => cuatrimestre.Nota == año)
                        .OrderByDescending(cuatrimestre => cuatrimestre.Calificacion))

            {

                list.Add(new CuatrimestreDto(item.Año, item.Nota, item.Calificacion));
            }
            return list;
        }

    }
}
