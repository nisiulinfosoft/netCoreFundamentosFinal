using Microsoft.EntityFrameworkCore;
using NetCoreFundamentosFinal.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreFundamentosFinal.Contexto
{
    public class FundamentosContext : DbContext
    {
        public FundamentosContext
            (DbContextOptions<FundamentosContext> options)
            : base(options)
        {
        }

        public DbSet<Trabajador> Trabajador { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
