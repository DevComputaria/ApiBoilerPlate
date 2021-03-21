using API.Boilerplate.Domain.Entities;
using API.Boilerplate.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.boilerpalte.Infra.Persistence.EF.Map
{
    public class MapUsuario : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //Tabela
            builder.ToTable("Usuario");

            //Chave primaria
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Senha).HasMaxLength(36).IsRequired();

            //Mapeamento objetos de valor
            Action<OwnedNavigationBuilder<Usuario, Nome>> p = cb =>
                            {
                                cb.Property(x => x.PrimeiroNome).HasMaxLength(50);
                                cb.Property(x => x.UltimoNome).HasMaxLength(50);
                            };
            builder.OwnsOne<Nome>(x => x.Nome, p);

            builder.OwnsOne<Email>(x => x.Email, cb => cb.Property(x => x.Endereco).HasMaxLength(200));
        }
    }
}
