using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_filmes_webAPI.Properties.Domains;
using senai_filmes_webAPI.Properties.Interfaces;
using senai_filmes_webAPI.Properties.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Controller responsável pelos endpoints referentes aos filmes
/// </summary>
namespace senai_filmes_webAPI.Properties.Controllers
{
    //define que as respostas serão em JSON
    [Produces("application/json")]


    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private IFilmeRepository _FilmeRepository { get; set; }

        public FilmesController()
        {
            _FilmeRepository = new FilmeRepository();
        }

        [HttpGet]

        public IActionResult Get()
        {
            List<FilmeDomain> ListaFilmes = _FilmeRepository.ListarTodos();

            return Ok(ListaFilmes);
        }

        [HttpPost]
        public IActionResult POST(FilmeDomain NovoFilme)
        {
            _FilmeRepository.Cadastrar(NovoFilme);

            return StatusCode(201);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _FilmeRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
