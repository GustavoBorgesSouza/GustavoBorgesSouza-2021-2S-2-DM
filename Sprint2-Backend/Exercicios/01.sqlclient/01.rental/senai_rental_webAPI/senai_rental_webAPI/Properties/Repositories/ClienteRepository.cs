using senai_rental_webAPI.Properties.Domains;
using senai_rental_webAPI.Properties.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_rental_webAPI.Properties.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        //Conexão pelas infos de login do senai
        /// <summary>
        /// String de conexão que recebe os parâmetros
        /// Data Source = Nome do Servidor
        /// initial  catalog = Nome do banco de dados
        /// user id= sa; pwd= Senai@132 = Faz a autenticação com o SQL SERVER, passando login e senha
        /// integrated security = Faz a autenticação com o usuário do sistema(windows)
        /// </summary>
        //private string stringConexao = "Data Source=NOTE0113I2\\SQLEXPRESS; initial catalog=GBM_Rental; user id=sa; pwd=Senai@132";

        //Conecta pelo windows de casa
        /// <summary>
        /// String de conexão que recebe os parâmetros
        /// Data Source = Nome do Servidor
        /// initial  catalog = Nome do banco de dados
        /// user id= sa; pwd= Senai@132 = Faz a autenticação com o SQL SERVER, passando login e senha
        /// integrated security = Faz a autenticação com o usuário do sistema(windows)
        /// </summary>
        private string stringConexao = "Data Source=localhost\\SQLEXPRESS01; initial catalog=GBM_Rental; integrated security=true";

        public void Atualizar(ClienteDomain ClienteAtualizado)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryUpdate = "UPDATE Cliente SET NomeCliente = @novoNome, SobrenomeCliente = @novoSobrenome, CPF = @novoCPF WHERE IdCliente = @Id;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@novoNome", ClienteAtualizado.NomeCliente);
                    cmd.Parameters.AddWithValue("@novoSobrenome", ClienteAtualizado.SobrenomeCliente);
                    cmd.Parameters.AddWithValue("@novoCPF", ClienteAtualizado.CPF);
                    cmd.Parameters.AddWithValue("@Id", ClienteAtualizado.IdCliente);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public ClienteDomain BuscarPorid(int IdProcurar)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectById = "SELECT IdCliente, NomeCliente, SobrenomeCliente, CPF FROM Cliente WHERE IdCliente = @idcliente;";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectById, con))
                {
                    cmd.Parameters.AddWithValue("@idcliente", IdProcurar);

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        ClienteDomain clienteBuscado = new ClienteDomain()
                        {
                            IdCliente = Convert.ToInt32(rdr[0]),
                            NomeCliente = rdr[1].ToString(),
                            SobrenomeCliente = rdr[2].ToString(),
                            CPF = rdr[3].ToString()
                        };

                        return clienteBuscado;
                    }

                    return null;
                }
            }
        }

        public void Cadastrar(ClienteDomain NovoCliente)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO Cliente(NomeCliente, SobrenomeCliente, CPF) VALUES (@novoNome, @novoSobrenome, @novoCPF);";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@novoNome", NovoCliente.NomeCliente);
                    cmd.Parameters.AddWithValue("@novoSobrenome", NovoCliente.SobrenomeCliente);
                    cmd.Parameters.AddWithValue("@novoCPF", NovoCliente.CPF);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int IdDeletar)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM Cliente WHERE IdCliente = @idCliente;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue("@idCliente", IdDeletar);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ClienteDomain> ListarTodos()
        {
            List<ClienteDomain> ListaClientes = new List<ClienteDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT IdCliente, NomeCliente, SobrenomeCliente, CPF FROM Cliente;";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        ClienteDomain cliente = new ClienteDomain()
                        {
                            IdCliente = Convert.ToInt32(rdr[0]),
                            NomeCliente = rdr[1].ToString(),
                            SobrenomeCliente = rdr[2].ToString(),
                            CPF = rdr[3].ToString()
                        };

                        ListaClientes.Add(cliente);
                    }
                    
                }
            }

            return ListaClientes;
        }
    }
}
