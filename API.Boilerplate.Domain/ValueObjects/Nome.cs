using System;
using System.Collections.Generic;
using System.Text;

namespace API.Boilerplate.Domain.ValueObjects
{
    public class Nome
    {
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
        }

        public string PrimeiroNome { get; private set; }

        public string UltimoNome { get; set; }
    }
}
