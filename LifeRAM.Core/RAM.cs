using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LifeRAM.Core;

[Table("RAM")]
public class RAM
{
    public long Id { get; init; }

    public DateTimeOffset StartDateTime { get; set; }
    
    public TimeSpan Length { get; set; }
}

public class RAMDbContext : DbContext
{
    public DbSet<RAM>? RAM { get; set; }

    public RAMDbContext(DbContextOptions<RAMDbContext> options) : base(options)
    {
    }
}
