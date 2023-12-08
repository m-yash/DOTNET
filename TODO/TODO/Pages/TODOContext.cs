using Microsoft.EntityFrameworkCore;

public class TODOContext : DbContext
{
    public TODOContext(DbContextOptions<TODOContext> options): base(options)
    {

    }

    public DbSet<TODOItem> Todos {get; set;}
}