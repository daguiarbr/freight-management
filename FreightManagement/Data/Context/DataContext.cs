using Data.EntityConfig;
using System;
using System.Linq;

namespace Data.Context
{
    using Domain.Entities;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class DataContext : DbContext
    {
        static DataContext()
        {
            Database.SetInitializer<DataContext>(null);
        }

        public DataContext() : base("DefaultConnection") { }

        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<CarrierPhoneNumber> CarrierPhoneNumbers { get; set; }
        public DbSet<Rating> Ratings { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(120));

            modelBuilder.Configurations.Add(new CarrierConfiguration());
            modelBuilder.Configurations.Add(new CarrierPhoneNumberConfiguration());
            modelBuilder.Configurations.Add(new RatingLinkConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreateDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreateDate").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreateDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }

}