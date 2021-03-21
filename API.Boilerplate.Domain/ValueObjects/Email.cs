using System;
using System.Collections.Generic;
using System.Text;

namespace API.Boilerplate.Domain.ValueObjects
{
    public class Email
    {
        private string email;

        public Email(string email)
        {
            this.email = email;
        }

        public string Endereco { get; private set; }
    }
}
