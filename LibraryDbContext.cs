using BankSystemAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BankSystemAPI
{
    public class LibraryDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer("Data Source=(local);Initial Catalog=BankApi; Integrated Security=true; TrustServerCertificate=True");
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


    }
}
