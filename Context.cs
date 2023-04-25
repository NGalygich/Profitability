using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.Common;
//using System.Data.Entity;
using System.Configuration;

 
public class DatabaseContext : DbContext
{
    // public DbSet<User> Users { get; set; }
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //   var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Data Source=192.168.0.116;database=test_galyga;user id=sa;password=compasdt;Integrated Security=false;Trusted_Connection=False;Persist Security Info=True;MultipleActiveResultSets=true"].ConnectionString;
    //   optionsBuilder.UseSqlServer(connectionString);
    // }

    // public DatabaseContext() => Database.EnsureCreated();
    
   

    // public DatabaseContext(DbContextOptions s)
    // : base(s)
    // {
    // }

    public DbSet<User> Users { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(System.Configuration.ConfigurationManager.ConnectionStrings["DbConnect"].ConnectionString);
    }
    public DatabaseContext(){} // => Database.EnsureCreated(); // создание таблицы не проходит

}
