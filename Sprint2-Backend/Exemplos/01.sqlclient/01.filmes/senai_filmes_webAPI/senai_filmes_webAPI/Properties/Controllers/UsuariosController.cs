using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_filmes_webAPI.Properties.Domains;
using senai_filmes_webAPI.Properties.Interfaces;
using senai_filmes_webAPI.Properties.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Properties.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _UsuarioRepository { get; set; }

        public UsuariosController()
        {
            _UsuarioRepository = new UsuarioRepository();
        }

        //post pq vai mandar algo no corpo da requisição
        [HttpPost("Login")]
        public IActionResult Login(UsuarioDomain login)
        {
            UsuarioDomain usuarioBuscado = _UsuarioRepository.BuscarPorEmailSenha(login.Email, login.Senha);

            if (usuarioBuscado != null)
            {
                return Ok(usuarioBuscado);
            }

            return NotFound("Email ou senha inválidos");
        }
    }
}
