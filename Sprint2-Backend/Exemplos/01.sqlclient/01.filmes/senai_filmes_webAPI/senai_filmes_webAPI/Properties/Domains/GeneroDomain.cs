using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Properties.Domains
{
    /// <summary>
    /// Classe que define/representa a entidade genero do banco
    /// </summary>
    public class GeneroDomain
    {
        public int IdGenero { get; set; }
        public string NomeGenero { get; set; }
    }
}
