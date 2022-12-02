using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atos_ProjetoFinal
{
    internal class Context: DbContext
    {
        public Context()
        {

        }
        public DbSet<Biblioteca> biblioteca { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; " + "initial Catalog=DbLib;User ID=Library; " + "password=senha;language=Portuguese;Trusted_Connection=True;" + "TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}
