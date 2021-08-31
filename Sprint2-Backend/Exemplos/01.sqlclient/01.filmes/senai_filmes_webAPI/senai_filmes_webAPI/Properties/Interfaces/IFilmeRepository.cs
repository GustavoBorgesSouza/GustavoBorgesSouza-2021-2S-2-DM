using senai_filmes_webAPI.Properties.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Properties.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório FilmeRepository
    /// </summary>
    interface IFilmeRepository
    {
        /// <summary>
        /// Retorna todos os filmes
        /// </summary>
        /// <returns>Uma lista de filmes</returns>
        List<FilmeDomain> ListarTodos();

        /// <summary>
        /// Busca um filme pelo Id
        /// </summary>
        /// <param name="IdGenero">Id do filme que você procurou</param>
        /// <returns>Objeto do tipo FilmeDomain que foi buscado</returns>
        FilmeDomain BuscarPorId(int IdGenero);

        /// <summary>
        /// Cadastra um novo filme 
        /// </summary>
        /// <param name="NovoFilme">Objeto NovoFilme com os dados a serem cadastrados</param>
        void Cadastrar(FilmeDomain NovoFilme);

        /// <summary>
        /// Atualiza um Filme existente passando o id na URL
        /// </summary>
        /// <param name="IdFilme">Id do filme que será atualizado</param>
        /// <param name="filme">Objeto filme com os dados a serem atualizados</param>
        void AtualizarIdURL(int IdFilme, FilmeDomain filme);

        /// <summary>
        /// Deleta um filme buscando um Id
        /// </summary>
        /// <param name="IdFilme">Id do filme a ser deletado</param>
        void Deletar(int IdFilme);
    }
}
