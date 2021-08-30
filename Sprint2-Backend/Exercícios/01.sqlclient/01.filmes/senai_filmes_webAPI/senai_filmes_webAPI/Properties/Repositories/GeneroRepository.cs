using senai_filmes_webAPI.Properties.Domains;
using senai_filmes_webAPI.Properties.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Properties.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// String de conexão que recebe os parâmetros
        /// Data Source = Nome do Servidor
        /// initial  catalog = Nome do banco de dados
        /// user id= sa; pwd= Senai@132 = Faz a autenticação com o SQL SERVER, passando login e senha
        /// integrated security = Faz a autenticação com o usuário do sistema(windows)
        /// </summary>
        private string stringConexao = "Data Source=NOTE0113I2\\SQLEXPRESS; initial catalog=CATALOGO; user id=sa; pwd=Senai@132"; 
        //Conecta pelas infos de login


        /// <summary>
        /// String de conexão que recebe os parâmetros
        /// Data Source = Nome do Servidor
        /// initial  catalog = Nome do banco de dados
        /// user id= sa; pwd= Senai@132 = Faz a autenticação com o SQL SERVER, passando login e senha
        /// integrated security = Faz a autenticação com o usuário do sistema(windows)
        /// </summary>
        //private string stringConexao = "Data Source=localhost\\SQLEXPRESS01; initial catalog=CATALOGO; integrated security=true";
        public void AtualizarIdCorpo(GeneroDomain Genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdURL(int IdGenero, GeneroDomain Genero)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int IdGenero)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cadastrar um novo gênero
        /// </summary>
        /// <param name="NovoGenero">Objeto NovoGenero com as informações que serão cadastradas</param>
        public void Cadastrar(GeneroDomain NovoGenero)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                //string queryInsert = $"INSERT INTO Genero(NomeGenero) VALUES ('{NovoGenero.NomeGenero}')";
                //Não usar assim, pode gerar o efeito Joana D'arc e possibilita SQL injection
                string queryInsert = $"INSERT INTO Genero(NomeGenero) VALUES (@nomeGenero)";


                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@nomeGenero", NovoGenero.NomeGenero);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int IdGenero)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM Genero WHERE IdGenero = @IdINT";

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue("@IdINT", IdGenero);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Lista todos os gêneros
        /// </summary>
        /// <returns>Lista de gêneros</returns>
        public List<GeneroDomain> ListarTodos()
        {
            List<GeneroDomain> ListaGenero = new List<GeneroDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                //Declara a instrucao a ser executada
                string querySelectALL = "SELECT idGenero,NomeGenero FROM Genero;";

                //Abre a conexão com o banco de dados
                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectALL, con))
                {
                    //executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    //Enquanto houver registors para ler no rdr, o laço se repete. enquanto der pra ler vai ler
                    while (rdr.Read())
                    {
                        //Instancia de um objeto genero do tipo GeneroDomain
                        GeneroDomain genero = new GeneroDomain()
                        {
                            //Atribui as propriedades de Genero ao valor das colunas [x] do banco de dados.
                            IdGenero = Convert.ToInt32(rdr[0]),
                            NomeGenero = rdr[1].ToString()

                        };

                        //Adiciona na lista o objeto instanciaado, genero.
                        ListaGenero.Add(genero);
                    }
                }
            }

            return ListaGenero;
        
        }
    }
}
