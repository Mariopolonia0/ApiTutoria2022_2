using ApiTutoria2022_2.Models;
using ApiTutoria2022_2.Models.Dto;
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

        [HttpGet("{estudianteId}")]
        public List<String> GetCalificacion(int estudianteId)
        {
            return (from inscripcion in _contexto.Inscripciones
                    join cuatrimestre in _contexto.Cuatrimestre!
                    on inscripcion.CuatrimestreId equals cuatrimestre.CuatrimestreId
                    where (inscripcion.EstudianteId == estudianteId)
                    select cuatrimestre.yeard.ToString()
                ).ToList();
        }

        [HttpGet("{estudianteId}/{yeard}")]
        public List<CuatrimestreDto> GetCalificacion(int estudianteId, int yeard)
        {
            return (from calificaciones in _contexto.Calificaciones
                    join cuatrimestre in _contexto.Cuatrimestre!
                    on calificaciones.CuatrimestreId equals cuatrimestre.CuatrimestreId
                    join asignatura in _contexto.Asignaturas!
                    on calificaciones.AsignaturaId equals asignatura.AsignaturaId
                    where (calificaciones.EstudianteId == estudianteId && cuatrimestre.yeard == yeard)
                    select new CuatrimestreDto
                    (
                        cuatrimestre.numeroCuatrimestre.ToString(),
                        asignatura.Nombre,
                        calificaciones.Nota.ToString(),
                        calificaciones.Calificacion
                    )
                ).ToList();
        }
    }
}