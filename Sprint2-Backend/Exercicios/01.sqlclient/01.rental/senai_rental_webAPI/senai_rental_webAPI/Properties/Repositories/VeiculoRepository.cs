using senai_rental_webAPI.Properties.Domains;
using senai_rental_webAPI.Properties.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_rental_webAPI.Properties.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
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
        public void Atualizar(VeiculoDomain VeiculoAtualizado)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryUpdate = "UPDATE Veiculo SET IdEmpresa = @novaEmpresa, IdModelo = @novoModelo, CorVeiculo = @novaCor WHERE IdVeiculo =  @idveiculo;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@novaEmpresa", VeiculoAtualizado.IdEmpresa);
                    cmd.Parameters.AddWithValue("@novoModelo", VeiculoAtualizado.IdModelo);
                    cmd.Parameters.AddWithValue("@novaCor", VeiculoAtualizado.CorVeiculo);
                    cmd.Parameters.AddWithValue("@idveiculo", VeiculoAtualizado.IdVeiculo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public VeiculoDomain BuscarPorid(int IdProcurar)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryById = "SELECT IdVeiculo, NomeEmpresa, NomeModelo, NomeMarca, CorVeiculo  FROM Veiculo LEFT JOIN Empresa ON Veiculo.IdEmpresa = Empresa.IdEmpresa INNER JOIN Modelo ON Veiculo.IdModelo = Modelo.IdModelo INNER JOIN Marca ON Modelo.IdMarca = Marca.IdMarca WHERE IdVeiculo = @idveiculo;";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryById, con))
                {
                    cmd.Parameters.AddWithValue("@idveiculo", IdProcurar);

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        VeiculoDomain veiculoBuscado = new VeiculoDomain()
                        {
                            IdVeiculo = Convert.ToInt32(rdr[0]),
                            Empresa = new EmpresaDomain()
                            {
                                NomeEmpresa = rdr[1].ToString()
                            },
                            Modelo = new ModeloDomain()
                            {
                                NomeModelo = rdr[2].ToString(),
                                Marca = new MarcaDomain()
                                {
                                    NomeMarca = rdr[3].ToString()
                                }
                            },
                            CorVeiculo = rdr[4].ToString()
                        };

                        return veiculoBuscado;
                    }

                    return null;
                }
            }
        }

        public void Cadastrar(VeiculoDomain NovoVeiculo)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO Veiculo(IdEmpresa, IdModelo, CorVeiculo) VALUES (@novaEmpresa, @novoModelo, @novaCor);";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@novaEmpresa", NovoVeiculo.IdEmpresa);
                    cmd.Parameters.AddWithValue("@novoModelo", NovoVeiculo.IdModelo);
                    cmd.Parameters.AddWithValue("@novaCor", NovoVeiculo.CorVeiculo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int IdDeletar)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM Veiculo WHERE IdVeiculo = @idveiculo;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue("@idveiculo", IdDeletar);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<VeiculoDomain> ListarTodos()
        {
            List<VeiculoDomain> ListaVeiculos = new List<VeiculoDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT IdVeiculo, NomeEmpresa, NomeModelo, NomeMarca, CorVeiculo  FROM Veiculo LEFT JOIN Empresa ON Veiculo.IdEmpresa = Empresa.IdEmpresa INNER JOIN Modelo ON Veiculo.IdModelo = Modelo.IdModelo INNER JOIN Marca ON Modelo.IdMarca = Marca.IdMarca;";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        VeiculoDomain veiculo = new VeiculoDomain()
                        {
                            IdVeiculo = Convert.ToInt32(rdr[0]),
                            Empresa = new EmpresaDomain()
                            {
                                NomeEmpresa = rdr[1].ToString()
                            },
                            Modelo = new ModeloDomain()
                            {
                                NomeModelo = rdr[2].ToString(),
                                Marca = new MarcaDomain()
                                {
                                    NomeMarca = rdr[3].ToString()
                                }
                            },
                            CorVeiculo = rdr[4].ToString()
                        };

                        ListaVeiculos.Add(veiculo);
                    }
                }

                return ListaVeiculos;
            }
        }
    }
}
