using APIChocoAmigo.Domain.Entities;
using APIChocoAmigo.Repository.EntityFramework;
using APIChocoAmigo.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIChocoAmigo.Repository.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        #region - Atributos/Construtores

        private readonly Contexto _contexto;

        public UsuarioRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion

        public Task Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> Autenticar(string email, string senha)
        {
            try
            {
                var usuario = await _contexto.Usuario.Where(filtro =>
                        filtro.Email == email && filtro.Senha == senha).FirstOrDefaultAsync();

            return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar o usuário: {ex.Message}");
            }
        }

        public async Task<Usuario> BuscarPorId(int id)
        {
            try
            {
                var usuario = await _contexto.Usuario.Where(c => c.UsuarioId == id).FirstOrDefaultAsync();

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar o usuário: {ex.Message}");
            }
        }

        public async Task Excluir(Usuario usuario)
        {
            try
            {
                _contexto.Usuario.Remove(usuario);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir usuário: {ex.Message}");
            }
        }

        public async Task Inserir(Usuario usuario)
        {
            try
            {
                await _contexto.Usuario.AddAsync(usuario);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir usuário: {ex.Message}");
            }
        }
    }
}
