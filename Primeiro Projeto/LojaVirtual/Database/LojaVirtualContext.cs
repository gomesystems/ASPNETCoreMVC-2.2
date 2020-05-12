using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Database
{
    public class LojaVirtualContext : DbContext
    {
        //EF > ORM - biblioteca para mapear objetos para banco de dados

        public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options) : base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<NewsLetterEmail> NewsLetterEmails { get; set; }
    }
}


