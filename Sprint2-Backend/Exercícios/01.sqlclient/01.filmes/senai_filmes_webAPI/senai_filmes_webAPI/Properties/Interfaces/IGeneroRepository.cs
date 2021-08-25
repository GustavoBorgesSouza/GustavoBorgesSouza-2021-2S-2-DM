using senai_filmes_webAPI.Properties.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Properties.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório GeneroRepository
    /// </summary>
    interface IGeneroRepository
    {
        //Estrutura de métodos da Interface
        //TipoRetorno NomeMetodo(TipoParametro NomeParametro);
        //void Listar();

        /// <summary>
        /// Retorna todos os gêneros
        /// </summary>
        /// <returns>Uma lista de generos</returns>
        List<GeneroDomain> ListarTodos();

        /// <summary>
        /// Busca um genero através do seu Id
        /// </summary>
        /// <param name="IdGenero">Id do genero que será buscado</param>
        /// <returns>Objeto do tipo GeneroDomain que foi buscado</returns>
        GeneroDomain BuscarPorId(int IdGenero);

        /// <summary>
        /// Cadastra um novo genero
        /// </summary>
        /// <param name="NovoGenero">Objeto NovoGenero com os dados que serão cadastrados</param>
        void Cadastrar(GeneroDomain NovoGenero);

        /// <summary>
        /// Atualiza um genero existente passando um Id pelo corpo da requisição
        /// </summary>
        /// <param name="Genero">Objeto genero com novos dados</param>
        /// exemplo: http://localhost:5/api/generos
        void AtualizarIdCorpo(GeneroDomain Genero);

        /// <summary>
        /// Atualiza um genero existente passando o Id pela URL da requisição
        /// </summary>
        /// <param name="IdGenero">Id do genero que será atualizado</param>
        /// <param name="Genero">Objeto genero com os novos dados</param>
        /// http://localhost:5/api/generos/id
        void AtualizarIdURL(int IdGenero, GeneroDomain Genero);

        /// <summary>
        /// Deleta um genero
        /// </summary>
        /// <param name="IdGenero">Id do genero que será deletado</param>
        void Deletar(int IdGenero);
    }
}
