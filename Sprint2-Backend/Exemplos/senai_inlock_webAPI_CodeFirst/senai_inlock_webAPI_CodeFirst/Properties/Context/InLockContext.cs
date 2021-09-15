using Microsoft.EntityFrameworkCore;
using senai_inlock_webAPI_CodeFirst.Properties.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_inlock_webAPI_CodeFirst.Properties.Context
{
    /// <summary>
    /// Classe responsável pelo contexto do projeto
    /// faz a comunicação entre a API e o banco de dados
    /// </summary>
    public class InLockContext : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuarios { get; set; }
        public DbSet<Estudios> Estudios { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Jogos> Jogos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE0113I2\\SQLEXPRESS; Database=Inlock_Games_CodeFirst; user ID=sa; pwd=Senai@132 ");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Define a entidade já com dados
            modelBuilder.Entity<TiposUsuario>().HasData(
                new TiposUsuario
                {
                    idTipoUsuario = 1,
                    titulo = "Administrador"
                },

                new TiposUsuario
                {
                    idTipoUsuario = 2,
                    titulo = "Cliente"
                }
                );

            modelBuilder.Entity<Usuarios>().HasData(
                new Usuarios
                {
                    idUsuario = 1,
                    email = "admin@admin.com",
                    senha = "admin",
                    idTipoUsuario = 1
                },

                new Usuarios
                {
                    idUsuario = 2,
                    email = "cliente@cliente.com",
                    senha = "cliente",
                    idTipoUsuario = 2
                }
                );

            modelBuilder.Entity<Estudios>().HasData(
                new Estudios { idEstudio = 1, nomeEstudio = "Blizzard" },
                new Estudios { idEstudio = 2, nomeEstudio = "Rockstar Studios" },
                new Estudios { idEstudio = 3, nomeEstudio = "Square Enix" }
                );

            modelBuilder.Entity<Jogos>().HasData(
                new Jogos
                {
                    idjogo = 1,
                    nomejogo = "Diablo 3",
                    dataLancamento = Convert.ToDateTime("15/05/2021"),
                    descricao = "jogo que diverte",
                    valor = Convert.ToDecimal("99,00"),
                    idEstudio = 1
                },

                new Jogos
                {
                    idjogo = 2,
                    nomejogo = "Red dead redemption II",
                    dataLancamento = Convert.ToDateTime("26/10/2018"),
                    descricao = "jogo que diverte",
                    valor = Convert.ToDecimal("120,00"),
                    idEstudio = 2
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
