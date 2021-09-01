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
    public class VeiculosController : ControllerBase
    {
        private IVeiculoRepository _VeiculoRepository { get; set;  }

        public VeiculosController()
        {
            _VeiculoRepository = new VeiculoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<VeiculoDomain> ListaVeiculos = _VeiculoRepository.ListarTodos();

                return Ok(ListaVeiculos);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
            
        }
    }
}
