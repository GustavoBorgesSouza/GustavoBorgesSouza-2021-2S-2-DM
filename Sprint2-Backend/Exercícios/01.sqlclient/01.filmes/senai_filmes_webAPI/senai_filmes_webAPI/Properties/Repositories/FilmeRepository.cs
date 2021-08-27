using senai_filmes_webAPI.Properties.Domains;
using senai_filmes_webAPI.Properties.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Properties.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        /// <summary>
        /// String de conexão com parametros
        /// Data sourece = Nome servidor
        /// initial catalog = Nome do bacno de dados
        /// integrated security = faz a autenticação do windows
        /// </summary>
        private string stringConexao = "Data source=localhost\\SQLEXPRESS01; initial catalog=CATALOGO; integrated security=true";
        public void AtualizarIdURL(int IdFilme, FilmeDomain filme)
        {
            throw new NotImplementedException();
        }

        public FilmeDomain BuscarPorId(int IdGenero)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(FilmeDomain NovoFilme)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = $"INSERT INTO Filme(IdGenero, TituloFilme) VALUES ({NovoFilme.IdGenero}, '{NovoFilme.TituloFilme}')";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert,con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int IdFilme)
        {
            throw new NotImplementedException();
        }

        public List<FilmeDomain> ListarTodos()
        {
            List<FilmeDomain> ListaFilme = new List<FilmeDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectALL = "SELECT IdFilme, TituloFilme, NomeGenero FROM Filme LEFT JOIN Genero ON Filme.IdGenero = Genero.IdGenero";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectALL, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        //Os índices do objeto são em relação a query e não a classe
                        FilmeDomain filme = new FilmeDomain()
                        {
                            IdFilme = Convert.ToInt32(rdr[0]),
                            TituloFilme = rdr[1].ToString(),
                            Genero = new GeneroDomain()
                            {
                                NomeGenero = rdr[2].ToString()
                            }

                        };

                        ListaFilme.Add(filme);

                    }
                }
               

            return ListaFilme;
            }
        }
    }
}
