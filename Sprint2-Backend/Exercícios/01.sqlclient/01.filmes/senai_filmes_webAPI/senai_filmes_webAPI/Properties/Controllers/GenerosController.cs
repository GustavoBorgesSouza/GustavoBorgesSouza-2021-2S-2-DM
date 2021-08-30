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
/// Contolador responsável pelos endpoints referentes aos generos
/// </summary>
namespace senai_filmes_webAPI.Properties.Controllers
{
    //Define que o tipo de resposta da API será no formato JSON.
    [Produces("application/json")]

    //Define que a rota de uma requisição será no formato domínio/api/NomeController
    //ex: http://localhost:500/api/generos
    [Route("api/[controller]")]
    //COntrolador de API
    [ApiController]
    public class GenerosController : ControllerBase
    {
        /// <summary>
        /// Objeto que irá receber todos os métodos definidos na interface
        /// </summary>
        private IGeneroRepository _GeneroRepository { get; set; }

        /// <summary>
        /// Instancia um objeto _GeneroRepository para que haja referencia dos métodos no repositório.
        /// </summary>
        public GenerosController()
        {
            _GeneroRepository = new GeneroRepository();
        }

        [HttpGet]
        //IActionResult = resultado de uma ação
        //Get() = nome genérico
        public IActionResult Get()
        {
            //Lista de generos
            //Se conectar com o repositorio

            //Criar uma lista nomeada ListaGeneros para receber os dados
            List<GeneroDomain> ListaGeneros = _GeneroRepository.ListarTodos();

            //retorna o status code 200 com a ListaGeneros em JSON
            return Ok(ListaGeneros);
        }

        [HttpPost]
        public IActionResult Post(GeneroDomain NovoGenero)
        {
            //Fazer a chamada para o método .Cadastrar();
            _GeneroRepository.Cadastrar(NovoGenero);

            //retorna um status code 201 - Created
            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um genero existente
        /// </summary>
        /// <param name="id">id do genero a ser deletado</param>
        /// <returns>Endpoint 204= no content</returns>
        /// ex: http://localhost:5000/api/generos/excluir/10
        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id) 
        {
            _GeneroRepository.Deletar(id);

            return StatusCode(204);
        } 
    }
}
