using Microsoft.EntityFrameworkCore;
using Models;
namespace WebAPI_Teste.DataContext
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<Conta> Contas { get; set; }
    }
}
