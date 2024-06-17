using APIChocoAmigo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIChocoAmigo.Repository.Interface
{
    public interface IGrupoRepository
    {
        Task<Grupo> BuscarPorId(int id);
        Task<int> BuscarId();
        Task Inserir(Grupo grupo);
        Task Atualizar(Grupo grupo);
        Task Excluir(Grupo grupo);
    }
}
