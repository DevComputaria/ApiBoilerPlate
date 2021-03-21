using API.Boilerplate.Domain.Entities;
using API.Boilerplate.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.boilerpalte.Infra.Persistence.EF
{
    public class ApiBoilerplateContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public ApiBoilerplateContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder oprtionsBuilder)
        {
            oprtionsBuilder.UseSqlServer(Settings.ConnectionString);
        }
    }
}
