using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Properties.Domains
{
    /// <summary>
    /// Classe que define a entidade usuário do banco
    /// </summary>
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "informe o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [StringLength(10, MinimumLength = 3, ErrorMessage ="O campo precisa ter no mínimo 3 caracteres e no máximo 10")]
        public string Senha { get; set; }
        public string Permissao { get; set; }
    }
}
