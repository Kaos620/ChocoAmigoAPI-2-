﻿using APIChocoAmigo.Service.Interfaces;
using APIChocoAmigo.Service.ViewModel.Grupo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIChocoAmigo.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GrupoController : ControllerBase
    {
        private readonly IGrupoService _grupoService;
        public GrupoController(IGrupoService grupoService)
        {
            _grupoService = grupoService;
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            var buscarGrupo = _grupoService.ProcurarPorId(id);

            return Ok(buscarGrupo);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NovoGrupoRequest novoGrupo)
        {
            _grupoService.Inserir(novoGrupo.NovoGrupo, novoGrupo.Id);

            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            //_grupoService.Atualizar()

            return Accepted();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _grupoService.Excluir(id);

            return Accepted();
        }
    }
}
