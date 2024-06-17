﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIChocoAmigo.Service.ViewModel.Usuario
{
    public class UsuarioViewModel
    {
        public int UsuarioId { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string? Foto { get; set; }
    }
}
