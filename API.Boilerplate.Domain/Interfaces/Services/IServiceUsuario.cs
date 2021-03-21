using API.Boilerplate.Domain.Arguments.Usuario;
using API.Boilerplate.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Boilerplate.Domain.Interfaces.Services
{
    public interface IServiceUsuario : IServiceBase
    {
        AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request);
    }
}
