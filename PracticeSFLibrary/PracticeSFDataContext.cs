using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSFLibrary
{
    public class PracticeSFDataContext : DbContext
    {

        private string _connectionString;

        public PracticeSFDataContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Simcha> Simchas { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Contribution> Contributions { get; set; }
        public DbSet<Contributor> Contributors { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<ContributionWithInclude> ContributionWithIncludes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            modelBuilder.Entity<Contribution>()
                .HasKey(c => new { c.ContributorId, c.SimchaId });




            base.OnModelCreating(modelBuilder);


        }



    }
}
