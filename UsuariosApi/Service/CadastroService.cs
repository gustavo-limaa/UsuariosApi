using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using UsuariosApi.data.Dtos;
using UsuariosApi.Modelos;
using UsuariosApi.Service;

using Microsoft.AspNetCore.Http.HttpResults;

namespace UsuariosApi.Service;

public class CadastroService
{
    private IMapper _mapper;
    private UserManager<Usuario> _userManager;

    public CadastroService(IMapper mapper, UserManager<Usuario> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }



    public async Task Casdastra(CreateUsuarioDto usuarioDto)
    {

        Usuario usuario = _mapper.Map<Usuario>(usuarioDto);

        IdentityResult resultado = await
            _userManager.CreateAsync(usuario, usuarioDto.Password);

        if (!resultado.Succeeded)
        {
            throw new ApplicationException("Falha ao cadastrar usuário!");

        }
}
}