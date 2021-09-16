namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MagazinContext : DbContext
    {
        public MagazinContext()
            : base("name=MagazinContext")
        {
        }

        public virtual DbSet<PokProd> PokProd { get; set; }
        public virtual DbSet<Pokypka> Pokypka { get; set; }
        public virtual DbSet<Produkt> Produkt { get; set; }
        public virtual DbSet<Sotrydnik> Sotrydnik { get; set; }
        public virtual DbSet<Tip_produkta> Tip_produkta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokypka>()
                .HasMany(e => e.PokProd)
                .WithRequired(e => e.Pokypka)
                .HasForeignKey(e => e.Pokypka_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produkt>()
                .HasMany(e => e.PokProd)
                .WithRequired(e => e.Produkt)
                .HasForeignKey(e => e.Produkt_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sotrydnik>()
                .HasMany(e => e.Pokypka)
                .WithRequired(e => e.Sotrydnik)
                .HasForeignKey(e => e.Id_Sotrydnik_Fk)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tip_produkta>()
                .HasMany(e => e.Produkt)
                .WithRequired(e => e.Tip_produkta)
                .HasForeignKey(e => e.Id_Tip_produkta_FK)
                .WillCascadeOnDelete(false);
        }
    }
}
