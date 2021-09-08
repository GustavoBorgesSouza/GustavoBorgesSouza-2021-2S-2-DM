using senai_filmes_webAPI.Properties.Domains;
using senai_filmes_webAPI.Properties.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Properties.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
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

        public UsuarioDomain BuscarPorEmailSenha(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT IdUsuario, Email, Senha, Permissao FROM Usuario WHERE Email = @email AND Senha = @senha;";

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    con.Open();

                    //Executa o comando e armazeda os dados no objeto rdr
                    SqlDataReader rdr = cmd.ExecuteReader();

                    //Caso tenham sido obtidos
                    if (rdr.Read())
                    {
                        //Cria um objeto do tipo UsuarioDomain
                        UsuarioDomain usuarioBuscado = new UsuarioDomain()
                        {
                            //Atribui as propriedades aos valores das colunas do banco de dados
                            IdUsuario = Convert.ToInt32(rdr[0]),
                            Email = rdr[1].ToString(),
                            Senha = rdr[2].ToString(),
                            Permissao = rdr[3].ToString()
                        };

                        //Retorna o usuário buscado
                        return usuarioBuscado;
                    }

                    //Caso não encontre um email e senha correspondente, retorna nulo
                    return null;
                }

                

            }
        }
    }
}
