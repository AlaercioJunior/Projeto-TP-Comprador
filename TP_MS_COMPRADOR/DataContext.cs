using Microsoft.EntityFrameworkCore;
using Servicos;


namespace TP_MS_COMPRADOR
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<EntidadeComprador> Comprador { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntidadeComprador>().HasKey(p => p.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
