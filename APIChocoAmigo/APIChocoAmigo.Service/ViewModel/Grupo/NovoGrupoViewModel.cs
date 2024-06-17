﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIChocoAmigo.Service.ViewModel.Grupo
{
    public class NovoGrupoViewModel
    {
        public string NomeGrupo { get; set; }
        public int QtdMax { get; set; }
        public double Valor { get; set; } //poderia colocar SQLMoney
        public DateTime DataRevelacao { get; set; }
        public string? Descricao { get; set; }
        public string? Icone { get; set; }
        public string SenhaGrupo { get; set; }
    }

    public class NovoGrupoRequest
    {
        public int Id { get; set; }
        public NovoGrupoViewModel NovoGrupo { get; set; }
    }
}
