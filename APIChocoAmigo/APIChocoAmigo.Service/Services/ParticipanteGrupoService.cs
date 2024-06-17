using APIChocoAmigo.Service.Interfaces;
using APIChocoAmigo.Service.ViewModel.Grupo;
using APIChocoAmigo.Service.ViewModel.ParticipanteGrupo;
using APIChocoAmigo.Service.ViewModel.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIChocoAmigo.Service.Services
{
    public class ParticipanteGrupoService : IParticipanteGrupoService
    {
        public Task Atualizar(ParticipanteGrupoViewModel participanteGrupo)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(int usuarioId, int grupoId)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(int grupoId, int usuarioId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GrupoViewModel?> ProcurarGruposUsuario(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioViewModel?> ProcurarUsuariosGrupo(int grupoId)
        {
            throw new NotImplementedException();
        }
    }
}
