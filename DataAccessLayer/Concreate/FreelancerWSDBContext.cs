using EntityLayer;
using EntityLayer.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    public class FreelancerWSDBContext : DbContext
    {
        public FreelancerWSDBContext()
        {
              
        }
        public FreelancerWSDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<TransactionHistory> TransactionHistories { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Wallet> Walllets { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            var datas = ChangeTracker.Entries<BaseEntity>();
            
            foreach (var data in datas) 
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreateDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdateDate = DateTime.UtcNow
                };

             }
            
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=FreelanceWSDB;username=postgres;password=123456");
        }



    }
}
