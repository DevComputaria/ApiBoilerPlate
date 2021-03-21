using System;
using System.Collections.Generic;
using System.Text;

namespace API.Boilerplate.Domain.Arguments.Usuario
{
    public class AdicionarUsuarioRequest
    {
        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
