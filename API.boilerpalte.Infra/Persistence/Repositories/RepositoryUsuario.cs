using API.boilerpalte.Infra.Persistence.EF;
using API.Boilerplate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.boilerpalte.Infra.Persistence.Repositories
{
    public class RepositoryUsuario
    {
        private readonly ApiBoilerplateContext _context;

        public RepositoryUsuario(ApiBoilerplateContext context)
        {
            context = _context;
        }

        public bool Existe(string email)
        {
            return _context.Usuarios.Any(x => x.Email.Endereco == email);
        }

        public Usuario Obter(Guid id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public Usuario Obter(string email, string senha)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Email.Endereco == email && x.Senha == senha);
        }

        public void Salvar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
        }
    }
}
