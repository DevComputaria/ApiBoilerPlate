using System;
using System.Collections.Generic;
using System.Text;

namespace API.Boilerplate.Domain.Arguments.Usuario
{
    public class AdicionarUsuarioResponse
    {
        private Guid id;

        public AdicionarUsuarioResponse(Guid id)
        {
            this.id = id;
        }
    }
}
