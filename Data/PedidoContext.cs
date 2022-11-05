using Microsoft.EntityFrameworkCore;
using ControleEstoque.Models;

namespace ControleEstoque.Data
{
    public class PedidoContext : DbContext
    {
        public PedidoContext(DbContextOptions<PedidoContext> options) : base(options)
        {
        }

        public DbSet<Pedido> Encomendas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
            .HasNoKey();
        }
    }
}