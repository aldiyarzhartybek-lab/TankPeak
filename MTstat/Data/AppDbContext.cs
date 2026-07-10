using Microsoft.EntityFrameworkCore;
using MTstat.Models;

namespace MTstat.Data;

public class AppDbContext : DbContext
{
    public DbSet<PlayerStats> PlayerStats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=tankpeak.db");
    }
}