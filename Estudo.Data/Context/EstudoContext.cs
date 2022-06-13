using Estudo.Data.Extensions;
using Estudo.Data.Mappings;
using Estudo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estudo.Data.Context
{
    public class EstudoContext : DbContext
    {
        public EstudoContext(DbContextOptions<EstudoContext> option)
            : base(option) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
