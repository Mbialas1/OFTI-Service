using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OFTI_Service.Entities
{
    public class UsersWorkerDbContext : DbContext
    {
        #region SQL
        private readonly string connectionSQL =
            "Server=(localdb)\\mssqllocaldb;Database=OFITDb;Trusted_Connection=True;";
        #endregion
        public DbSet<UsersWorker> UsersWorkers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UsersWorker>()
                .Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<UsersWorker>()
                .Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<UsersWorker>()
                .Property(u => u.LoginName)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<UsersWorker>()
                .Property(u => u.Master);

            modelBuilder.Entity<UsersWorker>()
                .Property(u => u.Admin);

            modelBuilder.Entity<UsersWorker>()
                .Property(u => u.LastLogged)
                .IsRequired();

            modelBuilder.Entity<UsersWorker>()
                .Property(u => u.FirstLogged)
                .IsRequired();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(connectionSQL);
        }
    }
}
