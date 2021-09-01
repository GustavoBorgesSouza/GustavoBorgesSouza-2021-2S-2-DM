using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_rental_webAPI.Properties.Domains
{
    /// <summary>
    /// Classe que representa a entidade Cliente do BD
    /// </summary>
    public class ClienteDomain
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string SobrenomeCliente { get; set; }
        public string CPF { get; set; }
    }
}
