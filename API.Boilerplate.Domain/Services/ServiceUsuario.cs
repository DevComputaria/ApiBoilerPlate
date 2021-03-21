using API.Boilerplate.Domain.Arguments.Usuario;
using API.Boilerplate.Domain.Entities;
using API.Boilerplate.Domain.Interfaces.Repositories;
using API.Boilerplate.Domain.Interfaces.Services;
using API.Boilerplate.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Boilerplate.Domain.Services
{
    public class ServiceUsuario : IServiceUsuario
    {
        //Dependências do serviço
        private readonly IRepositoryUsuario _repositoryUsuario;

        //Construtor
        public ServiceUsuario(IRepositoryUsuario repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        }

        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            
            //Cria value objects
            Nome nome = new Nome(request.PrimeiroNome, request.UltimoNome);


            Email email = new Email(request.Email);


            Usuario usuario = new Usuario(nome, email, request.Senha);


            //persistir no banco de dados 
            _repositoryUsuario.Salvar(usuario);

            return new AdicionarUsuarioResponse(usuario.Id);
        }
    }
}
