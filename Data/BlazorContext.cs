
using Microsoft.EntityFrameworkCore;

namespace blazor_example.Data;
public class BlazorContext : DbContext
{
    public BlazorContext(DbContextOptions options)
                   : base(options)
    {
    }


    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
}
