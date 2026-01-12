using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using UsuariosApi.data.Dtos;
using UsuariosApi.Modelos;
using UsuariosApi.Service;

namespace UsuariosApi.Controllers;

[ApiController]
[Route("Api/[Controller]")]
public class UsuarioController : ControllerBase
{
   
    private CadastroService _cadastroService;

    public UsuarioController (CadastroService cadastroService)
    {
        _cadastroService = cadastroService;
    }

    [HttpPost]
    public async Task<IActionResult> CasdastraUsuario(CreateUsuarioDto usuarioDto)
    {
      await  _cadastroService.Casdastra(usuarioDto);

        return Ok("O Usuario foi cadastrado Com Susseço");
    }




}


