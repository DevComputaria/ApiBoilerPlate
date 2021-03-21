using API.boilerpalte.Infra.Persistence.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.boilerpalte.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApiBoilerplateContext _context;

        public UnitOfWork(ApiBoilerplateContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
