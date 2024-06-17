﻿using APIChocoAmigo.Service.Interfaces;
using APIChocoAmigo.Service.ViewModel.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIChocoAmigo.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public IActionResult Get(string email, string senha)
        {
            var autenticarUsuarios = _usuarioService.Autenticar(email, senha);
            return Ok(autenticarUsuarios);
        }

        [HttpGet("{id}")]//colocaria oque aqui? Nome do Usuario?
        public IActionResult GetId(string email, string senha)
        {
            var procurarUsuarios = _usuarioService.Autenticar(email, senha);

            return Ok(procurarUsuarios);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NovoUsuarioViewModel novoUsuario)
        {
            _usuarioService.Inserir(novoUsuario);

            return Created();
        }


        [HttpPut("{id}")]
        public IActionResult Put([FromBody] UsuarioViewModel usuarioId)
        {
            _usuarioService.Atualizar(usuarioId);

            return Accepted();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _usuarioService.Excluir(id);

            return Accepted();
        }

    }
}
