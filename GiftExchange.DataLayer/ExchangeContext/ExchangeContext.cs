using GiftExchange.DataLayer.ExchangeContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftExchange.DataLayer.ExchangeContext
{
    public class ExchangeCtxt : DbContext
    {

        public ExchangeCtxt()
            : base("name=ExchangeConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.AutoDetectChangesEnabled = true;

            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<ExchangeCtxt, ExchangeMigrationsConfiguration>());

        }

        public DbSet<Return> Return { get; set; }
        public DbSet<ReturnItem> ReturnItem { get; set; }
        public DbSet<ReturnOffer> ReturnOffer { get; set; }
        public DbSet<ReturnOfferItems> ReturnOfferItems { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<Guid>()
                .Where(info => info.Name.ToLower()== "id")
                .Configure(configuration => configuration.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity));

            modelBuilder.Entity<ReturnItem>()
                .HasRequired(r => r.Return)
                .WithMany(r => r.ReturnItems)
                .HasForeignKey(r => r.ReturnId);

            modelBuilder.Entity<ReturnOfferItems>()
                .HasRequired(r => r.ReturnOffer)
                .WithMany(r => r.ReturnOfferItems)
                .HasForeignKey(r => r.ReturnOfferId);
        
        }
    }

        
    class ExchangeMigrationsConfiguration : DbMigrationsConfiguration<ExchangeCtxt>
    {
            
        public ExchangeMigrationsConfiguration()
        {
                this.AutomaticMigrationDataLossAllowed = true;
                this.AutomaticMigrationsEnabled = true;
        }
    }
}
