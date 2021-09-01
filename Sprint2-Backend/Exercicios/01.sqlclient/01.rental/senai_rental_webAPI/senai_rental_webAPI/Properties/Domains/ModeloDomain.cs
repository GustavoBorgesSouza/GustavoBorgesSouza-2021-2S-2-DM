using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_rental_webAPI.Properties.Domains
{
    /// <summary>
    /// Classe que representa a entidade Modelo do BD
    /// </summary>
    public class ModeloDomain
    {
        public int IdModelo { get; set; }
        public int IdMarca { get; set; }
        public string NomeModelo { get; set; }
        public DateTime AnoLancamento { get; set; }

        public MarcaDomain Marca { get; set; }
    }
}
