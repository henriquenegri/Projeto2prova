using Microsoft.EntityFrameworkCore;
using Projeto2prova.Models;

namespace Projeto2prova.Context
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options)
        {

        }

        public DbSet<Cad_Clientes> Clientes { get; set; }
    }
}
