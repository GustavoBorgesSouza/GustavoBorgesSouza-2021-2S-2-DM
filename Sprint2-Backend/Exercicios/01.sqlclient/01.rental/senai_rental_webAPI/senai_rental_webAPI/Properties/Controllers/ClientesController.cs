using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_rental_webAPI.Properties.Domains;
using senai_rental_webAPI.Properties.Interfaces;
using senai_rental_webAPI.Properties.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_rental_webAPI.Properties.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private IClienteRepository _ClienteRepository { get; set; }

        public ClientesController()
        {
            _ClienteRepository = new ClienteRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<ClienteDomain> ListaClientes = _ClienteRepository.ListarTodos();

                return Ok(ListaClientes);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }


        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                ClienteDomain ClienteBuscado = _ClienteRepository.BuscarPorid(id);

                if (ClienteBuscado == null)
                {
                    return NotFound("Cliente não encontrado");
                }

                return Ok(ClienteBuscado);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }

            
        }

        [HttpPost]
        public IActionResult Post(ClienteDomain NovoCliente)
        {
            try
            {
                _ClienteRepository.Cadastrar(NovoCliente);
                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpDelete("{IdDeleta}")]
        public IActionResult Delete(int IdDeleta)
        {
            try
            {
                _ClienteRepository.Deletar(IdDeleta);
                return StatusCode(204);

            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
            
        }

        [HttpPut]
        public IActionResult Put(ClienteDomain ClienteAtulizar)
        {
            ClienteDomain ClienteBuscado = _ClienteRepository.BuscarPorid(ClienteAtulizar.IdCliente);

            if (ClienteBuscado != null)
            {
                try
                {
                    _ClienteRepository.Atualizar(ClienteAtulizar);

                    return NoContent();
                }
                catch (Exception erro)
                {
                    return BadRequest(erro);
                }
                
            }

            return NotFound(new
            {
                mensagem = "Gênero não encontrado",
                Coderro = true
            });
        }

    }
}
