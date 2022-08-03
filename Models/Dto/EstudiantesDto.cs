using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTutoria2022_2.Models.Dto
{
    public class EstudiantesDto
    {
        public int estduianteId { get; set; }
        public int carreraId { get; set; }
        public int personaId { get; set; }
        public string matricula { get; set; }
        public float balancetotal { get; set; }
        public float balancePendiente { get; set; }

        public EstudiantesDto(int estudianteId, int carreraId, int personaId, string matricula, float balancetotal, float balancePendiente)
        {
            this.estduianteId = estduianteId;
            this.carreraId = carreraId;
            this.personaId = personaId;
            this.matricula = matricula;
            this.balancetotal = balancetotal;
            this.balancePendiente = balancePendiente;
        }
    }
}
