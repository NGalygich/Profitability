using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

 
public class ApplicationContext : DbContext
{
    
    public DbSet<User> Users => Set<User>();
    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // var builder = new SqlConnectionStringBuilder
        // {
        //     DataSource = @"IP_ADDRESS\INSTANCE",
        //     InitialCatalog = "DbName",
        //     UserID = "MyUserId",
        //     Password = "MyPassword"
        // };

        // var connectionString = builder.ConnectionString;

        // // Use connection string
        // optionsBuilder.UseSqlServer(connectionString );

        optionsBuilder.UseSqlServer("server=192.168.0.116;database=test_galyga;user id=sa;password=compasdt;Integrated Security=false;Trusted_Connection=False;Persist Security Info=True;MultipleActiveResultSets=true");
    }
    
    /*
    protected readonly IConfiguration Configuration;
    public DataContext() => Database.EnsureCreated();


    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sql server with connection string from app settings
        options.UseSqlServer(Configuration.GetConnectionString("server=192.168.0.116;database=test_galyga;user id=sa;password=compasdt;Integrated Security=false;Trusted_Connection=False;Persist Security Info=True;MultipleActiveResultSets=true"));
    }

    public DbSet<User> Users { get; set; }
    */
}
