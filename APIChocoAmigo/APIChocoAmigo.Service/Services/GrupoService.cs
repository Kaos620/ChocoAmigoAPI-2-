using APIChocoAmigo.Repository.Interface;
using APIChocoAmigo.Repository.Repositories;
using APIChocoAmigo.Service.Interfaces;
using APIChocoAmigo.Service.ViewModel.Grupo;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIChocoAmigo.Service.Services
{
    public class GrupoService : IGrupoService
    {

        #region - Atributos e Construtores

        private readonly IGrupoRepository _grupoRepository;
        private IMapper _mapper;

        public GrupoService(IGrupoRepository grupoRepository, IMapper mapper)
        {
            _grupoRepository = grupoRepository;
            _mapper = mapper;
        }

        #endregion

        public Task Atualizar(GrupoViewModel grupo)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(int grupoId)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(NovoGrupoViewModel grupo, int UsuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<GrupoViewModel> ProcurarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GrupoViewModel> ProcurarTudo()
        {
            throw new NotImplementedException();
        }
    }
}
