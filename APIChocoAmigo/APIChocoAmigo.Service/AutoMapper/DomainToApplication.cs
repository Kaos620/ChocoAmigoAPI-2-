using APIChocoAmigo.Domain.Entities;
using APIChocoAmigo.Service.ViewModel.Grupo;
using APIChocoAmigo.Service.ViewModel.ParticipanteGrupo;
using APIChocoAmigo.Service.ViewModel.Sorteio;
using APIChocoAmigo.Service.ViewModel.Usuario;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIChocoAmigo.Service.AutoMapper
{
    public class DomainToApplication : Profile
    {
        public DomainToApplication()
        {
            CreateMap<Grupo, GrupoViewModel>();
            CreateMap<ParticipanteGrupo, ParticipanteGrupoViewModel>();
            CreateMap<Sorteio, SorteioViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}
