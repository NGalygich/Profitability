using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.Common;
//using System.Data.Entity;
using System.Configuration;

 
public class DatabaseContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Data Source=192.168.0.116;database=test_galyga;user id=sa;password=compasdt;Integrated Security=false;Trusted_Connection=False;Persist Security Info=True;MultipleActiveResultSets=true"].ConnectionString;
      optionsBuilder.UseSqlServer(connectionString);
    }

    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions s)
    : base(s)
    {
    }
}
