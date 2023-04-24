using Microsoft.EntityFrameworkCore;
 
public class ApplicationContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=192.168.0.116;Database=test_galyga;user id=sa;password=compasdt;Integrated Security=false;Trusted_Connection=False;Persist Security Info=True;MultipleActiveResultSets=true");
    }
}
