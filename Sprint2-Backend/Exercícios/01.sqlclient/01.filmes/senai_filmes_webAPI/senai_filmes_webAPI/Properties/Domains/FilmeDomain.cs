using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Properties.Domains
{
    /// <summary>
    /// Classe que define/representa a entidade filme do banco
    /// </summary>
    public class FilmeDomain
    {
        public int IdFilme { get; set; }
        public int IdGenero { get; set; }
        public string TituloFilme { get; set; }

        public GeneroDomain Genero { get; set; }  //o tipo da propriedade é GeneroDomain para poder trazer os atributos deste. Usa sempre que tiver join. Objeto dentro de objeto
    }
}
