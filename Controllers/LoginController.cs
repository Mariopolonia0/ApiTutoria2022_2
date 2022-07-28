using ApiTutoria2022_2.Models;
using ApiTutoria2022_2.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiTutoria2022_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly Contexto _contexto;
        public LoginController(Contexto contexto)
        {
            _contexto = contexto;
        }

        // POST: api/Login
        [HttpPost]
        public async Task<ActionResult<LoginDto>> PostLogin(LoginIn loginIn)
        {
            var login = await _contexto.Logins!.FirstOrDefaultAsync(Login => Login.Usuario == loginIn.usuario);

            if (login != null)
                if (login.Password == loginIn.password)
                {
                    var estudiante = _contexto.Estudiantes!.Find(login.EstudianteId);
                    var persona = _contexto.Personas!.Find(estudiante!.PersonaId);
                    return Ok(new LoginDto(login.EstudianteId, persona!.Nombres, estudiante!.Matricula));
                }
            return Ok(new LoginDto(0, "LoginInvalido", "Null"));
        }
    }
}