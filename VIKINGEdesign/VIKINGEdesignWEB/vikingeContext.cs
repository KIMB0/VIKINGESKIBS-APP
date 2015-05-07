namespace VIKINGEdesignWEB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class vikingeContext : DbContext
    {
        public vikingeContext()
            : base("name=vikingeContext")
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
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Billeter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kunder>()
                .HasMany(e => e.Billeters)
                .WithRequired(e => e.Kunder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kunder>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Kunder)
                .WillCascadeOnDelete(false);
        }
    }
}
