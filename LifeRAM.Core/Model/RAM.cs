using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LifeRAM.Core.Model;

[Table("RAM")]
public class RAM
{
    public long Id { get; init; }

    public DateTimeOffset StartDateTime { get; set; }
    
    public TimeSpan Length { get; set; }
}

public class RAMDbContext : DbContext
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DbSet<RAM> RAM { get; set; } = null!;

    public RAMDbContext(DbContextOptions<RAMDbContext> options) : base(options)
    {
    }
}
