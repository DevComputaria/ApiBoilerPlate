using API.Boilerplate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Boilerplate.Domain.Interfaces.Repositories
{
    public interface IRepositoryUsuario
    {
        Usuario Obter(Guid id);

        Usuario Obter(string email, string senha);

        void Salvar(Usuario usuario);

        bool Existe(string email);
    }
}
