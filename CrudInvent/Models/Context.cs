using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudInvent.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=Invent;Integrated Security=true");

        }
        public DbSet<Cadastro> Cadastros { get; set; }
    }
}
