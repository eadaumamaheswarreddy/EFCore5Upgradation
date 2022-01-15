using EFCore2._1UpgradeTo5._0WebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EFCore2._1UpgradeTo5._0
{
    public class BankDbContext : IdentityDbContext<IdentityUser>
    {
        public BankDbContext(DbContextOptions<BankDbContext> options):base(options)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ProcessBank> ProcessBanks { get; set; }
        public DbSet<BankStatusLog> BankStatusLogs { get; set; }

    }
}
