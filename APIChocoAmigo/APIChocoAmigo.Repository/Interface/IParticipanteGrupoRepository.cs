using APIChocoAmigo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIChocoAmigo.Repository.Interface
{
    public interface IParticipanteGrupoRepository
    {
        IEnumerable<ParticipanteGrupo> BuscarPorId(int id);
        Task Inserir(ParticipanteGrupo participanteGrupo);
        Task Atualizar(ParticipanteGrupo participanteGrupo);
        Task Excluir(IEnumerable<ParticipanteGrupo> participanteGrupo);
    }
}
