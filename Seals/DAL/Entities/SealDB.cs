namespace DAL.Entities
{
    using System.Data.Entity;

    public partial class SealDB : DbContext
    {
        public SealDB()
            : base("name=SealDB")
        {
        }

        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Seal> Seal { get; set; }
        public virtual DbSet<Sreda> Sreda { get; set; }
        public virtual DbSet<Tip_Hol> Tip_Hol { get; set; }
        public virtual DbSet<Tip_Seal> Tip_Seal { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>()
                .Property(e => e.NameM)
                .IsFixedLength();

            modelBuilder.Entity<Seal>()
                .Property(e => e.NameSeal)
                .IsFixedLength();

            modelBuilder.Entity<Seal>()
                .Property(e => e.Nasos)
                .IsFixedLength();

            modelBuilder.Entity<Seal>()
                .Property(e => e.Features)
                .IsFixedLength();

            modelBuilder.Entity<Sreda>()
                .Property(e => e.NameS)
                .IsFixedLength();

            modelBuilder.Entity<Tip_Hol>()
                .Property(e => e.NameHol)
                .IsFixedLength();

            modelBuilder.Entity<Tip_Seal>()
                .Property(e => e.NameSe)
                .IsFixedLength();
        }
    }
}
