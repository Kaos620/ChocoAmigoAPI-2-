using APIChocoAmigo.Service.ViewModel.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIChocoAmigo.Service.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioViewModel?> Autenticar(string email, string senha);
        Task RecuperarSenha(string email);
        Task Inserir(NovoUsuarioViewModel usuario);
        Task Atualizar(UsuarioViewModel usuario);
        Task Excluir(int usuarioId);
    }
}
