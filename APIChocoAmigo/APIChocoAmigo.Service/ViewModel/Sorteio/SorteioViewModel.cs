﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIChocoAmigo.Service.ViewModel.Sorteio
{
    public class SorteioViewModel
    {
        public int SorteioId { get; set; }
        public int GrupoId { get; set; }
        public int UsuarioId { get; set; }
        public int UsuarioSorteado { get; set; }
    }
}
