
using Microsoft.EntityFrameworkCore;

public class ElectionDbContext : DbContext
{
    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Topic> Topics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        string? ConnectionString = Environment.GetEnvironmentVariable("ELECTION_DB_CONN");
        optionsBuilder.UseNpgsql(ConnectionString);
    }
}
