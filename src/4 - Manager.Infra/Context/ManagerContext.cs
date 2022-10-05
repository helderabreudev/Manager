using Manager.Domain.Entities;
using Manager.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Manager.Infra.Context;

    public class ManagerContext : DbContext
    {
        public virtual DbSet<User>? Users {get; set;}
        public ManagerContext() {}
        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options) {}
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=HELDINHO-4FIACF;Initial Catalog=USERMANAGERAPI;Trusted_Connection=True");
        } 
        */
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
        }
    }