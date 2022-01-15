using EFCore2._1UpgradeTo5._0;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFCore2._1UpgradeTo5._0WebApp
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BankDbContext>
    {
        public BankDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BankDbContext>();
            builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;multipleactiveresultsets=True;").EnableSensitiveDataLogging();
            return new BankDbContext(builder.Options);
        }
    }
}
