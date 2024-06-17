using APIChocoAmigo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIChocoAmigo.Repository.Interface
{
    public interface ISorteioRepository
    {
        Task<Sorteio> BuscarPorId(int id);
        Task Inserir(Sorteio sorteio);
        Task Atualizar(Sorteio sorteio);
        Task Excluir(Sorteio sorteio);
    }
}
