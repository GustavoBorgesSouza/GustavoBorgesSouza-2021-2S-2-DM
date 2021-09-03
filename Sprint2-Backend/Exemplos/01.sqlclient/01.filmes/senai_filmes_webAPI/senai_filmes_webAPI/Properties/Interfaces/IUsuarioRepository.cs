using senai_filmes_webAPI.Properties.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Interface responsável pelo repositorio UsuarioRepository
/// </summary>
namespace senai_filmes_webAPI.Properties.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Valida o usuario
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns>Um objeto do tipo UsuarioDomain que foi  buscado</returns>
        UsuarioDomain BuscarPorEmailSenha(string email, string senha);
    }
}
