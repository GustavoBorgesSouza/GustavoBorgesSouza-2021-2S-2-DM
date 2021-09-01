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
        private string stringConexao = "Data Source=NOTE0113I2\\SQLEXPRESS; initial catalog=GBM_Rental; user id=sa; pwd=Senai@132";

        public void Atualizar(VeiculoDomain VeiculoAtualizado)
        {
            throw new NotImplementedException();
        }

        public VeiculoDomain BuscarPorid(int IdProcurar)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(VeiculoDomain NovoVeiculo)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int IdDeletar)
        {
            throw new NotImplementedException();
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
