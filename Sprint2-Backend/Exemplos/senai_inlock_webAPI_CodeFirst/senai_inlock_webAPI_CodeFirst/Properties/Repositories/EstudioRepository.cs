using Microsoft.EntityFrameworkCore;
using senai_inlock_webAPI_CodeFirst.Properties.Context;
using senai_inlock_webAPI_CodeFirst.Properties.Domains;
using senai_inlock_webAPI_CodeFirst.Properties.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_inlock_webAPI_CodeFirst.Properties.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        InLockContext ctx = new InLockContext();

        public void Atualizar(int idEstudio, Estudios estudioAtualizado)
        {
            Estudios estudioBuscado = BuscarPorId(idEstudio);

            if (estudioAtualizado.nomeEstudio != null)
            {
                estudioBuscado.nomeEstudio = estudioAtualizado.nomeEstudio;
            }

            ctx.Estudios.Update(estudioBuscado);

            ctx.SaveChanges();
        }

        public Estudios BuscarPorId(int idEstudio)
        {
            return ctx.Estudios.FirstOrDefault(e => e.idEstudio == idEstudio);
        }

        public void Cadastrar(Estudios novoEstudio)
        {
            ctx.Estudios.Add(novoEstudio);

            ctx.SaveChanges();
        }

        public void Deletar(int idEstudio)
        {
            Estudios estudioBuscado = BuscarPorId(idEstudio);

            ctx.Estudios.Remove(estudioBuscado);

            ctx.SaveChanges();
        }

        public List<Estudios> Listar()
        {
            return ctx.Estudios.ToList();
        }

        public List<Estudios> ListarComJogos()
        {
            return ctx.Estudios.Include(e => e.jogos).ToList();
        }
    }
}
