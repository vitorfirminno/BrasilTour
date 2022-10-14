using BrasilTour.Models;
using Microsoft.EntityFrameworkCore;

namespace BrasilTour.Data {
    public class BancoContext : DbContext {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) {
        }
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}