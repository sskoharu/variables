using Microsoft.EntityFrameworkCore;
using MVC6.Models;
namespace MVC6.Config
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ClienteModel> Clientes { get; set; }
    }
}
