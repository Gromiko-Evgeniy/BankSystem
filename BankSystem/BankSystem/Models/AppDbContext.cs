using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasOne(x => x.BankAccount)
                .WithOne(x => x.Company)
                .HasForeignKey<Company>(x => x.BankAccountId);

            //modelBuilder.Entity<User>()
            //.Property(f => f.Id)
            //.ValueGeneratedOnAdd();

            //modelBuilder.Entity<Bank>()
            //.HasOne(x => x.Clients)
            //.WithOne(x => x.Bank)
            //.HasForeignKey(x => x.CategoryId);


            //        modelBuilder.Entity<ContactCategory>()
            //.HasOne(x => x.Category)
            //.WithMany(x => x.ContactCategories)
            //.HasForeignKey(x => x.CategoryId);
            // для отношения user-company
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}
