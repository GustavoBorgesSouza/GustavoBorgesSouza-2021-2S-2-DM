using senai_rental_webAPI.Properties.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_rental_webAPI.Properties.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório AluguelRepository
    /// </summary>
    interface IAluguelRepository
    {
        /// <summary>
        /// Retorna todos os Alugueis
        /// </summary>
        /// <returns>Uma lista de Alugueis</returns>
        List<AluguelDomain> ListarTodos();

        /// <summary>
        /// Busca um Aluguel pelo ID
        /// </summary>
        /// <param name="IdProcurar">Id do Aluguel a ser procurado</param>
        /// <returns>Objeto do tipo AluguelDomain que foi buscado</returns>
        AluguelDomain BuscarPorid(int IdProcurar);

        /// <summary>
        /// Cadastra um novo Aluguel
        /// </summary>
        /// <param name="NovoAluguel">Objeto do tipo AluguelDomain que será cadastrado</param>
        void Cadastrar(AluguelDomain NovoAluguel);

        /// <summary>
        /// Atualiza um Aluguel já existente
        /// </summary>
        /// <param name="AluguelAtualizado">Objeto do tipo AluguelDomain que contém os atributos a serem atualizados</param>
        void Atualizar(AluguelDomain AluguelAtualizado);

        /// <summary>
        /// Deleta/exclui um Aluguel
        /// </summary>
        /// <param name="IdDeletar">Id do Aluguel que será deletado</param>
        void Deletar(int IdDeletar);
    }
}
