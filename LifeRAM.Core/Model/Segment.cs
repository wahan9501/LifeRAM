using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LifeRAM.Core.Model;

[Table("Segment")]
public class Segment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; init; }
    
    public long RAMId { get; init; }
    
    public DateTimeOffset StartDateTime { get; set; }
    
    public TimeSpan Length { get; set; }
}

public class SegmentDbContext : DbContext
{
    public DbSet<Segment> Segment { get; set; } = null!;

    public SegmentDbContext(DbContextOptions<SegmentDbContext> options) : base(options)
    {
    }
}