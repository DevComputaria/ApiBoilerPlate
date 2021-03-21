using API.Boilerplate.Domain.Entities.Base;
using API.Boilerplate.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Boilerplate.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public Usuario()
        {

        }

        public Usuario(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public Nome Nome { get; private set; }

        public Email Email { get; private set; }

        public string Senha { get; private set; }
    }
}
