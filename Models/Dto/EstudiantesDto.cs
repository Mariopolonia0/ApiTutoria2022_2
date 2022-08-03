using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTutoria2022_2.Models.Dto
{
    public class EstudiantesDto
    {
        public string nombrecompleto { get; set; } = string.Empty;
        public string carrera { get; set; } = string.Empty;
        public string correo { get; set; } = string.Empty;
        public string nacionalidad { get; set; } = string.Empty;
        public string tutor { get; set; } = string.Empty;
        public string celular { get; set; } = string.Empty;
        public EstudiantesDto(string nombrecompleto, string carrera, string correo, string nacionalidad, string tutor, string celular)
        {
            this.nombrecompleto = nombrecompleto;
            this.carrera = carrera;
            this.correo = correo;
            this.nacionalidad = nacionalidad;
            this.tutor = tutor;
            this.celular = celular;
        }
    }
}

