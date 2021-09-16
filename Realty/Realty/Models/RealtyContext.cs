using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RealtyProg.Models
{
    public class RealtyContext : IdentityDbContext<User> //описание контекста базы данных
    {
        #region Constructor
        public RealtyContext(DbContextOptions<RealtyContext> options)
            : base(options)
        { }
        #endregion

        public virtual DbSet<Realty> Realty { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Realty>(entity =>
            {
                entity.Property(e => e.Adress).IsRequired();

                entity.HasOne(d => d.Klient)
                    .WithMany(p => p.Realty)
                    .HasForeignKey(d => d.KlientId);

                entity.HasOne(d => d.Property)
                   .WithMany(p => p.Realty)
                   .HasForeignKey(d => d.PropertyId);
       
            });

            modelBuilder.Entity<Klient>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });


            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasOne(d => d.Realty)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.RealtyId);

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.AgentId);
            });

        }
    }
}
