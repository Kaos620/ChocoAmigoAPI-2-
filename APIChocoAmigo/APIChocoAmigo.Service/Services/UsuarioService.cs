using APIChocoAmigo.Domain.Entities;
using APIChocoAmigo.Repository.Interface;
using APIChocoAmigo.Service.Interfaces;
using APIChocoAmigo.Service.ViewModel.Usuario;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIChocoAmigo.Service.Services
{
    public class UsuarioService : IUsuarioService
    {

        #region - Atributos e Construtores

        private readonly IUsuarioRepository _usuarioRepository;
        private IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        #endregion

        public Task Atualizar(UsuarioViewModel usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<UsuarioViewModel?> Autenticar(string email, string senha)
        {
            try
            {
                var usuario = await _usuarioRepository.Autenticar(email, senha);
                return _mapper.Map<UsuarioViewModel>(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao autenticar usuário (service): {ex.Message}");
            }
        }

        public Task Excluir(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public async Task Inserir(NovoUsuarioViewModel usuario)
        {
            try
            {
                var novoUsuario = _mapper.Map<Usuario>(usuario);
                await _usuarioRepository.Inserir(novoUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir usuário (service): {ex.Message}");
            }
        }

        public Task RecuperarSenha(string email)
        {
            throw new NotImplementedException();
        }
    }
}
