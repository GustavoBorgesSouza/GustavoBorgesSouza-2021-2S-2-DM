using senai_rental_webAPI.Properties.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_rental_webAPI.Properties.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório ClienteRepository
    /// </summary>
    interface IClienteRepository
    {
        /// <summary>
        /// Retorna todos os clientes
        /// </summary>
        /// <returns>Uma lista de clientes</returns>
        List<ClienteDomain> ListarTodos();

        /// <summary>
        /// Busca um cliente pelo ID
        /// </summary>
        /// <param name="IdProcurar">Id do cliente a ser procurado</param>
        /// <returns>Objeto do tipo ClienteDomain que foi buscado</returns>
        ClienteDomain BuscarPorid(int IdProcurar);

        /// <summary>
        /// Cadastra um novo cliente
        /// </summary>
        /// <param name="NovoCliente">Objeto do tipo ClienteDomain que será cadastrado</param>
        void Cadastrar(ClienteDomain NovoCliente);

        /// <summary>
        /// Atualiza um cliente já existente
        /// </summary>
        /// <param name="ClienteAtualizado">Objeto do tipo clienteDomain que contém os atributos a serem atualizados</param>
        void Atualizar(ClienteDomain ClienteAtualizado);

        /// <summary>
        /// Deleta/exclui um cliente
        /// </summary>
        /// <param name="IdDeletar">Id do cliente que será deletado</param>
        void Deletar(int IdDeletar);
    }
}
