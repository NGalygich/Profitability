using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.SqlServer;
using System.Windows;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.Common;
//using System.Data.Entity;
using System.Configuration;

 
public class ApplicationContext : DbContext
{
    //public DbSet<User> Users { get; set; } = null!;
    //public DbSet<User> Users => Set<User>();
    public ApplicationContext() => Database.EnsureCreated();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(System.Configuration.ConfigurationManager.ConnectionStrings["DbConnect"].ConnectionString);
    }
}
