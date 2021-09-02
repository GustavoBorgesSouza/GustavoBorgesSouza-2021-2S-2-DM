using senai_rental_webAPI.Properties.Domains;
using senai_rental_webAPI.Properties.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_rental_webAPI.Properties.Repositories
{
    public class AluguelRepository : IAluguelRepository
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
        public void Atualizar(AluguelDomain AluguelAtualizado)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryUpdate = "UPDATE Aluguel SET IdVeiculo = @novoVeiculo, IdCliente = @novoCliente, DataRetirada = @novaDataR, DataDevolucao = @novaDataD WHERE IdAluguel = @idaluguel;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryUpdate,con))
                {
                    cmd.Parameters.AddWithValue("@novoVeiculo",AluguelAtualizado.IdVeiculo);
                    cmd.Parameters.AddWithValue("@novoCliente", AluguelAtualizado.IdCliente);
                    cmd.Parameters.AddWithValue("@novaDataR", AluguelAtualizado.DataRetirada);
                    cmd.Parameters.AddWithValue("@novaDataD", AluguelAtualizado.DataDevolucao);

                    cmd.Parameters.AddWithValue("@idaluguel", AluguelAtualizado.IdAluguel);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public AluguelDomain BuscarPorid(int IdProcurar)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryselectById = "SELECT IdAluguel, NomeCliente, SobrenomeCliente, NomeModelo, CorVeiculo, DataRetirada, DataDevolucao FROM Aluguel INNER JOIN Cliente ON Aluguel.IdCliente = Cliente.IdCliente INNER JOIN Veiculo ON Aluguel.IdVeiculo = Veiculo.IdVeiculo INNER JOIN Modelo ON Veiculo.IdModelo = Modelo.IdModelo WHERE IdAluguel = @idaluguel;";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryselectById, con))
                {
                    cmd.Parameters.AddWithValue("@idaluguel", IdProcurar);

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        AluguelDomain aluguelBuscado = new AluguelDomain()
                        {
                            IdAluguel = Convert.ToInt32(rdr[0]),
                            Cliente = new ClienteDomain()
                            {
                                NomeCliente = rdr[1].ToString(),
                                SobrenomeCliente = rdr[2].ToString()
                            },
                            Veiculo = new VeiculoDomain()
                            {
                                Modelo = new ModeloDomain()
                                {
                                    NomeModelo = rdr[3].ToString()
                                },
                                CorVeiculo = rdr[4].ToString()
                            },
                            DataRetirada = Convert.ToDateTime(rdr[5]),
                            DataDevolucao = Convert.ToDateTime(rdr[6])
                        };

                        return aluguelBuscado;
                    }
                }

                return null;
            }
        }

        public void Cadastrar(AluguelDomain NovoAluguel)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO Aluguel(IdVeiculo, IdCliente, DataRetirada, DataDevolucao) VALUES (@novoVeiculo, @novoCliente, @novaDataR, @novaDataD);";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@novoVeiculo", NovoAluguel.IdVeiculo);
                    cmd.Parameters.AddWithValue("@novoCliente", NovoAluguel.IdCliente);
                    cmd.Parameters.AddWithValue("@novaDataR", NovoAluguel.DataRetirada);
                    cmd.Parameters.AddWithValue("@novaDataD", NovoAluguel.DataDevolucao);

                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void Deletar(int IdDeletar)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM Aluguel WHERE IdAluguel = @idaluguel;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue("@idaluguel", IdDeletar);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<AluguelDomain> ListarTodos()
        {
            List<AluguelDomain> ListaAlugueis = new List<AluguelDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryselectAll = "SELECT IdAluguel, NomeCliente, SobrenomeCliente, NomeModelo, CorVeiculo, DataRetirada, DataDevolucao FROM Aluguel INNER JOIN Cliente ON Aluguel.IdCliente = Cliente.IdCliente INNER JOIN Veiculo ON Aluguel.IdVeiculo = Veiculo.IdVeiculo INNER JOIN Modelo ON Veiculo.IdModelo = Modelo.IdModelo;";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryselectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        AluguelDomain aluguel = new AluguelDomain()
                        {
                            IdAluguel = Convert.ToInt32(rdr[0]),
                            Cliente = new ClienteDomain()
                            {
                                NomeCliente = rdr[1].ToString(),
                                SobrenomeCliente = rdr[2].ToString()
                            },
                            Veiculo = new VeiculoDomain()
                            {
                                Modelo = new ModeloDomain()
                                {
                                    NomeModelo = rdr[3].ToString()
                                },
                                CorVeiculo = rdr[4].ToString()
                            },
                            DataRetirada = Convert.ToDateTime(rdr[5]),
                            DataDevolucao = Convert.ToDateTime(rdr[6])
                        };

                        ListaAlugueis.Add(aluguel);
                    }
                }

                return ListaAlugueis;
            }
        }
    }
}
