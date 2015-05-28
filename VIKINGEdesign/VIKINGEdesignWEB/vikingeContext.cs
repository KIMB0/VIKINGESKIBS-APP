namespace VIKINGEdesignWEB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VikingeContext : DbContext
    {
        public VikingeContext()
            : base("name=VikingeContext2")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Billeter> Billeters { get; set; }
        public virtual DbSet<Kunder> Kunders { get; set; }
        public virtual DbSet<Priser> Prisers { get; set; }
        public virtual DbSet<VikingeSkibe> VikingeSkibes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Billeter>()
                .Property(e => e.Pris)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Kunder>()
                .HasMany(e => e.Billeters)
                .WithRequired(e => e.Kunder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Priser>()
                .Property(e => e.Pris)
                .HasPrecision(19, 4);
        }
    }
}
