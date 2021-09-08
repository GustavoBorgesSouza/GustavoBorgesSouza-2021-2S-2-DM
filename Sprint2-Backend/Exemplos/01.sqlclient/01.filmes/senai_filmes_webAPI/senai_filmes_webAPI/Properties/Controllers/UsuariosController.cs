using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using senai_filmes_webAPI.Properties.Domains;
using senai_filmes_webAPI.Properties.Interfaces;
using senai_filmes_webAPI.Properties.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
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
                //return Ok(usuarioBuscado); 
                //^ retorna os dados do usuários em json


                //Define os dados ques serão fornecidos no token - payload

                var minhasclaims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),   //ex: "email": "email@email.com"
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Role, usuarioBuscado.Permissao),
                    new Claim("Claim Personalizada ;)", "Teste valorFixo")
                };

                //Define a chave de acesso ao token

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("Autenticacao_ChaveFilmes"));

                //Define as credenciais do token - signature

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var MeuToken = new JwtSecurityToken(
                    issuer : "Filmes.webAPI",               //emissor do token
                    audience: "Filmes.webAPI",              //destinatário do token
                    claims: minhasclaims,                   //dados definidos acima, linha 42
                    expires: DateTime.Now.AddMinutes(30),   //tempo de expiracao
                    signingCredentials: creds               //credenciais do token, linha 56
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(MeuToken)
                });
            }

            return NotFound("Email ou senha inválidos");
        }
    }
}
