using senai_rental_webAPI.Properties.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_rental_webAPI.Properties.Interfaces
{
    /// <summary>
    /// Interface responsável pelo VeiculoRepository
    /// </summary>
    interface IVeiculoRepository
    {
        /// <summary>
        /// Retorna todos os veiculos
        /// </summary>
        /// <returns>Uma lista de veiculos</returns>
        List<VeiculoDomain> ListarTodos();

        /// <summary>
        /// Busca um veiculo pelo ID
        /// </summary>
        /// <param name="IdProcurar">Id do veiculo a ser procurado</param>
        /// <returns>Objeto do tipo veiculoDomain que foi buscado</returns>
        VeiculoDomain BuscarPorid(int IdProcurar);

        /// <summary>
        /// Cadastra um novo veiculo
        /// </summary>
        /// <param name="Novoveiculo">Objeto do tipo veiculoDomain que será cadastrado</param>
        void Cadastrar(VeiculoDomain NovoVeiculo);

        /// <summary>
        /// Atualiza um veiculo já existente
        /// </summary>
        /// <param name="veiculoAtualizado">Objeto do tipo veiculoDomain que contém os atributos a serem atualizados</param>
        void Atualizar(VeiculoDomain VeiculoAtualizado);

        /// <summary>
        /// Deleta/exclui um veiculo
        /// </summary>
        /// <param name="IdDeletar">Id do veiculo que será deletado</param>
        void Deletar(int IdDeletar);
    }
}
